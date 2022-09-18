using Microsoft.AspNetCore.Http;


namespace Weedwacker.WebServer.Handlers
{
    // Known Queries: app_id=4&channel_id=1&client_type=3
    internal class ComboGetConfig : IHandler
    {
        public class ComboGetConfigRspJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data { get; set; } = new();
            public class Data
            {
                public bool protocol { get; set; } = true;
                public bool qr_enabled { get; set; } = false;
                public string log_level { get; set; } = "INFO";
                public string announce_url { get; set; } = "https://sdk.hoyoverse.com/hk4e/announcement/index.html?sdk_presentation_style=fullscreen\u0026announcement_version=1.21\u0026sdk_screen_transparent=true\u0026game_biz=hk4e_global\u0026auth_appid=announcement\u0026game=hk4e#/";
                public int push_alias_type { get; set; } = 2;
                public bool disable_ysdk_guard { get; set; } = false;
                public bool enable_announce_pic_popup { get; set; } = true;
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new ComboGetConfigRspJson());
            return true;
        }
    }
}
