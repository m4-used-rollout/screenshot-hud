﻿using ScreenshotHud.Models;
using ScreenshotHud.Screens;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ScreenshotHud
{
    public partial class Control : Form
    {
        private Preview WinPreview { get; set; }
        private Editor WinEditor { get; set; }
        private Hud WinOverlay { get; set; }
        private static Config Config => Program.Config;
        public Control()
        {
            InitializeComponent();
            SetPosSizeFromConfig();
            chkAutoSave.Checked = Config.AutoSave;
            numColorDrift.Value = Config.MatchColorDrift;
            numCaptureSpeed.Value = Config.ShotDelayMS;
            CaptureTimer.Interval = Config.ShotDelayMS;
            numWebsocketPort.Value = Config.WebsocketPort;
            checkBoxHttpServer.Checked = Config.WebsocketServer;
            numWebsocketPort.Enabled = !Config.WebsocketServer;
            Program.ConfigUpdates.Register(ConfigUpdate);
            DisplaySelect.DataSource = Screen.AllScreens;
            DisplaySelect.DisplayMember = "Bounds";
            if (Config.SelectedDisplay != null && Config.SelectedDisplay < Screen.AllScreens.Length)
                DisplaySelect.SelectedIndex = Config.SelectedDisplay ?? 0;
            else
                DisplaySelect.SelectedItem = Screen.AllScreens.Last();
            ShotTaker.Screen = DisplaySelect.SelectedItem as Screen;
            ShotTaker.ShotNotifier.Register(capture =>
            {
                if (capture != null)
                    Config?.DetectedScreens?.ForEach(s => s.MatchAndSave(capture));
            });
            if (Config.DetectedScreens?.Any(s => s.CaptureBoxes?.Any() ?? false) ?? false)
            {
                SpawnOverlay();
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateConfigPosSize();
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            UpdateConfigPosSize();
        }

        private Rectangle ConfigPosSize { get => Config.ControlWindow; set => Config.ControlWindow = value; }
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
                Program.ConfigUpdates.Notify(Program.Config);
            }
        }

        private void ConfigUpdate(Config conf)
        {
            if (conf.AutoSave)
                SaveConfig();
            else
                btnSave.Enabled = true;
            if (conf.SelectedDisplay != null && conf.SelectedDisplay < DisplaySelect.Items.Count)
                DisplaySelect.SelectedIndex = conf.SelectedDisplay ?? DisplaySelect.SelectedIndex;
            numColorDrift.Value = conf.MatchColorDrift;
            numCaptureSpeed.Value = conf.ShotDelayMS;
            CaptureTimer.Interval = conf.ShotDelayMS;
            chkAutoSave.Checked = conf.AutoSave;
            numWebsocketPort.Enabled = !conf.WebsocketServer;
        }

        private void CaptureTimer_Tick(object sender, EventArgs e)
        {
            ShotTaker.Snap();
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            if (WinPreview?.IsDisposed ?? true)
                WinPreview = new Preview();
            WinPreview.Show();
            WinPreview.Focus();
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            if (WinEditor?.IsDisposed ?? true)
                WinEditor = new Editor();
            WinEditor.Show();
            WinEditor.Focus();
        }

        private void SpawnOverlay()
        {
            if (WinOverlay?.IsDisposed ?? true)
                WinOverlay = new Hud();
            WinOverlay.Show();
            WinOverlay.Focus();
        }

        private void DisplaySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShotTaker.Screen != null)
            {
                lock (ShotTaker.Screen)
                {
                    ShotTaker.Screen = DisplaySelect.SelectedItem as Screen;
                }
                Config.SelectedDisplay = DisplaySelect.SelectedIndex;
                Program.ConfigUpdates.Notify(Program.Config);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e) => SaveConfig();

        private void SaveConfig()
        {
            Program.SaveConfig();
            btnSave.Enabled = false;
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            if (dlgImportConfig.ShowDialog() == DialogResult.OK)
                Program.LoadConfig(dlgImportConfig.FileName);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (dlgExportConfig.ShowDialog() == DialogResult.OK)
                Program.SaveConfig(dlgExportConfig.FileName);
        }

        private void ChkAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            if (ShotTaker.Screen != null)
            {
                Program.Config.AutoSave = chkAutoSave.Checked;
                Program.ConfigUpdates.Notify(Program.Config);
            }
        }

        private void NumColorDrift_ValueChanged(object sender, EventArgs e)
        {
            if (ShotTaker.Screen != null)
            {
                Config.MatchColorDrift = (int)numColorDrift.Value;
                Program.ConfigUpdates.Notify(Program.Config);
            }
        }
        private void numCaptureSpeed_ValueChanged(object sender, EventArgs e)
        {
            Program.Config.ShotDelayMS = (int)numCaptureSpeed.Value;
            Program.ConfigUpdates.Notify(Program.Config);
        }

        private void BtnOverlay_Click(object sender, EventArgs e)
        {
            SpawnOverlay();
        }

        private void checkBoxHttpServer_CheckedChanged(object sender, EventArgs e)
        {
            Program.Config.WebsocketServer = checkBoxHttpServer.Checked;
            Program.ConfigUpdates.Notify(Program.Config);
        }

        private void numWebsocketPort_ValueChanged(object sender, EventArgs e)
        {
            Program.Config.WebsocketPort = (int)numWebsocketPort.Value;
            Program.ConfigUpdates.Notify(Program.Config);
        }
    }
}
