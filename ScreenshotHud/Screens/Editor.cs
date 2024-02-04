using ScreenshotHud.Models;
using ScreenshotHud.Templates;
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
    public partial class Editor : Form
    {
        private Guid SelectedScreenId { get; set; }
        private DetectedScreen SelectedScreen { get => Program.Config.DetectedScreens.FirstOrDefault(s => s?.Id == SelectedScreenId); set => SelectedScreenId = value?.Id ?? Guid.Empty; }
        private BindingSource Screens { get; } = new BindingSource();

        private List<ColorPointEditor> PointEditors { get; } = new List<ColorPointEditor>();
        private List<CaptureBoxEditor> BoxEditors { get; } = new List<CaptureBoxEditor>();
        private List<Color> Colors { get; } = new List<Color>();
        private Action<Point> PointClickFunction { get; set; }
        private Graphics Draw { get; set; }

        public Editor()
        {
            InitializeComponent();
            Program.Config.DetectedScreens = Program.Config.DetectedScreens ?? new List<DetectedScreen>();
            Screens.DataSource = Program.Config.DetectedScreens;
            ScreenSelect.DataSource = Screens;
            ScreenSelect.DisplayMember = "Name";
            if (Program.Config.DetectedScreens.Any())
            {
                ScreenSelect.Enabled = true;
                ScreenSelect.SelectedIndex = 0;
            }
            else
                ToggleScreenEditorTools();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ShotTaker.Register(UpdateCapture);
            var chromeWidth = Width - ClientRectangle.Width;
            Width = 848 + chromeWidth;
            MinimumSize = new Size(Width, 64);
            FixAspectRatio();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ShotTaker.Unregister(UpdateCapture);
            base.OnFormClosing(e);
        }

        public void UpdateCapture(Bitmap capture)
        {
            CaptureBox.Image = CaptureBox.Image ?? new Bitmap(capture);
            Draw = Draw ?? Graphics.FromImage(CaptureBox.Image);
            Draw.DrawImage(capture, 0, 0);
            if (SelectedScreen != null)
            {
                var penMatching = new Pen(Color.Green, 3);
                var penNotMatching = new Pen(Color.Red, 3);
                var penBlack = new Pen(Color.Black);
                var rand = new Random();

                BoxEditors.ForEach(b =>
                {
                    var i = BoxEditors.IndexOf(b);
                    if (Colors.Count <= i)
                        Colors.Add(Color.FromArgb(128, rand.Next(32, 255), rand.Next(32, 255), rand.Next(32, 255)));
                    var pen = new Pen(Colors[i]);
                    var rectangle = new Rectangle(b.CaptureBox.Point.X, b.CaptureBox.Point.Y, b.CaptureBox.Size.Width, b.CaptureBox.Size.Height);
                    Draw.FillRectangle(pen.Brush, rectangle);
                    Draw.DrawString(b.CaptureBox.Name, DefaultFont, penBlack.Brush, rectangle);
                });
                PointEditors.ForEach(p =>
                {
                    p.Matching = SelectedScreen.CheckPointMatching(p.Point, capture);
                    Draw.DrawRectangle(p.Matching ? penMatching : penNotMatching, new Rectangle(p.Point.Point.X - 1, p.Point.Point.Y - 1, 3, 3));
                });
                chkMatching.Checked = SelectedScreen.IsMatching;
            }
            CaptureBox.Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            FixAspectRatio();
            base.OnSizeChanged(e);
        }

        private void FixAspectRatio()
        {
            CaptureBox.Height = (int)Math.Round(CaptureBox.Width / ShotTaker.AspectRatio);
        }

        private void ToggleScreenEditorTools()
        {
            var toggle = SelectedScreen != null;
            btnDelete.Enabled = toggle;
            ScreenSelect.Enabled = Program.Config.DetectedScreens.Any();
            txtName.Enabled = toggle;
            btnNewPoint.Enabled = toggle;
            btnNewCaptureBox.Enabled = toggle;
            chkScreenshot.Enabled = toggle;
        }

        private void btnAddNewScreen_Click(object sender, EventArgs e)
        {
            var screen = new DetectedScreen();
            screen.Resolution = ShotTaker.CurrentShot.Size;
            Program.Config.DetectedScreens.Add(screen);
            screen.Name = $"Screen {Program.Config.DetectedScreens.Count}";
            Screens.ResetBindings(false);
            ScreenSelect.SelectedItem = screen;
            Program.NotifyConfigUpdate();
        }

        private void ScreenSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedScreen = ScreenSelect.SelectedItem as DetectedScreen;
            ToggleScreenEditorTools();
            PointEditors.ForEach(p => pointPanel.Controls.Remove(p));
            PointEditors.Clear();
            BoxEditors.ForEach(p => boxPanel.Controls.Remove(p));
            BoxEditors.Clear();
            txtName.Text = SelectedScreen?.Name ?? "";
            chkScreenshot.Checked = SelectedScreen?.SaveScreenshot ?? false;
            SelectedScreen?.MatchPoints?.ForEach(p => AddColorPointEditor(p));
            SelectedScreen?.CaptureBoxes?.ForEach(b => AddCaptureBoxEditor(b));
        }

        private void AddColorPointEditor(ColorPoint point)
        {
            var editor = new ColorPointEditor(point, SelectedScreen.Resolution, callback => PointClickFunction = callback, editor =>
              {
                  pointPanel.Controls.Remove(editor);
                  PointEditors.Remove(editor);
                  SelectedScreen.MatchPoints.Remove(point);
                  Program.NotifyConfigUpdate();
              });
            PointEditors.Add(editor);
            pointPanel.Controls.Add(editor);
            pointPanel.SetFlowBreak(editor, true);
        }
        private void AddCaptureBoxEditor(CaptureBox box)
        {
            var editor = new CaptureBoxEditor(box, SelectedScreen.Resolution, callback => PointClickFunction = callback, editor =>
            {
                boxPanel.Controls.Remove(editor);
                BoxEditors.Remove(editor);
                SelectedScreen.CaptureBoxes.Remove(box);
                Program.NotifyConfigUpdate();
            });
            BoxEditors.Add(editor);
            boxPanel.Controls.Add(editor);
            boxPanel.SetFlowBreak(editor, true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Program.Config.DetectedScreens.Remove(SelectedScreen);
            Screens.ResetBindings(false);
            if (Program.Config.DetectedScreens.Any())
                ScreenSelect.SelectedIndex = 0;
            else
                ToggleScreenEditorTools();
            Program.NotifyConfigUpdate();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.TextLength > 0)
            {
                SelectedScreen.Name = txtName.Text;
            }
        }

        private void btnNewPoint_Click(object sender, EventArgs e)
        {
            var newPoint = new ColorPoint();
            SelectedScreen.MatchPoints = SelectedScreen.MatchPoints ?? new List<ColorPoint>();
            SelectedScreen.MatchPoints.Add(newPoint);
            AddColorPointEditor(newPoint);
            Program.NotifyConfigUpdate();
        }

        private void CaptureBox_Click(object sender, EventArgs e)
        {
            if (PointClickFunction != null)
            {
                var mouse = e as MouseEventArgs;
                var resolutionMultiple = (double)SelectedScreen.Resolution.Height / CaptureBox.Height;
                var imperfectBoxAdjust = (int)(CaptureBox.Width - SelectedScreen.Resolution.Width / resolutionMultiple) / 2;
                var point = new Point((int)(mouse.X * resolutionMultiple) - imperfectBoxAdjust, (int)(mouse.Y * resolutionMultiple));
                PointClickFunction?.Invoke(point);
                PointClickFunction = null;
            }
        }

        private void btnNewCaptureBox_Click(object sender, EventArgs e)
        {
            var newBox = new CaptureBox();
            SelectedScreen.CaptureBoxes = SelectedScreen.CaptureBoxes ?? new List<CaptureBox>();
            SelectedScreen.CaptureBoxes.Add(newBox);
            newBox.Name = $"Box {SelectedScreen.CaptureBoxes.Count}";
            AddCaptureBoxEditor(newBox);
            Program.NotifyConfigUpdate();
        }

        private void chkScreenshot_CheckedChanged(object sender, EventArgs e)
        {
            SelectedScreen.SaveScreenshot = chkScreenshot.Checked;
        }

        private void btnFreeze_Click(object sender, EventArgs e)
        {
            ShotTaker.Freeze();
            if (btnFreeze.Text == "Freeze")
                btnFreeze.Text = "Thaw";
            else
                btnFreeze.Text = "Freeze";
        }
    }
}
