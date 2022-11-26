using Newtonsoft.Json;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Commands
{
    public static partial class ConsoleCommands
    {
        public static async Task<string> OnExportHashes(params string[] args)
        {
            Dictionary<uint, string> hashMap = new();
            foreach (var container in GameData.ConfigAbilityAvatarMap.Values)
            {
                foreach (var ability in container)
                {
                    var config = ability.Default as ConfigAbility;
                    hashMap[(uint)Utils.AbilityHash(config.abilityName)] = config.abilityName;
                    if (config.abilitySpecials != null)
                    {
                        foreach (string special in config.abilitySpecials.Keys)
                        {
                            hashMap[(uint)Utils.AbilityHash(special)] = special;
                        }
                    }
                    if (config.modifiers != null)
                    {
                        foreach (string modifier in config.modifiers.Keys)
                        {
                            hashMap[(uint)Utils.AbilityHash(modifier)] = modifier;
                        }
                    }
                }
            }
            string jsonString = JsonConvert.SerializeObject(hashMap, Formatting.Indented);
            await File.WriteAllTextAsync("ability_hashMap.json", jsonString);

            return $"exported ability hashes";
        }
    }
}
