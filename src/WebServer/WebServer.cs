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
using System.Net;

namespace Weedwacker.WebServer
{
    internal class WebServer
    {
        public static IAuthenticationSystem AuthenticationSystem { get; set; } = new DefaultAuthentication();
        public static WebConfig Configuration;

        static Task? ServerTask;
        static readonly Dictionary<string, IHandler> AllRoutingTypes = new()
        {
            {"/hk4e_global/combo/granter/api/compareProtocolVersion", new CompareProtocolVersion()},
            {"/log/sdk/upload", new LogSdkUpload()},
            {"/sdk/upload", new SdkUpload()},
            {"/perf/config/verify", new PerfConfigVerify()},
            {"/common/hk4e_global/announcement/api/getAlertPic", new GetAlertPic()},
            {"/common/hk4e_global/announcement/api/getAlertAnn", new GetAlertAnn()},
            {"/common/hk4e_global/announcement/api/getAnnList", new GetAnnList()},
            {"/common/hk4e_global/announcement/api/getAnnContent", new GetAnnContent()},
            {"/hk4e_global/mdk/shopwindow/shopwindow/listPriceTier", new ListPriceTier()}
        };
        static readonly Dictionary<string, IHandler> GetRoutings = new()
        {
            {"/hk4e_global/combo/granter/api/getConfig", new ComboGetConfig()},
            {"/combo/box/api/config/sdk/combo", new ConfigSDKCombo()},
            {"/combo/box/api/config/sw/precache", new PreCache()},
            {"/hk4e_global/mdk/agreement/api/getAgreementInfos", new GetAgreementInfo()},
            {"/hk4e_global/mdk/shield/api/loadConfig", new LoadConfig()},
            {"/query_cur_region/{**region}", new QueryCurrentRegion()},
            {"/query_region_list", new QueryRegionList()},
            {"/admin/mi18n/plat_oversea/*", new WebStaticVersion()},
            {"/admin/mi18n/hk4e_cn/", new WebStaticGacha()},
            {"/authentication/type", new AuthenticationType()},
            {"/authentication/openid/redirect", new OpenIdRedirect()},
            {"/Api/twitter_login", new ApiTwitterLogin()},
            {"/sdkTwitterLogin.html", new SdkTwitterLogin()},
            {"/hk4e/announcement/", new GetPageResources()},
            {"/upload/op-public/", new OpPublic()},
            {"/gacha", new GachaRecords()},//???
            {"/genshin/event/", new GameEvent()},
            {"/hk4e/gacha_info/", new GachaInfo()},
            {"/event/gacha_info/api/getGachaLog", new GetGachaLog()}
            //{"/gacha/details", new GachaDetails()}//???
           
    };

        static readonly Dictionary<string, IHandler> PostRoutings = new()
        {
            {"/hk4e_global/mdk/shield/api/login", new ClientLogin()},
            {"/data_abtest_api/config/experiment/list", new ConfigExperimentList()},
            {"/account/risky/api/check", new RiskyAPICheck()},
            {"/sdk/dataUpload", new SdkDataUpload()},
            {"/hk4e_global/combo/granter/login/v2/login", new SessionKeyLogin()},
            {"/hk4e_global/combo/granter/login/beforeVerify", new BeforeVerify()},
            {"/hk4e_global/combo/red_dot/list", new RedDotList()},
            {"/hk4e_global/mdk/shield/api/verify", new TokenVerify()},
            {"/authentication/register", new AuthenticationRegister()},
            {"/authentication/login", new AuthenticationLogin()},
            {"/authentication/change_password", new AuthenticationChangePassword()},
            {"/hk4e_global/mdk/shield/api/loginByThirdparty", new LoginByThirdParty()},
            {"/log", new Log()},
            {"/crash/dataUpload", new CrashDataUpload()},
            {"/common/h5log/log/batch", new LogBatch()},
            {"/khulk/dispatch/getGateAddress", new KhulkGetGateAddress()},
            {"/dispatch/dispatch/getGateAddress", new DispatchGetGateAddress()}

        };
        public static async void Start()
        {
            Configuration = await Config.Load<WebConfig>("WebConfig.json");
            Crypto.LoadKeys(Configuration.structure.keys);
            RegionManager.Initialize();
            DatabaseManager.Initialize();
            var builder = WebApplication.CreateBuilder();

            builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.AddJsonFile("./WebConfig.json",
                                   optional: false,
                                   reloadOnChange: true);
            });

            builder.Services.AddRazorPages();


            builder.Services.AddHttpsRedirection(options =>
            {
                options.RedirectStatusCode = (int)HttpStatusCode.PermanentRedirect;
                options.HttpsPort = int.Parse(Configuration.Kestrel.Endpoints.Https.Url.Split(":")[2]);
            });
            var app = builder.Build();
            if (Configuration.Server.EnforceEncryption)
            {
                app.UseHttpsRedirection();
            }
            foreach (var routing in AllRoutingTypes)
            {
                app.Map(routing.Key, async (HttpContext context) => await routing.Value.HandleAsync(context));
            }
            foreach (var routing in GetRoutings)
            {
                app.MapGet(routing.Key, async (HttpContext context) => await routing.Value.HandleAsync(context));
            }
            foreach (var routing in PostRoutings)
            {
                app.MapPost(routing.Key, async (HttpContext context) => await routing.Value.HandleAsync(context));
            }
            ServerTask = app.RunAsync();
            await ServerTask;

        }
    }
}
