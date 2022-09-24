using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Authentication;
using Weedwacker.Shared.Utils.Configuration;

namespace Weedwacker.GameServer
{
    internal class GameServer
    {
        private static readonly HttpClient client = new HttpClient();
        public static GameConfig Configuration;
        public static SortedList<int,Connection> OnlinePlayers = new(); // <gameUid,connection>
        public static SortedList<int, AvatarCompiledData> AvatarInfo; // <avatarId,data>
        public static async Task<bool> VerifyToken(string accountUid, string token)
        {
            var req = JsonConvert.SerializeObject(new VerifyTokenRequestJson() { uid = accountUid, token = token });
            var contentData = new StringContent(req, Encoding.UTF8, "application/json");
            var rsp = await client.PostAsync(Configuration.Server.WebServerUrl + "/hk4e_global/mdk/shield/api/verify", contentData);
            var result = JsonConvert.DeserializeObject<LoginResultJson>(await rsp.Content.ReadAsStringAsync());
            if(result.message == "OK")
            {
                return true;
            }
            return false;
        }

        public static AvatarCompiledData GetAvatarInfo(int avatarId)
        {
            if(!AvatarInfo.ContainsKey(avatarId))
            {
                AvatarInfo.Add(avatarId, new AvatarCompiledData(avatarId));
            }
            return AvatarInfo[avatarId];
        }

        public static async Task Start()
        {
            Configuration = await Config.Load<GameConfig>("GameConfig.json");
            await GameData.LoadAllResourcesAsync(Configuration.Structure.Resources);
            Shared.Utils.Crypto.LoadKeys(Configuration.structure.keys);
            await Database.DatabaseManager.Initialize();
            Listener.StartListener();
        }
    }
}
