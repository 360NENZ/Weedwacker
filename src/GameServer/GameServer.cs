using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Weedwacker.Shared.Authentication;

namespace Weedwacker.GameServer
{
    internal class GameServer
    {
        private static readonly HttpClient client = new HttpClient();
        public static GameConfig Configuration;


        public static async Task<bool> VerifyToken(string accountUid, string token)
        {
            var req = JsonConvert.SerializeObject(new VerifyTokenRequestJson() { uid = accountUid, token = token });
            var contentData = new StringContent(req, Encoding.UTF8, "application/json");
            var rsp = await client.PostAsync(Configuration.server.WebServerUrl, contentData);
            var result = JsonConvert.DeserializeObject<LoginResultJson>(await rsp.Content.ReadAsStringAsync());
            if(result.message == "OK")
            {
                return true;
            }
            return false;
        }
    }
}
