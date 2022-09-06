using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.Server.Proto;
using System.Net;
using Google.Protobuf;
using Ceen;

namespace Weedwacker.Server
{
    internal static class RegionManager
    {
        private struct Region
        {
            private Region(string name, string title, string address, uint port)
            {
                this.Name = name;
                this.Title = title;
                this.Ip = address;
                this.Port = port;
            }
            public string Name = "os_usa", Title = "Weedwacker", Ip = "127.0.0.1";
            public uint Port = 22102;
        }
        public struct RegionData
        {
            private QueryCurrRegionHttpRsp regionQuery;
            public string base64;

            public RegionData(QueryCurrRegionHttpRsp updatedQuery, string v)
            {
                regionQuery = updatedQuery;
                base64 = v;
            }


        }

        private static Dictionary<string, RegionData> regions = new();
        private static String? regionListResponse;

        public static void Initialize()
        {
            Byte[] dispatchKey = File.ReadAllBytes(Config.GetString("dispatchKey", "keyPaths"));
            List<RegionSimpleInfo> servers = new();
            List<String> usedNames = new(); // List to check for potential naming conflicts.

            string dispatchDomain = "http" + (Config.GetBool("useInRouting", "http") ? "s" : "") + "://"
                + Config.lr(Config.GetString("accessAddress", "http"), Config.GetString("bindAddress", "http") + ":"
                + Config.lr(Config.GetInt("accessPort", "http"), Config.GetInt("bindPort", "http")));
            List<Region> configuredRegions = new();// Config.GetArray("regions","dispatch");

            if (Config.GetString("runMode") != "HYBRID" && configuredRegions.Count() == 0) //DISPATCH or GAME
            {
                Logger.WriteErrorLine("No configured server regions. Shutting down...");
                Environment.Exit(1);
            }
            else if (configuredRegions.Count() == 0) //HYBRID
            {
                Logger.DebugWriteLine("[Dispatch] Loading default region");
                configuredRegions.Add(new Region());
            }

            configuredRegions.ForEach(region =>
                {
                    if (usedNames.Contains(region.Name))
                    {
                        Logger.WriteErrorLine("Region name conflict");
                        return;
                    }
                    // Create a region identifier.
                    var identifier = new RegionSimpleInfo();
                    identifier.Name = region.Name;
                    identifier.Title = region.Title;
                    identifier.Type = "DEV_PUBLIC";
                    identifier.DispatchUrl = dispatchDomain + "/query_cur_region/" + region.Name;
                    usedNames.Add(region.Name); servers.Add(identifier);

                    // Create a region info object.
                    var regionInfo = new RegionInfo();
                    regionInfo.GateserverIp = region.Ip;
                    regionInfo.GateserverPort = region.Port;
                    regionInfo.SecretKey = ByteString.CopyFrom(dispatchKey); ;

                    // Create an updated region query.
                    var updatedQuery = new QueryCurrRegionHttpRsp();
                    updatedQuery.RegionInfo = regionInfo;
                    regions.Add(region.Name, new RegionData(updatedQuery, Convert.ToBase64String(updatedQuery.ToByteString().ToByteArray())));
                });

            // Create a config object.
            byte[] customConfig = Encoding.Default.GetBytes("{\"sdkenv\":\"2\",\"checkdevice\":\"false\",\"loadPatch\":\"false\",\"showexception\":\"false\",\"regionConfig\":\"pm|fk|add\",\"downloadMode\":\"0\"}");
            Utils.xor(customConfig, dispatchKey); // XOR the config with the key.

            QueryRegionListHttpRsp updatedRegionList = new QueryRegionListHttpRsp();
            updatedRegionList.RegionList.Add(servers);
            updatedRegionList.EnableLoginPc = true;
            updatedRegionList.ClientSecretKey = ByteString.CopyFrom(File.ReadAllBytes(Config.GetString("dispatchKey", "keyPaths")));
            updatedRegionList.ClientCustomConfigEncrypted = ByteString.CopyFrom(customConfig);

            // Set the region list response.
            regionListResponse = Convert.ToBase64String(updatedRegionList.ToByteString().ToByteArray());
        }

        public static async Task<string> QueryRegionList()
        {
            return regionListResponse;
        }

        public static async void QueryCurrentRegion(IHttpContext ctx)
        {
            // Get region to query.
            String regionName = ctx.Request.pathParam("region");
            String versionName = ctx.queryParam("version");

            // Get region data.
            String regionData = "CAESGE5vdCBGb3VuZCB2ZXJzaW9uIGNvbmZpZw==";
            if (ctx.queryParamMap().values().size() > 0)
            {
                if (regions.TryGetValue(regionName, out RegionData region))
                    regionData = region.base64;
            }

            String[] versionCode = versionName.replaceAll(Pattern.compile("[a-zA-Z]").pattern(), "").split("\\.");
            int versionMajor = int.Parse(versionCode[0]);
            int versionMinor = int.Parse(versionCode[1]);
            int versionFix = int.Parse(versionCode[2]);

            if (versionMajor >= 3 || (versionMajor == 2 && versionMinor == 7 && versionFix >= 50) || (versionMajor == 2 && versionMinor == 8))
            {
                try
                {
                    //TODO QueryCurrentRegionEvent  

                    if (ctx.queryParam("dispatchSeed") == null)
                    {
                        // More love for UA Patch players
                        var rsp = new QueryCurRegionRspJson();

                        rsp.content = regionData;
                        rsp.sign = "TW9yZSBsb3ZlIGZvciBVQSBQYXRjaCBwbGF5ZXJz";

                        ctx.json(rsp);
                        return;
                    }

                    string key_id = ctx.queryParam("key_id");
                    Cipher cipher = Cipher.getInstance("RSA/ECB/PKCS1Padding");
                    cipher.init(Cipher.ENCRYPT_MODE, key_id.equals("3") ? Crypto.CUR_OS_ENCRYPT_KEY : Crypto.CUR_CN_ENCRYPT_KEY);
                    var regionInfo = Convert.FromBase64String(regionData);

                    //Encrypt regionInfo in chunks
                    ByteArrayOutputStream encryptedRegionInfoStream = new ByteArrayOutputStream();

                    //Thank you so much GH Copilot
                    int chunkSize = 256 - 11;
                    int regionInfoLength = regionInfo.Length;
                    int numChunks = (int)Math.ceil(regionInfoLength / (double)chunkSize);

                    for (int i = 0; i < numChunks; i++)
                    {
                        byte[] chunk = Arrays.copyOfRange(regionInfo, i * chunkSize, Math.min((i + 1) * chunkSize, regionInfoLength));
                        byte[] encryptedChunk = cipher.doFinal(chunk);
                        encryptedRegionInfoStream.write(encryptedChunk);
                    }

                    Signature privateSignature = Signature.getInstance("SHA256withRSA");
                    privateSignature.initSign(Crypto.CUR_SIGNING_KEY);
                    privateSignature.update(regionInfo);

                    var rsp = new QueryCurRegionRspJson();

                    rsp.content = Convert.ToBase64String(encryptedRegionInfoStream.toByteArray());
                    rsp.sign = Convert.ToBase64String(privateSignature.sign());

                    ctx.json(rsp);
                }
                catch (Exception e)
                {
                    Logger.WriteErrorLine("An error occurred while handling query_cur_region.", e);
                }
            }
            else
            {
                //TODO QueryCurrentRegionEvent

                ctx.result(event.getRegionInfo());
            }
            // Log to console.
            Logger.WriteLine(String.Format("Client {0}s request: query_cur_region/{1}s", ctx.ip(), regionName));
        }     
    }
}
