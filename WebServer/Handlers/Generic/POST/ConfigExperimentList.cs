using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class ConfigExperimentList : IHandler
    {
        public class ConfigExperimentListResJson
        {
            public int retcode { get; set; } = 0;
            public bool success { get; set; } = true;
            public string message { get; set; } = "";
            public Data[] data { get; set; } = { new Data()};
            public class Data
            {
                public int code { get; set; } = 1000;
                public int type { get; set; } = 2;
                public string config_id { get; set; } = "14";
                public string period_id { get; set; } = "6036_99";
                public string version { get; set; } = "1";
                public Configs configs { get; set; } = new();
                public class Configs
                {
                    public string cardType { get; set; } = "old";
                }

            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new ConfigExperimentListResJson());
            return true;
        }
    }
}
