using Weedwacker.WebServer.Handlers;
using Weedwacker.WebServer.Authentication;
using Weedwacker.Shared.Utils;
using Weedwacker.Shared.Utils.Configuration;
using Weedwacker.WebServer.Commands;
using Weedwacker.WebServer.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer
{
    internal class WebServer
    {
        public static IAuthenticationSystem AuthenticationSystem { get; set; } = new DefaultAuthentication();
        public static WebConfig Configuration;
        
        static Task? ServerTask;
        static readonly Dictionary<string, IHandler> routings = new()
        {
            {"/query_region_list", new QueryRegionList()},
            {"/query_cur_region", new QueryCurrentRegion()},
            {"/hk4e_global/mdk/shield/api/login", new ClientLogin()},
            {"/hk4e_global/mdk/shield/api/verify", new TokenLogin()},
            {"/hk4e_global/combo/granter/login/v2/login", new SessionKeyLogin()},
            {"/account/risky/api/check", new RiskyAPICheck()},
            {"/combo/box/api/config/sdk/combo", new ConfigSDKCombo()},
            {"/hk4e_global/combo/granter/api/getConfig", new ComboGetConfig()},
            {"/hk4e_global/mdk/shield/api/loadConfig", new ComboLoadConfig()},
            {"/data_abtest_api/config/experiment/list", new ConfigExperimentList()},
            {"/hk4e_global/mdk/agreement/api/getAgreementInfos", new GetAgreementInfo()},
            {"/hk4e_global/combo/granter/api/compareProtocolVersion", new CompareProtocolVersion()},
        };
        public static async void Start()
        {
            Configuration = await Config.Load<WebConfig>();
            Crypto.LoadKeys(Configuration.structure.keys);
            RegionManager.Initialize();
            DatabaseManager.Initialize();
            var builder = WebApplication.CreateBuilder();

            builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.AddJsonFile("./config.json",
                                   optional: false,
                                   reloadOnChange: true);
            });

            builder.Services.AddRazorPages();
            var app = builder.Build();
            foreach(var routing in routings)
            {
                app.Map(routing.Key, (HttpContext context) => routing.Value.HandleAsync(context));
            }
            ServerTask = app.RunAsync();
            await ServerTask;
            
        }
    }
}
