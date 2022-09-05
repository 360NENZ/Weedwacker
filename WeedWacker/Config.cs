namespace Weedwacker
{
    public static class Config
    {
        private class section
        { 
            public readonly Dictionary<string, string> _fields = new();
            public readonly Dictionary<string, int> _integerCache = new();
            public readonly Dictionary<string, bool> _booleanCache = new();
            public readonly Dictionary<string, float> _floatCache = new();
            public readonly Dictionary<string, string[]> _arrayCache = new();

            public void Clear()
            {
                _fields.Clear();
                _integerCache.Clear();
                _booleanCache.Clear();
                _floatCache.Clear();
                _arrayCache.Clear();
            }
        }

        static readonly Dictionary<string, section> sections = new();
        
        static void ClearCache()
        {
            foreach (KeyValuePair<string, section> entry in sections)
            {
                entry.Value.Clear();
            }
            sections.Clear();
        }

        public static async Task Load()
        {   

            ClearCache();
            string[] kvp;
            string currSection = "";
            if (!File.Exists("config.ini"))
            {
                Logger.WriteErrorLine("Config file not found!");
                return;
            }
            foreach (string line in await File.ReadAllLinesAsync("config.ini"))
            {
                string trimmedLine = line.TrimStart();
                if (trimmedLine.StartsWith('[')) //Start of new Section
                {
                    kvp = line.Split(']');
                    currSection = kvp[0].Substring(1);
                    continue;
                }
                else if (trimmedLine.StartsWith('#') || line.TrimStart().StartsWith(';')) //Comment
                {
                    continue;
                }
                else if (!trimmedLine.Contains('='))
                {
                    //TODO report syntax errors
                    continue;
                }
                else
                {
                    kvp = trimmedLine.Split('=');
                    if (string.IsNullOrEmpty(kvp[0]) || string.IsNullOrEmpty(kvp[1]) || sections[currSection]._fields.ContainsKey(kvp[0]))
                        continue;
                    sections[currSection]._fields.Add(kvp[0], kvp[1].TrimEnd());
                }
            }
        }
        public static string GetString(string key, string section = "", string defaultValue = "")
        {
            if (sections[section]._fields.TryGetValue(key, out var res))
                return res;
            return defaultValue;
        }
        public static int GetInt(string key, string section = "", int defaultValue = 0)
        {
            if (sections[section]._integerCache.TryGetValue(key, out var res))
                return res;
            int value = defaultValue;
            if (sections[section]._fields.TryGetValue(key, out var field))
                value = Convert.ToInt32(field, field.StartsWith("0x") ? 16 : 10);
            sections[section]._integerCache.Add(key, value);
            return value;
        }
        public static float GetFloat(string key, string section = "", float defaultValue = 0f)
        {
            if (sections[section]._floatCache.TryGetValue(key, out var res))
                return res;
            float value = defaultValue;
            if (sections[section]._fields.TryGetValue(key, out var field))
                value = Convert.ToSingle(field);
            sections[section]._floatCache.Add(key, value);
            return value;
        }
        public static string[] GetArray(string key, string section = "", params string[] def)
        {
            if (sections[section]._arrayCache.TryGetValue(key, out var res))
                return res;
            string value = GetString(key);
            if (string.IsNullOrEmpty(value))
                return def;
            res = value.Split(',');
            sections[section]._arrayCache.Add(key, res);
            return res;
        }
        public static bool GetBool( string key, string section = "", bool defaultValue = false)
        {
            if (sections[section]._booleanCache.TryGetValue(key, out var res))
                return res;
            bool value = defaultValue;
            if (sections[section]._fields.TryGetValue(key, out var field))
                value = Convert.ToBoolean(field);
            sections[section]._booleanCache.Add(key, value);
            return value;
        }

        public static String lr(String left, String right)
        {
            return left.Length == 0 ? right : left;
        }

        public static int lr(int left, int right)
        {
            return left == 0 ? right : left;
        }
    }
}
