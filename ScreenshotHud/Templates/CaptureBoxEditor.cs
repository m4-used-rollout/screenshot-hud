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

namespace ScreenshotHud.Templates
{
    public partial class CaptureBoxEditor : UserControl
    {
        public CaptureBox CaptureBox { get; set; }
        private Action<Action<Point>> CallForPoint { get; set; }
        private Action<CaptureBoxEditor> Delete { get; set; }
        private bool PauseUpdates = false;
        public CaptureBoxEditor(CaptureBox box, Size resolution, Action<Action<Point>> pointCallback, Action<CaptureBoxEditor> deleteCallback)
        {
            InitializeComponent();
            CaptureBox = box;
            CallForPoint = pointCallback;
            Delete = deleteCallback;
            txtName.Text = box.Name;
            xBox.Maximum = wBox.Maximum = destXBox.Maximum = resolution.Width - 1;
            yBox.Maximum = hBox.Maximum = destYBox.Maximum = resolution.Height - 1;
            UpdateControls();
        }

        private void UpdateControls()
        {
            PauseUpdates = true;
            xBox.Value = CaptureBox.Point.X;
            yBox.Value = CaptureBox.Point.Y;
            wBox.Value = CaptureBox.Size.Width;
            hBox.Value = CaptureBox.Size.Height;
            destXBox.Value = CaptureBox.DisplayLocation.X;
            destYBox.Value = CaptureBox.DisplayLocation.Y;
            PauseUpdates = false;
        }

        private void Save() => Program.NotifyConfigUpdate();

        private void UpdatePoint(Point point)
        {
            CaptureBox.Point = new Point(point.X, point.Y);
            UpdateControls();
            Save();
        }

        private void UpdateSize(Point point)
        {
            if (point.X >= CaptureBox.Point.X && point.Y >= CaptureBox.Point.Y)
            {
                CaptureBox.Size = new Size(point.X - CaptureBox.Point.X, point.Y - CaptureBox.Point.Y);
            }
            else
            {
                CaptureBox.Size = new Size(CaptureBox.Point.X - point.X, CaptureBox.Point.Y - point.Y);
                CaptureBox.Point = new Point(point.X, point.Y);
            }
            UpdateControls();
            Save();
        }

        private void xBox_ValueChanged(object sender, EventArgs e)
        {
            if (PauseUpdates) return;
            CaptureBox.Point = new Point((int)xBox.Value, (int)yBox.Value);
            Save();
        }

        private void yBox_ValueChanged(object sender, EventArgs e)
        {
            if (PauseUpdates) return;
            CaptureBox.Point = new Point((int)xBox.Value, (int)yBox.Value);
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

        private void wBox_ValueChanged(object sender, EventArgs e)
        {
            if (PauseUpdates) return;
            CaptureBox.Size = new Size((int)wBox.Value, (int)hBox.Value);
            Save();
        }

        private void hBox_ValueChanged(object sender, EventArgs e)
        {
            if (PauseUpdates) return;
            CaptureBox.Size = new Size((int)wBox.Value, (int)hBox.Value);
            Save();
        }

        private void btnWidthPointer_Click(object sender, EventArgs e)
        {
            CallForPoint(point =>
            {
                label1.Focus(); //unfocus btnWidthPointer
                UpdateSize(point);
            });
        }

        private void destXBox_ValueChanged(object sender, EventArgs e)
        {
            if (PauseUpdates) return;
            CaptureBox.DisplayLocation = new Point((int)destXBox.Value, (int)destYBox.Value);
            Save();
        }

        private void destYBox_ValueChanged(object sender, EventArgs e)
        {
            if (PauseUpdates) return;
            CaptureBox.DisplayLocation = new Point((int)destXBox.Value, (int)destYBox.Value);
            Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete?.Invoke(this);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.TextLength > 0) {
                CaptureBox.Name = txtName.Text;
                Save();
            }
        }
    }
}
