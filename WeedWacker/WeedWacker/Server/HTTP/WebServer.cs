using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeedWacker.Server.HTTP
{
    internal static class WebServer
    {
        static readonly HttpListener Listener = new();
        static readonly Dictionary<string, Func<HttpListenerContext, Task>> Handlers = new()
        {
            { "/hk4e_global/mdk/shield/api/login", WebHandler.ClientLogin },
            { "/hk4e_global/mdk/shield/api/verify", WebHandler.TokenLogin },
            { "/hk4e_global/combo/granter/login/v2/login", WebHandler.SessionKeyLogin },
            { "/query_cur_region", WebHandler.QueryCurrentRegion },
            { "/account/risky/api/check", WebHandler.RiskyAPICheck },
            { "/combo/box/api/config/sdk/combo", WebHandler.ConfigSDKCombo },
            { "/hk4e_global/combo/granter/api/getConfig", WebHandler.ComboGetConfig },
            { "/hk4e_global/mdk/shield/api/loadConfig", WebHandler.ComboLoadConfig },
            { "/data_abtest_api/config/experiment/list", WebHandler.ConfigExperimentList },
            { "/hk4e_global/mdk/agreement/api/getAgreementInfos", WebHandler.GetAgreementInfo },
            { "/hk4e_global/combo/granter/api/compareProtocolVersion", WebHandler.CompareProtocolVersion }
        };
        static readonly Dictionary<int, Func<HttpListenerResponse, Task>> DefaultResponseHandlers = new()
        {
            { 404, WebResponses.NotFound }
        };
        static async void Loop()
        {
            while (true)
                HandleRequest(await Listener.GetContextAsync());
        }
        static async Task HandleDefaultResponse(HttpListenerResponse resp, int code)
        {
            if (DefaultResponseHandlers.TryGetValue(code, out var handler))
            {
                await handler(resp);
                return;
            }
            await WebResponses.NotFound(resp);
        }
        static async void HandleRequest(HttpListenerContext ctx)
        {
            var url = ctx.Request.Url;
            if (url == null || !Handlers.TryGetValue(url.AbsolutePath, out var handler))
            {
                await HandleDefaultResponse(ctx.Response, 404);
                return;
            }
            await handler(ctx);
        }
        public static void Start()
        {
            Listener.Start();
            Loop();
        }
    }
}
