using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PdfConcat
{
    public static class SettingsProvider
    {
        private static Dictionary<string, string> Settings;

        private const string UNRESOLVED_PATH = @"%appdata%\Jonas Kohl\PdfConcat\";
        private const string FILENAME = "settings.ini";
        private static string Path;

        public static void LoadSettings()
        {
            Settings = new Dictionary<string, string>();

            if (File.Exists(FILENAME))
                Path = "";
            else
            {
                Path = Environment.ExpandEnvironmentVariables(UNRESOLVED_PATH);

                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);
            }
            
            if (File.Exists(Path + FILENAME))
            {
                string[] lines = File.ReadAllLines(Path + FILENAME);

                foreach (string line in lines)
                {
                    if (line.Trim().Length < 1 || line.StartsWith("#"))
                        break;

                    string[] fragments = line.Split(new char[] { '=' }, 2);

                    Settings.Add(fragments[0], fragments[1]);
                }
            }
        }

        public static void SaveSettings()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Settings)
                sb.AppendLine(string.Format("{0}={1}", item.Key, item.Value));

            File.WriteAllText(Path + FILENAME, sb.ToString());
        }

        public static void Set(string key, object value)
        {
            if (!Settings.ContainsKey(key))
                Settings.Add(key, value.ToString());
            else
                Settings[key] = value.ToString();
        }

        public static string Get(string key)
        {
            if (!Settings.ContainsKey(key))
                return null;
            return Settings[key];
        }

        public static T GetAs<T>(string key)
        {
            string val = Get(key);
            if (val == null)
                return default(T);

            return (T)Convert.ChangeType(val, typeof(T));
        }

        public static T GetAsOrDefault<T>(string key, T defaultValue)
        {
            string val = Get(key);
            if (val == null)
                return defaultValue;

            return (T)Convert.ChangeType(val, typeof(T));
        }

        public static bool HasKey(string key)
        {
            return Settings.ContainsKey(key);
        }
    }
}
