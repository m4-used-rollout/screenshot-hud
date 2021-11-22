using Newtonsoft.Json;
using ScreenshotHud.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ScreenshotHud
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadConfig();
            Application.SetHighDpiMode(HighDpiMode.DpiUnaware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Control());
        }

        private static string ConfigFile = Application.StartupPath + "\\config.json";

        public static Config Config { get; set; } = new Config();

        private static List<Action> ConfigSubscribers { get; } = new List<Action>();
        public static void RegisterForConfigUpdate(Action callback)
        {
            if (!ConfigSubscribers.Contains(callback))
                ConfigSubscribers.Add(callback);
        }
        public static void UnregisterForConfigUpdate(Action callback)
        {
            ConfigSubscribers.Remove(callback);
        }
        public static void NotifyConfigUpdate()
        {
            ConfigSubscribers.ForEach(f => f());
        }

        public static void SaveConfig(string filename = null)
        {
            File.WriteAllText(filename ?? ConfigFile, JsonConvert.SerializeObject(Config, Formatting.Indented));
        }
        public static void LoadConfig(string filename = null)
        {
            if (File.Exists(filename ?? ConfigFile))
            {
                Config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(filename ?? ConfigFile));
                NotifyConfigUpdate();
            }
        }
    }
}
