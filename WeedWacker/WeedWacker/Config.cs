namespace WeedWacker
{
    public static class Config
    {
        static readonly Dictionary<string, string> _fields = new();
        static readonly Dictionary<string, int> _integerCache = new();
        static readonly Dictionary<string, bool> _booleanCache = new();
        static readonly Dictionary<string, float> _floatCache = new();
        static readonly Dictionary<string, string[]> _arrayCache = new();
        static void Clear()
        {
            _fields.Clear();
            _integerCache.Clear();
            _booleanCache.Clear();
            _floatCache.Clear();
            _arrayCache.Clear();
        }
        public static async Task Load()
        {
            Clear();
            string[] kvp;
            foreach (string line in await File.ReadAllLinesAsync("config.ini"))
            {
                if (line.StartsWith('#') || !line.Contains('='))
                    continue;
                kvp = line.Split('=');
                if (string.IsNullOrEmpty(kvp[0]) || string.IsNullOrEmpty(kvp[1]) || _fields.ContainsKey(kvp[0]))
                    continue;
                _fields.Add(kvp[0], kvp[1]);
            }
        }
        public static string GetString(string key, string defaultValue = "")
        {
            if (_fields.TryGetValue(key, out var res))
                return res;
            return defaultValue;
        }
        public static int GetInt(string key, int defaultValue = 0)
        {
            if (_integerCache.TryGetValue(key, out var res))
                return res;
            int value = defaultValue;
            if (_fields.TryGetValue(key, out var field))
                value = Convert.ToInt32(field, field.StartsWith("0x") ? 16 : 10);
            _integerCache.Add(key, value);
            return value;
        }
        public static float GetFloat(string key, float defaultValue = 0f)
        {
            if (_floatCache.TryGetValue(key, out var res))
                return res;
            float value = defaultValue;
            if (_fields.TryGetValue(key, out var field))
                value = Convert.ToSingle(field);
            _floatCache.Add(key, value);
            return value;
        }
        public static string[] GetArray(string key, params string[] def)
        {
            if (_arrayCache.TryGetValue(key, out var res))
                return res;
            string value = GetString(key);
            if (string.IsNullOrEmpty(value))
                return def;
            res = value.Split(',');
            _arrayCache.Add(key, res);
            return res;
        }
        public static bool GetBool(string key, bool defaultValue = false)
        {
            if (_booleanCache.TryGetValue(key, out var res))
                return res;
            bool value = defaultValue;
            if (_fields.TryGetValue(key, out var field))
                value = Convert.ToBoolean(field);
            _booleanCache.Add(key, value);
            return value;
        }
    }
}
