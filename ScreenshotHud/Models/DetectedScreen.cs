using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenshotHud.Models
{
    public class DetectedScreen
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public Size Resolution { get; set; }
        public List<ColorPoint> MatchPoints { get; set; }
        public List<CaptureBox> CaptureBoxes { get; set; }
        public bool SaveScreenshot { get; set; } = false;

        [JsonIgnore]
        public Bitmap LastCapture { get; set; }
        public DateTime LastMatchTime { get; set; }
        [JsonIgnore]
        protected bool LastCheckMatched { get; set; } = false;
        public bool IsMatching => LastCheckMatched;

        public bool MatchAndSave(Bitmap capture)
        {
            var match = Match(capture);
            if (match)
            {
                LastCapture = capture;
                LastMatchTime = DateTime.Now;
                CaptureBoxes?.Where(b => b.Size.Width > 0 && b.Size.Height > 0).ToList().ForEach(b =>
                {

                    b.LastCapture?.Dispose();
                    var safeBox = new Rectangle(b.Point.X, b.Point.Y, b.Size.Width, b.Size.Height);
                    if (safeBox.Right > capture.Width)
                        safeBox.Width -= safeBox.Right - capture.Width;
                    if (safeBox.Bottom > capture.Height)
                        safeBox.Height -= safeBox.Bottom - capture.Height;
                    b.LastCapture = capture.Clone(safeBox, capture.PixelFormat);
                    if (b.OCR)
                    {
                        Program.TextLog.FindAndLogText(b);
                    }
                });
                if (!LastCheckMatched)
                {
                    // Just started matching
                    LastCheckMatched = match;
                    if (SaveScreenshot)
                        ScreenshotWriter.WriteScreenshot(capture, Name);
                    Program.ScreenUpdates.Notify();
                }
            }
            else if (LastCheckMatched)
            {
                // Just stopped matching
                foreach (var box in CaptureBoxes.Where(b => b.OCR))
                {
                    Program.TextLog.Flush(box);
                }
                //Program.ScreenUpdates.Notify();
            }
            LastCheckMatched = match;
            return match;
        }
        protected bool Match(Bitmap capture) => (MatchPoints?.Count ?? 0) > 0 && (MatchPoints?.TrueForAll(point => CheckPointMatching(point, capture)) ?? false);

        public bool CheckPointMatching(ColorPoint point, Bitmap capture) => ColorMatch(point.Color, capture.GetPixel((int)(point.Point.X / (double)Resolution.Width * capture.Width), (int)(point.Point.Y / (double)Resolution.Height * capture.Height)));

        protected static bool ColorMatch(Color c1, Color c2) =>
            c1.R >= c2.R - Program.Config.MatchColorDrift && c1.R <= c2.R + Program.Config.MatchColorDrift &&
            c1.G >= c2.G - Program.Config.MatchColorDrift && c1.G <= c2.G + Program.Config.MatchColorDrift &&
            c1.B >= c2.B - Program.Config.MatchColorDrift && c1.B <= c2.B + Program.Config.MatchColorDrift;
    }
}
