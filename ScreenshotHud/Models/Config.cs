using System;
using System.Collections.Generic;
using System.Drawing;

namespace ScreenshotHud.Models
{
    public class Config
    {
        public List<DetectedScreen> DetectedScreens { get; set; } = new List<DetectedScreen>();
        public int MatchColorDrift { get; set; } = 0;
        public int? SelectedDisplay { get; set; }
        public Rectangle PreviewWindow { get; set; }
        public Rectangle ControlWindow { get; set; }
        public string ScreenshotFolder { get; set; } = "~\\Screenshots\\";
        public bool AutoSave { get; set; } = false;

    }
}
