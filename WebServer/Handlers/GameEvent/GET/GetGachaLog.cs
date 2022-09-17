using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    // Known Queries: win_mode=fullscreen&authkey_ver=1&sign_type=2&auth_appid=webview_gacha&init_type=301&gacha_id=b4ac24d133739b7b1d55173f30ccf980e0b73fc1&timestamp=REDACTED&lang=en&device_type=pc&game_version=REDACTED&plat_type=pc&region=os_euro&authkey=TOOGODDAMNLONG&game_biz=hk4e_global&gacha_type=301&page=1&size=5&end_id=0
    internal class GetGachaLog : IHandler
    {
        public class GetGachaLogRspJson
        {
            public int retcode { get; set; } = 0;
            public string message { get; set; } = "OK";
            public Data data = new();
            public class Data
            {
                public int page { get; set; } = 1;
                public string size { get; set; } = "5";
                public string total { get; set; } = "0";
                public List<string?> list { get; set; }
                public string region { get; set; } = "os_usa";
            }
        }
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new GetGachaLogRspJson());
            return true;
        }
    }
}