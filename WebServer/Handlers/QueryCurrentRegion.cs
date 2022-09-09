using System.Text.RegularExpressions;
using Ceen;
using Newtonsoft.Json;
using Weedwacker.Shared.Utils;
using Weedwacker.WebServer;

namespace Weedwacker.WebServer.Handlers
{
    internal class QueryCurrentRegion : IHttpModule
    {
        private struct QueryCurRegionRspJson
        {
            public string content;
            public string sign;
        }

        public Task<bool> HandleAsync(IHttpContext context)
        {
            var req = context.Request;
            // Get region to query.
            string regionName = req.Path.Split('/').Last();
            string versionName = req.QueryString["version"];
            // Get region data.
            string regionData = "CAESGE5vdCBGb3VuZCB2ZXJzaW9uIGNvbmZpZw==";
            if (req.QueryString.Count > 0)
            {
                if (RegionManager.Regions.TryGetValue(regionName, out RegionManager.RegionData region))
                    regionData = region.base64;
            }

            string[] versionCode = new Regex("[a-zA-Z]").Replace(versionName, "").Split("\\.");
            int versionMajor = int.Parse(versionCode[0]);
            int versionMinor = int.Parse(versionCode[1]);
            int versionFix = int.Parse(versionCode[2]);

            if (versionMajor >= 3 || (versionMajor == 2 && versionMinor == 7 && versionFix >= 50) || (versionMajor == 2 && versionMinor == 8))
            {
                try
                {
                    //TODO QueryCurrentRegionEvent  

                    if (req.QueryString.ContainsKey("dispatchSeed"))
                    {
                        // More love for UA Patch players
                        var response = new RegionManager.QueryCurRegionRspJson
                        {
                            content = regionData,
                            sign = "TW9yZSBsb3ZlIGZvciBVQSBQYXRjaCBwbGF5ZXJz"
                        };

                        context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(response));
                        return Task.FromResult(true);
                    }

                    string key_id = req.QueryString["key_id"];
                    Cipher cipher = Cipher.getInstance("RSA/ECB/PKCS1Padding");
                    cipher.init(Cipher.ENCRYPT_MODE, key_id.Equals("3") ? Crypto.CUR_OS_ENCRYPT_KEY : Crypto.CUR_CN_ENCRYPT_KEY);
                    var regionInfo = Convert.FromBase64String(regionData);

                    //Encrypt regionInfo in chunks
                    ByteArrayOutputStream encryptedRegionInfoStream = new ByteArrayOutputStream();

                    //Thank you so much GH Copilot
                    int chunkSize = 256 - 11;
                    int regionInfoLength = regionInfo.Length;
                    int numChunks = (int)Math.Ceiling(regionInfoLength / (double)chunkSize);

                    for (int i = 0; i < numChunks; i++)
                    {
                        byte[] chunk = Arrays.copyOfRange(regionInfo, i * chunkSize, Math.Min((i + 1) * chunkSize, regionInfoLength));
                        byte[] encryptedChunk = cipher.doFinal(chunk);
                        encryptedRegionInfoStream.write(encryptedChunk);
                    }

                    Signature privateSignature = Signature.getInstance("SHA256withRSA");
                    privateSignature.initSign(Crypto.CUR_SIGNING_KEY);
                    privateSignature.update(regionInfo);

                    var rsp = new QueryCurRegionRspJson
                    {
                        content = Convert.ToBase64String(encryptedRegionInfoStream.toByteArray()),
                        sign = Convert.ToBase64String(privateSignature.sign())
                    };

                    context.Response.WriteAllJsonAsync(JsonConvert.SerializeObject(rsp));
                }
                catch (Exception e)
                {
                    Logger.WriteErrorLine("An error occurred while handling query_cur_region.", e);
                }
            }
            else
            {
                //TODO QueryCurrentRegionEvent

                context.Response.WriteAllAsync(regionData);
            }
            // Log to console.
            Logger.WriteLine(string.Format("Client {0}s request: query_cur_region/{1}s", context.GetRemoteIP(), regionName));
        
            return Task.FromResult(true);
        }
    }
}
