using Newtonsoft.Json;
using ScreenshotHud.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
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
            ConfigUpdates.Register(UpdateWSServer);
            ScreenUpdates.Register(NotifyWSClients);
            LoadConfig();
            Application.SetHighDpiMode(HighDpiMode.DpiUnaware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Control());
        }

        private static string ConfigFile = Application.StartupPath + "\\config.json";

        private static WebsocketBroadcastServer WebsocketServer = null;

        public static Config Config { get; set; } = new Config();

        private static readonly Func<string> SerializeScreens = () => JsonConvert.SerializeObject(Config.DetectedScreens);
        private async static void UpdateWSServer(Config conf)
        {
            if (conf.WebsocketServer && WebsocketServer == null)
            {
                WebsocketServer = new WebsocketBroadcastServer("*", conf.WebsocketPort)
                {
                    WelcomeMessage = SerializeScreens
                };
                await WebsocketServer.Listen();
            }
            else if (!conf.WebsocketServer)
            {
                WebsocketServer?.Stop();
                WebsocketServer = null;
            }
        }

        private static void NotifyWSClients(IEnumerable<DetectedScreen> screens)
        {
            Task _ = WebsocketServer?.Send(JsonConvert.SerializeObject(screens), CancellationToken.None);
        }

        public static Notifier<Config> ConfigUpdates { get; private set; } = new Notifier<Config>(()=>Config);

        public static Notifier<IEnumerable<DetectedScreen>> ScreenUpdates { get; private set; } = new Notifier<IEnumerable<DetectedScreen>>(()=>Config.DetectedScreens);

        public static void SaveConfig(string filename = null)
        {
            File.WriteAllText(filename ?? ConfigFile, JsonConvert.SerializeObject(Config, Formatting.Indented));
        }
        public static void LoadConfig(string filename = null)
        {
            if (File.Exists(filename ?? ConfigFile))
            {
                Config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(filename ?? ConfigFile));
                ConfigUpdates.Notify(Config);
            }
        }
    }
}
