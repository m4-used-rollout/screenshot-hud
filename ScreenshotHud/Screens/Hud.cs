using ScreenshotHud.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenshotHud.Screens
{
    public partial class Hud : Form
    {

        private bool ShowBoxLayout { get; set; } = false;
        private Graphics OverlayDrawing { get; set; }
        private List<Color> Colors { get; } = new List<Color>();

        private static readonly Random random = new();
        private static readonly Pen penBlack = new(Color.Black);

        public Hud()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RemakeImage(Program.Config);
            ShotTaker.ShotNotifier.Register(UpdateImage);
            Program.ConfigUpdates.Register(RemakeImage);
        }

        private static IEnumerable<DetectedScreen> Screens => Program.Config.DetectedScreens?.Select(s => s).OrderBy(s => s.LastMatchTime);

        private void RemakeImage(Config config)
        {
            List<CaptureBox> boxes = Screens?.SelectMany(s => s.CaptureBoxes ?? new List<CaptureBox>())?.ToList() ?? new List<CaptureBox>();
            OverlayBox.Image?.Dispose();
            OverlayBox.Image = boxes.Count > 0 ? new Bitmap(boxes.Max(b => b.DisplayLocation.X + b.Size.Width), boxes.Max(b => b.DisplayLocation.Y + b.Size.Height)) : new Bitmap(1, 1);
            OverlayDrawing = Graphics.FromImage(OverlayBox.Image);
            boxes.ForEach(b =>
            {
                if (b.LastCapture != null)
                    OverlayDrawing.DrawImage(b.LastCapture, b.DisplayLocation);
                if (ShowBoxLayout)
                {
                    var i = boxes.IndexOf(b);
                    if (Colors.Count <= i)
                        Colors.Add(Color.FromArgb(128, random.Next(127, 255), random.Next(127, 255), random.Next(127, 255)));
                    var pen = new Pen(Colors[i]);
                    var rectangle = new Rectangle(b.DisplayLocation.X, b.DisplayLocation.Y, b.Size.Width, b.Size.Height);
                    OverlayDrawing.FillRectangle(pen.Brush, rectangle);
                    OverlayDrawing.DrawString(b.OCR && !string.IsNullOrWhiteSpace(Program.TextLog.LastDetectedText(b)) ? $"{b.Name}\n{Program.TextLog.LastDetectedText(b)}" : b.Name, DefaultFont, penBlack.Brush, rectangle);
                }
            });
            OverlayBox.Invalidate();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ShotTaker.ShotNotifier.Unregister(UpdateImage);
            base.OnFormClosing(e);
        }

        public void UpdateImage(Bitmap bg)
        {
            Screens?.Where(s => s.IsMatching).ToList().ForEach(s => s.CaptureBoxes?.Where(b => b.LastCapture != null).ToList().ForEach(b => OverlayDrawing.DrawImage(b.LastCapture, b.DisplayLocation)));
            OverlayBox.Invalidate();
        }

        private void OverlayBox_Click(object sender, EventArgs e)
        {
            ShowBoxLayout = !ShowBoxLayout;
            RemakeImage(Program.Config);
        }
    }
}
