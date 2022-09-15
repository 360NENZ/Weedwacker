using Newtonsoft.Json;

namespace Weedwacker.Shared.Utils.Configuration
{
    public static class Config
    {

        public static async Task<T> Load<T>()
        {

            
            if (!File.Exists("config.json"))
            {
                T config = (T)Activator.CreateInstance(typeof(T));
                Logger.WriteLine("config.json not found. Generating default config.json");
                string jsonString = JsonConvert.SerializeObject(config, Formatting.Indented);
                await File.WriteAllTextAsync("config.json", jsonString);
                return config;
            }
            else
            {
                T config = JsonConvert.DeserializeObject<T>(File.ReadAllText("config.json"));
                return config;
            }

            
        }
    }
}
