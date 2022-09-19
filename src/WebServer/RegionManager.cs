using System.Text;
using Google.Protobuf;
using Weedwacker.Shared.Utils;
using Weedwacker.Shared.Network.Proto;


namespace Weedwacker.WebServer
{
    internal static class RegionManager
    {

        public class RegionData
        {
            public QueryCurrRegionHttpRsp regionQuery { get; set; }
            public string base64 { get; set; }

            public RegionData(QueryCurrRegionHttpRsp updatedQuery, string v)
            {
                regionQuery = updatedQuery;
                base64 = v;
            }
        }

        public class QueryCurRegionRspJson
        {
            public string content { get; set; }
            public string sign { get; set; }
        }

        // All information about configured regions' game servers
        public static Dictionary<string, RegionData> Regions { get; private set; } = new();

        public static string RegionListResponse { get; private set; } = "";

        public static void Initialize()
        {
            var kestrel = WebServer.Configuration.Kestrel;


            List<RegionSimpleInfo> servers = new();
            List<string> usedNames = new(); // List to check for potential naming conflicts.

            string dispatchDomain = WebServer.Configuration.Server.EnforceEncryption ? kestrel.Endpoints.Https.Url : kestrel.Endpoints.Http.Url;

            List<WebConfig.Region> configuredRegions = WebServer.Configuration.Server.Dispatch.Regions;

            if (configuredRegions.Count == 0)
            {
                Logger.DebugWriteLine("No Configured Game Servers found. Loading default game server region");
                configuredRegions.Add(new WebConfig.Region());
            }

            configuredRegions.ForEach(region =>
                {
                    if (usedNames.Contains(region.Name))
                    {
                        Logger.WriteErrorLine("Region name conflict");
                        return;
                    }
                    // Create a region identifier.
                    var identifier = new RegionSimpleInfo()
                    {
                        Name = region.Name,
                        Title = region.Title,
                        Type = "DEV_PUBLIC",
                        DispatchUrl = dispatchDomain + "/query_cur_region/" + region.Name
                    };
                    usedNames.Add(region.Name);
                    servers.Add(identifier);

                    // Create a region info object.
                    var regionInfo = new RegionInfo()
                    {
                        GateserverIp = region.Ip,
                        GateserverPort = region.Port,
                        SecretKey = ByteString.CopyFrom(Crypto.DISPATCH_SEED)
                    };

                    // Create an updated region query.
                    var updatedQuery = new QueryCurrRegionHttpRsp();
                    updatedQuery.RegionInfo = regionInfo;
                    Regions.Add(region.Name, new RegionData(updatedQuery, Convert.ToBase64String(updatedQuery.ToByteString().ToByteArray())));
                });

            // Create a config object.
            byte[] customConfig = Encoding.Default.GetBytes("{\"sdkenv\":\"2\",\"checkdevice\":\"false\",\"loadPatch\":\"false\",\"showexception\":\"false\",\"regionConfig\":\"pm|fk|add\",\"downloadMode\":\"0\"}");
            Crypto.Xor(customConfig, Crypto.DISPATCH_KEY);

            QueryRegionListHttpRsp updatedRegionList = new QueryRegionListHttpRsp();
            updatedRegionList.RegionList.Add(servers);
            updatedRegionList.EnableLoginPc = true;
            updatedRegionList.ClientSecretKey = ByteString.CopyFrom(Crypto.DISPATCH_SEED);
            updatedRegionList.ClientCustomConfigEncrypted = ByteString.CopyFrom(customConfig);

            // Set the region list response.
            RegionListResponse = Convert.ToBase64String(updatedRegionList.ToByteString().ToByteArray());
        }
    }
}
