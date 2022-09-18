using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    // Known Queries: win_mode=fullscreen&authkey_ver=1&sign_type=2&auth_appid=webview_gacha&gacha_id=b4ac24d133739b7b1d55173f30ccf980e0b73fc1&timestamp=REDACTED&lang=en&device_type=pc&game_version=REDACTED&plat_type=pc&region=os_euro&authkey=TOOGODDAMNLONG&game_biz=hk4e_global HTTP/1.1
    internal class GameEvent : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            context.Response.StatusCode = 404;
            await context.Response.WriteAsync("404 page not found");
            return true;
        }
    }
}
