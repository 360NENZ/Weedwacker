using Newtonsoft.Json;

namespace Weedwacker
{
    public static class Config
    {

        public static async Task<ConfigContainer> Load()
        {
            ConfigContainer configContainer = new ConfigContainer();
            if (!File.Exists("config.json"))
            {
                Logger.WriteLine("Config.json not found. Generating default config.json");
                string jsonString = JsonConvert.SerializeObject(new ConfigContainer(), Formatting.Indented);
                await File.WriteAllTextAsync("config.json", jsonString);
            }
            else
            {
                configContainer = JsonConvert.DeserializeObject<ConfigContainer>(File.ReadAllText("config.json"));
            }

            return configContainer;
        }
        public class ConfigContainer
        {
            public Database database = new();
            public Structure structure = new();
            public Server server = new();
            public Language language = new();
            public Account account = new();
            public int version = 1;

            public class Database
            {
                public DataStore server = new DataStore();
                public DataStore game = new DataStore();

                public class DataStore
                {
                    public string connectionUri = "mongodb://localhost:27017";
                    public string collection = "weedwacker";
                }
            }
            public class Structure
            {
                public string resources = "./resources/";
                public string data = "./data/";
                public string packets = "./packets/";
                public string scripts = "./resources/Scripts/";
                public string plugins = "./plugins/";
                public string keys = "./keys/";

                // UNUSED (potentially added later?)
                // public String dumps = "./dumps/";
            }
            public class Server
            {

                public Enums.ServerRunMode runMode = Enums.ServerRunMode.HYBRID;
                public bool logCommands = false;

                public HTTP http = new HTTP();
                public Game game = new Game();

                public Dispatch dispatch = new Dispatch();
            }

            public class Language
            {
                public System.Globalization.CultureInfo language = System.Globalization.CultureInfo.CurrentCulture;
                public System.Globalization.CultureInfo fallback = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                public string document = "EN";
            }

            public class Account
            {
                public bool autoCreate = false;
                public bool EXPERIMENTAL_RealPassword = false;
                public string[] defaultPermissions = Array.Empty<string>();
                public int maxPlayer = -1;
            }

            /* Server options. */

            public class HTTP
            {
                public string bindAddress = "0.0.0.0";
                public int bindPort = 443;

                /* This is the address used in URLs. */
                public string accessAddress = "127.0.0.1";
                /* This is the port used in URLs. */
                public int accessPort = 0;

                public Encryption encryption = new Encryption();
                public Policies policies = new Policies();
                public Files files = new Files();
            }

            public class Game
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
                public Enums.ServerDebugMode logPackets = Enums.ServerDebugMode.NONE;

                public GameOptions gameOptions = new GameOptions();
                public JoinOptions joinOptions = new JoinOptions();
                public ConsoleAccount serverAccount = new ConsoleAccount();
            }

            /* Data containers. */

            public class Dispatch
            {
                public List<Region> regions = new();

                public string defaultName = "Weedwacker";

                public Enums.ServerDebugMode logRequests = Enums.ServerDebugMode.NONE;
            }

            public class Encryption
            {
                public bool useEncryption = true;
                /* Should 'https' be appended to URLs? */
                public bool useInRouting = true;
                public string keystore = "./keystore.p12";
                public string keystorePassword = "123456";
            }

            public class Policies
            {
                public Policies.CORS cors = new Policies.CORS();

                public class CORS
                {
                    public bool enabled = false;
                    public string[] allowedOrigins = new String[] { "*" };
                }
            }

            public class GameOptions
            {
                public InventoryLimits inventoryLimits = new InventoryLimits();
                public AvatarLimits avatarLimits = new AvatarLimits();
                public int sceneEntityLimit = 1000; // Unenforced. TODO: Implement.

                public bool watchGachaConfig = false;
                public bool enableShopItems = true;
                public bool staminaUsage = true;
                public bool energyUsage = true;
                public bool fishhookTeleport = true;
                public ResinOptions resinOptions = new ResinOptions();
                public Rates rates = new Rates();

                public class InventoryLimits
                {
                    public int weapons = 2000;
                    public int relics = 2000;
                    public int materials = 2000;
                    public int furniture = 2000;
                    public int all = 30000;
                }

                public class AvatarLimits
                {
                    public int singlePlayerTeam = 4;
                    public int multiplayerTeam = 4;
                }

                public class Rates
                {
                    public float adventureExp = 1.0f;
                    public float mora = 1.0f;
                    public float leyLines = 1.0f;
                }

                public class ResinOptions
                {
                    public bool resinUsage = false;
                    public int cap = 160;
                    public int rechargeTime = 480;
                }
            }

            public class JoinOptions
            {
                public int[] welcomeEmotes = { 2007, 1002, 4010 };
                public string welcomeMessage = "Welcome to a Weedwacker server.";
                public Mail welcomeMail = new Mail();

                public class Mail
                {/*
                        public string title = "Welcome to Weedwacker!";
                        public string content = """
                        Hi there!\r
                        First of all, welcome to Weedwacker. If you have any issues, please let us know so that Primrose can help you! \r
                        \r
                        Check out our:\r
                        <type="browser" text="Discord" href="https://discord.gg/T5vZU6UyeG"/>
                        """;
                        public string sender = "Primrose";
                        
                        public emu.grasscutter.game.mail.Mail.MailItem[] items = {
                        new emu.grasscutter.game.mail.Mail.MailItem(13509, 1, 1),
                        new emu.grasscutter.game.mail.Mail.MailItem(201, 99999, 1)
                        };
                        */
                }
            }

            public class ConsoleAccount
            {
                public int avatarId = 10000007;
                public int nameCardId = 210001;
                public int adventureRank = 1;
                public int worldLevel = 0;

                public string nickName = "Server";
                public string signature = "Welcome to Weedwacker!";
            }

            public class Files
            {
                public string indexFile = "./index.html";
                public string errorFile = "./404.html";
            }

            /* Objects. */

            public class Region
            {
                public Region() { }

                public Region(
                    string name, string title,
                    string address, int port
                )
                {
                    this.Name = name;
                    this.Title = title;
                    this.Ip = address;
                    this.Port = port;
                }

                public string Name = "os_usa";
                public string Title = "Weedwacker";
                public string Ip = "127.0.0.1";
                public uint Port = 22102;
            }
        }

        public static string lr(string left, string right)
        {
            return left.Length == 0 ? right : left;
        }

        public static int lr(int left, int right)
        {
            return left == 0 ? right : left;
        }
    }
}
