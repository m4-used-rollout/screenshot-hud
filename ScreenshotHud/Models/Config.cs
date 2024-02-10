using System;
using System.Collections.Generic;
using System.Drawing;

namespace ScreenshotHud.Models
{
    public class Config
    {
        public List<DetectedScreen> DetectedScreens { get; set; } = new List<DetectedScreen>();
        public int MatchColorDrift { get; set; } = 0;
        public int ShotDelayMS { get; set; } = 50;
        public int? SelectedDisplay { get; set; }
        public Rectangle PreviewWindow { get; set; }
        public Rectangle ControlWindow { get; set; }
        public string ScreenshotFolder { get; set; } = "~\\Screenshots\\";
        public string TextLogFileName { get; set; } = "~\\Events\\OCRLog.txt";
        public bool WebsocketServer { get; set; } = false;
        public int WebsocketPort { get; set; } = 1339;
        public bool AutoSave { get; set; } = false;

    }
}
