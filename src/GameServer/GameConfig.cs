using Weedwacker.Shared.Utils.Configuration;

namespace Weedwacker.GameServer
{
    internal class GameConfig : ConfigFile
    {
        public Server server = new();
        public class Database
        {
            public DataStore game = new DataStore();
            public class DataStore
            {
                public string connectionUri = "mongodb://localhost:27017";
                public string database = "weedwacker";
            }
        }
        public class Structure
        {
            public string resources = "../../../resources/";
            public string scripts = "../../../resources/Scripts/";


            // UNUSED (potentially added later?)
            // public String dumps = "./dumps/";
        }
        public class Server
        {
            public HashSet<string> debugWhitelist = new HashSet<string>();
            public HashSet<string> debugBlacklist = new HashSet<string>();
            public string bindAddress = "0.0.0.0";
            public int bindPort = 22102;

            /* This is the address used in the default region. */
            public string accessAddress = "127.0.0.1";
            /* This is the port used in the default region. */
            public int accessPort = 0;

            /* Entities within a certain range will be loaded for the player */
            public int loadEntitiesForPlayerRange = 100;
            public bool enableScriptInBigWorld = false;
            public bool enableConsole = true;

            /* Kcp internal work interval (milliseconds) */
            public int kcpInterval = 20;
            /* Controls whether packets should be logged in console or not */
            public Shared.Enums.ServerDebugMode logPackets = Shared.Enums.ServerDebugMode.NONE;

            public GameOptions gameOptions = new GameOptions();
            public JoinOptions joinOptions = new JoinOptions();
            public ConsoleAccount serverAccount = new ConsoleAccount();
        }




        /* Data containers. */


        public class GameOptions
        {
            public InventoryLimitsJson InventoryLimits = new();
            public AvatarLimitsJson AvatarLimits = new();
            public int SceneEntityLimit = 1000; // Unenforced. TODO: Implement.

            public bool WatchGachaConfig = false;
            public bool EnableShopItems = true;
            public bool StaminaUsage = true;
            public bool EnergyUsage = true;
            public bool FishhookTeleport = true;
            public ResinOptionsJson ResinOptions = new();
            public RatesJson Rates = new();

            public class InventoryLimitsJson
            {
                public int Weapons = 2000;
                public int Relics = 2000;
                public int Materials = 2000;
                public int Furniture = 2000;
                public int All = 30000;
            }
            
            public class AvatarLimitsJson
            {
                public int SinglePlayerTeam = 4;
                public int MultiplayerTeam = 4;
            }

            public class RatesJson
            {
                public float AdventureExp = 1.0f;
                public float Mora = 1.0f;
                public float LeyLines = 1.0f;
            }

            public class ResinOptionsJson
            {
                public bool ResinUsage = false;
                public int Cap = 160;
                public int RechargeTime = 480;
            }
        }

        public class JoinOptions
        {
            public int[] WelcomeEmotes = { 2007, 1002, 4010 };
            public string WelcomeMessage = "Welcome to a Weedwacker server.";
            public Mail WelcomeMail = new Mail();

            public class Mail
            {
                public string Title = "Welcome to Weedwacker!";
                public string Content = "Hi there!\r\nFirst of all, welcome to Weedwacker. If you have any issues, please let us know so that Primrose can help you!";
                public string Sender = "Primrose";
                /*
                public Weedwacker.game.mail.Mail.MailItem[] items = {
                new Weedwacker.game.mail.Mail.MailItem(13509, 1, 1),
                new Weedwacker.game.mail.Mail.MailItem(201, 99999, 1)
                };
                */
            }
        }

        public class ConsoleAccount
        {
            public int AvatarId = 10000007;
            public int NameCardId = 210001;
            public int AdventureRank = 1;
            public int WorldLevel = 0;

            public string NickName = "Server";
            public string Signature = "Welcome to Weedwacker!";
        }


        /* Objects. */

        public class Region
        {
            public Region() { }

            public Region(
                string name, string title,
                string address, uint port
            )
            {
                Name = name;
                Title = title;
                Ip = address;
                Port = port;
            }

            public string Name = "os_usa";
            public string Title = "Weedwacker";
            public string Ip = "127.0.0.1";
            public uint Port = 22102;
        }
    }
}