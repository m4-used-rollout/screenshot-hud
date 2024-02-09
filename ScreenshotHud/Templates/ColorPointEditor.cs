using ScreenshotHud.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenshotHud.Templates
{
    public partial class ColorPointEditor : UserControl
    {
        public ColorPoint Point { get; set; }
        public bool Matching
        {
            get => chkMatching.Checked;
            set => chkMatching.Checked = value;
        }
        private Action<Action<Point>> CallForPoint { get; set; }
        private Action<ColorPointEditor> Delete { get; set; }
        private bool PauseUpdates = false;
        public ColorPointEditor(ColorPoint point, Size resolution, Action<Action<Point>> pointCallback, Action<ColorPointEditor> deleteCallback)
        {
            InitializeComponent();
            Point = point;
            CallForPoint = pointCallback;
            Delete = deleteCallback;
            xBox.Maximum = resolution.Width - 1;
            yBox.Maximum = resolution.Height - 1;
            UpdateControls();
        }

        private void UpdateControls()
        {
            PauseUpdates = true;
            xBox.Value = Point.Point.X;
            yBox.Value = Point.Point.Y;
            rBox.Value = Point.Color.R;
            bBox.Value = Point.Color.B;
            gBox.Value = Point.Color.G;
            PauseUpdates = false;
        }

        private void Save() => Program.ConfigUpdates.Notify();

        private void UpdatePoint(Point point)
        {
            Point.Point = point;
            Point.Color = ShotTaker.CurrentShot.GetPixel(Point.Point.X, Point.Point.Y);
            UpdateControls();
            Save();
        }

        private void btnPointer_Click(object sender, EventArgs e)
        {
            CallForPoint(point =>
            {
                label1.Focus(); //unfocus btnPointer
                UpdatePoint(point);
            });
        }

        private void xBox_ValueChanged(object sender, EventArgs e)
        {
            if (PauseUpdates) return;
            Point.Point = new Point((int)xBox.Value, (int)yBox.Value);
            Point.Color = ShotTaker.CurrentShot.GetPixel(Point.Point.X, Point.Point.Y);
            Save();
        }

        private void yBox_ValueChanged(object sender, EventArgs e)
        {
            if (PauseUpdates) return;
            Point.Point = new Point((int)xBox.Value, (int)yBox.Value);
            Point.Color = ShotTaker.CurrentShot.GetPixel(Point.Point.X, Point.Point.Y);
            Save();
        }

        private void rBox_ValueChanged(object sender, EventArgs e)
        {
            if (PauseUpdates) return;
            Point.Color = Color.FromArgb((int)rBox.Value, (int)gBox.Value, (int)bBox.Value);
            Save();
        }

        private void gBox_ValueChanged(object sender, EventArgs e)
        {
            if (PauseUpdates) return;
            Point.Color = Color.FromArgb((int)rBox.Value, (int)gBox.Value, (int)bBox.Value);
            Save();
        }

        private void bBox_ValueChanged(object sender, EventArgs e)
        {
            if (PauseUpdates) return;
            Point.Color = Color.FromArgb((int)rBox.Value, (int)gBox.Value, (int)bBox.Value);
            Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete?.Invoke(this);
        }
    }
}
