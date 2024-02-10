using Newtonsoft.Json;
using System;
using System.Drawing;

namespace ScreenshotHud.Models
{
    public class CaptureBox
    {
        public string Name { get; set; }
        public Point Point { get; set; }
        public Size Size { get; set; }
        public Point DisplayLocation { get; set; }
        public bool OCR { get; set; }

        [JsonIgnore]
        public Bitmap LastCapture { get; set; }
    }
}
