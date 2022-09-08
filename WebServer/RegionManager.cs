using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net;
using Google.Protobuf;
using Ceen;

using Weedwacker.Shared.Utils;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils.Configuration;

namespace Weedwacker.WebServer
{
    internal static class RegionManager
    {

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

        public struct QueryCurRegionRspJson
        {
            public string content;
            public string sign;
        }

        // All information about configured regions' game servers
        public static Dictionary<string, RegionData> Regions { get; private set; } = new();

        public static string RegionListResponse { get; private set; } = "";

        public static void Initialize()
        {
            var http = Config.WebConfig.server.http;


            List<RegionSimpleInfo> servers = new();
            List<string> usedNames = new(); // List to check for potential naming conflicts.

            string dispatchDomain = "http" + (http.encryption.useInRouting ? "s" : "") + "://"
                + Config.Lr(http.accessAddress, http.bindAddress + ":"
                + Config.Lr(http.accessPort, http.bindPort));
            List<ConfigFile.Region> configuredRegions = Config.WebConfig.server.dispatch.regions;

            if (configuredRegions.Count == 0) //HYBRID
            {
                Logger.DebugWriteLine("[Dispatch] Loading default region");
                configuredRegions.Add(new ConfigFile.Region());
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
                    usedNames.Add(region.Name);
                    servers.Add(identifier);

                    // Create a region info object.
                    var regionInfo = new RegionInfo();
                    regionInfo.GateserverIp = region.Ip;
                    regionInfo.GateserverPort = region.Port;
                    regionInfo.SecretKey = ByteString.CopyFrom(Crypto.DISPATCH_SEED); ;

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
