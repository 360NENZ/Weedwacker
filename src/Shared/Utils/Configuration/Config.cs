using Newtonsoft.Json;

namespace Weedwacker.Shared.Utils.Configuration
{
    public static class Config
    {

        public static async Task<T> Load<T>(string jsonName)
        {

            
            if (!File.Exists(jsonName))
            {
                T config = (T)Activator.CreateInstance(typeof(T));
                Logger.WriteLine(jsonName + " not found. Generating default " + jsonName);
                string jsonString = JsonConvert.SerializeObject(config, Formatting.Indented);
                await File.WriteAllTextAsync(jsonName, jsonString);
                return config;
            }
            else
            {
                T config = JsonConvert.DeserializeObject<T>(File.ReadAllText(jsonName));
                return config;
            }

            
        }
    }
}
