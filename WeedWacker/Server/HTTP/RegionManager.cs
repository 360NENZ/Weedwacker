using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.Server.Proto;
using System.Net;

namespace Weedwacker.Server.HTTP
{
    internal class RegionHandler
    {
        private struct Region
        {
            public Region(string name, string title, string address, int port)
            {
                this.name = name;
                this.title = title;
                this.address = address;
                this.port = port;
            }
            string name = "os_usa", title = "Weedwacker", address = "127.0.0.1";
            int port = 22102;
        }
        public struct RegionData
        {
            private QueryCurrRegionHttpRsp regionQuery;
            private string base64;
        }

        private void Initialize()
        {
            List<RegionSimpleInfo> servers = new();
            byte[] customConfig = Encoding.Default.GetBytes("{\"sdkenv\":\"2\",\"checkdevice\":\"false\",\"loadPatch\":\"false\",\"showexception\":\"false\",\"regionConfig\":\"pm|fk|add\",\"downloadMode\":\"0\"}");
            string dispatchDomain = "http" + (Config.GetBool("useInRouting", "http") ? "s" : "") + "://"
                + Config.lr(Config.GetString("accessAddress", "http"), Config.GetString("bindAddress", "http") + ":"
                + Config.lr(Config.GetInt("accessPort", "http"), Config.GetInt("bindPort", "http")));
            List<Region> configuredRegions = new();// Config.GetArray("regions","dispatch");
            if(Config.GetString("runMode") != "HYBRID" && configuredRegions.Count() == 0) //DISPATCH or GAME
            {
                Logger.WriteErrorLine("No configured server regions. Shutting down...");
                Environment.Exit(1);
            } 
            else if(configuredRegions.Count() == 0) //HYBRID
            {
                Logger.DebugWriteLine("[Dispatch] Loading default region");
                configuredRegions.Add(new Region());
            }
            QueryRegionListHttpRsp updatedRegionList = new QueryRegionListHttpRsp {
                EnableLoginPc = true,
                ClientSecretKey = Google.Protobuf.ByteString.CopyFrom(File.ReadAllBytes(Config.GetString("dispatchKey","keyPaths")))/*
        .setClientSecretKey(ByteString.copyFrom(Crypto.DISPATCH_SEED))
        .setClientCustomConfigEncrypted(ByteString.copyFrom(customConfig))
        */
            };
            updatedRegionList.RegionList.Add(servers);

        }
        public static async Task QueryRegionList(HttpListenerContext ctx)
        {

        }

        public static async Task QueryCurrentRegion(HttpListenerContext ctx)
        {

        }
    }
}
