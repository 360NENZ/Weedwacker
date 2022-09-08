using Newtonsoft.Json;

namespace Weedwacker.Shared.Utils.Configuration
{
    public static class Config
    {
        public static ConfigFile WebConfig { get; private set; } = new();
        public static async Task<ConfigFile> Load()
        {
            WebConfig = new ConfigFile();
            if (!File.Exists("config.json"))
            {
                Logger.WriteLine("Config.json not found. Generating default config.json");
                string jsonString = JsonConvert.SerializeObject(new ConfigFile(), Formatting.Indented);
                await File.WriteAllTextAsync("config.json", jsonString);
            }
            else
            {
                WebConfig = JsonConvert.DeserializeObject<ConfigFile>(File.ReadAllText("config.json"));
            }

            return WebConfig;
        }

        public static string Lr(string left, string right)
        {
            return left.Length == 0 ? right : left;
        }

        public static int Lr(int left, int right)
        {
            return left == 0 ? right : left;
        }
    }
}
