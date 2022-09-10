using System.Net;
using Ceen.Httpd;
using Ceen.Httpd.Logging;
using Weedwacker.WebServer.Handlers;
using Weedwacker.WebServer.Authentication;
using Weedwacker.Shared.Utils;
using Weedwacker.Shared.Utils.Configuration;
using Weedwacker.WebServer.Commands;

namespace Weedwacker.WebServer
{
    internal class WebServer
    {
        //public static IAuthenticationSystem AuthenticationSystem { get; set; } = new DefaultAuthentication();
        
        static readonly CancellationTokenSource CancelToken = new();
        static Task? ServerTask;
        static readonly ServerConfig Configuration = new ServerConfig().AddLogger(new CLFStdOut()).
            AddRoute("/hk4e_global/mdk/shield/api/login", new ClientLogin()).
            AddRoute("/query_region_list", new QueryRegionList()).
            AddRoute("/query_cur_region/{region}", new QueryCurrentRegion()).
            AddRoute("/hk4e_global/mdk/shield/api/verify", new TokenLogin()).
            AddRoute("/hk4e_global/combo/granter/login/v2/login", new SessionKeyLogin()).
            AddRoute("/account/risky/api/check", new RiskyAPICheck()).
            AddRoute("/combo/box/api/config/sdk/combo", new ConfigSDKCombo()).
            AddRoute("/hk4e_global/combo/granter/api/getConfig", new ComboGetConfig()).
            AddRoute("/hk4e_global/mdk/shield/api/loadConfig", new ComboLoadConfig()).
            AddRoute("/data_abtest_api/config/experiment/list", new ConfigExperimentList()).
            AddRoute("/hk4e_global/mdk/agreement/api/getAgreementInfos", new GetAgreementInfo()).
            AddRoute("/hk4e_global/combo/granter/api/compareProtocolVersion", new CompareProtocolVersion());

        public static async void Start()
        {
            await Config.Load();
            Configuration.LoadCertificate(Config.WebConfig.server.http.encryption.keystore, Config.WebConfig.server.http.encryption.keystorePassword);
            Crypto.LoadKeys();
            RegionManager.Initialize();
            ServerTask = HttpServer.ListenAsync(
                new IPEndPoint(IPAddress.Any, 443),
                false,
                Configuration,
                CancelToken.Token);
            await ServerTask;
        }
    }
}
