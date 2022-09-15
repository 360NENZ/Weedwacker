using Microsoft.AspNetCore.Http;


namespace Weedwacker.WebServer.Handlers
{
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
                    public int email_bind_remind_interval { get; set; } = 7;
                    public bool email_bind_remind { get; set; } = true;
                }
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new ConfigSDKComboResJson());
            return true;
        }
    }
}
