using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Weedwacker.WebServer.Handlers
{
    // Known Queries: biz_key=hk4e_global&client_type=3 
    internal class ConfigSDKCombo : IHandler
    {
        public class ConfigSDKComboResJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data { get; set; } = new();
            public class Data
            {
                public Vals vals { get; set; } = new();
                public class Vals
                {
                    public bool disable_email_bind_skip { get; set; } = false;
                    public string email_bind_remind_interval { get; set; } = "7";
                    public bool email_bind_remind { get; set; } = true;
                    public string network_report_config { get; set; }
                    public string kibana_pc_config { get; set; }
                    public class NetRepConfig
                    {
                        public int enable { get; set; } = 1;
                        public int[] status_codes { get; set; } = { 206 };
                        public string[] url_paths { get; set; } = { "dataUpload" };  
                    }
                    public class KibanaPcConfig
                    {
                        public int enable { get; set; } = 1;
                        public string level { get; set; } = "Info";
                        public string[] modules { get; set; } = { "download" };
                        public string kcp_enable { get; set; } = "false";
                        public string email_bind_remind { get; set; } = "true";
                        public string disable_email_bind_skip { get; set; } = "false";
                    }
                    public Vals()
                    {
                        NetRepConfig net = new();
                        KibanaPcConfig kibana = new();
                        network_report_config = JsonConvert.SerializeObject(net);
                        kibana_pc_config = JsonConvert.SerializeObject(kibana);
                    }
                }
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            //For some reason official behaviour sends a malformed json string
            //await context.Response.WriteAsJsonAsync("{\"retcode\":0,\"message\":\"OK\",\"data\":{\"vals\":{\"disable_email_bind_skip\":\"false\",\"email_bind_remind_interval\":\"7\",\"email_bind_remind\":\"true\"}}}");
            await context.Response.WriteAsJsonAsync(new ConfigSDKComboResJson());
            return true;
        }
    }
}
