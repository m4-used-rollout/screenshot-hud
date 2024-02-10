using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenshotHud
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
            SetPosSizeFromConfig();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ShotTaker.ShotNotifier.Register(UpdateImage);
            FixAspectRatio();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ShotTaker.ShotNotifier.Unregister(UpdateImage);
            base.OnFormClosing(e);
        }

        public void UpdateImage(Bitmap bg)
        {
            CaptureBox.Image = bg;
            CaptureBox.Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            FixAspectRatio();
            base.OnSizeChanged(e);
            UpdateConfigPosSize();
        }

        private void FixAspectRatio()
        {
            CaptureBox.Height = ClientRectangle.Height;
            var chromeWidth = Width - ClientRectangle.Width;
            CaptureBox.Width = (int)Math.Round(CaptureBox.Height * ShotTaker.AspectRatio);
            Width = CaptureBox.Width + chromeWidth;
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            UpdateConfigPosSize();
        }

        private Rectangle ConfigPosSize { get => Program.Config.PreviewWindow; set => Program.Config.PreviewWindow = value; }
        private void SetPosSizeFromConfig()
        {
            if (ConfigPosSize.Width > 0)
                Width = ConfigPosSize.Width;
            if (ConfigPosSize.Height > 0)
                Height = ConfigPosSize.Height;
            if (ConfigPosSize.Left > 0)
                Left = ConfigPosSize.Left;
            if (ConfigPosSize.Top > 0)
                Top = ConfigPosSize.Top;
        }

        private void UpdateConfigPosSize()
        {
            if (ShotTaker.Screen != null)
            {
                ConfigPosSize = new Rectangle(Left, Top, Width, Height);
                Program.ConfigUpdates.Notify();
            }
        }

    }
}
