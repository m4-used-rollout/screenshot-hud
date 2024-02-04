
namespace ScreenshotHud
{
    partial class Control
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CaptureTimer = new System.Windows.Forms.Timer(components);
            btnPreview = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            btnEditor = new System.Windows.Forms.Button();
            btnOverlay = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            DisplaySelect = new System.Windows.Forms.ComboBox();
            panel2 = new System.Windows.Forms.Panel();
            chkAutoSave = new System.Windows.Forms.CheckBox();
            btnImport = new System.Windows.Forms.Button();
            btnExport = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            dlgImportConfig = new System.Windows.Forms.OpenFileDialog();
            dlgExportConfig = new System.Windows.Forms.SaveFileDialog();
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            numColorDrift = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            numCaptureSpeed = new System.Windows.Forms.NumericUpDown();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numColorDrift).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCaptureSpeed).BeginInit();
            SuspendLayout();
            // 
            // CaptureTimer
            // 
            CaptureTimer.Enabled = true;
            CaptureTimer.Interval = 50;
            CaptureTimer.Tick += CaptureTimer_Tick;
            // 
            // btnPreview
            // 
            btnPreview.Dock = System.Windows.Forms.DockStyle.Right;
            btnPreview.Location = new System.Drawing.Point(207, 0);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new System.Drawing.Size(113, 57);
            btnPreview.TabIndex = 0;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.Click += BtnPreview_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnPreview);
            panel1.Controls.Add(btnEditor);
            panel1.Controls.Add(btnOverlay);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 195);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(550, 57);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 13);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(98, 30);
            label4.TabIndex = 1;
            label4.Text = "Windows";
            // 
            // btnEditor
            // 
            btnEditor.Dock = System.Windows.Forms.DockStyle.Right;
            btnEditor.Location = new System.Drawing.Point(320, 0);
            btnEditor.Name = "btnEditor";
            btnEditor.Size = new System.Drawing.Size(122, 57);
            btnEditor.TabIndex = 2;
            btnEditor.Text = "Editor";
            btnEditor.UseVisualStyleBackColor = true;
            btnEditor.Click += btnEditor_Click;
            // 
            // btnOverlay
            // 
            btnOverlay.Dock = System.Windows.Forms.DockStyle.Right;
            btnOverlay.Location = new System.Drawing.Point(442, 0);
            btnOverlay.Name = "btnOverlay";
            btnOverlay.Size = new System.Drawing.Size(108, 57);
            btnOverlay.TabIndex = 3;
            btnOverlay.Text = "Overlay";
            btnOverlay.UseVisualStyleBackColor = true;
            btnOverlay.Click += BtnOverlay_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            btnSave.Enabled = false;
            btnSave.Location = new System.Drawing.Point(207, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(81, 50);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label1.Location = new System.Drawing.Point(0, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(189, 30);
            label1.TabIndex = 2;
            label1.Text = "Display to Capture:";
            // 
            // DisplaySelect
            // 
            DisplaySelect.FormattingEnabled = true;
            DisplaySelect.Location = new System.Drawing.Point(207, 12);
            DisplaySelect.Name = "DisplaySelect";
            DisplaySelect.Size = new System.Drawing.Size(331, 38);
            DisplaySelect.TabIndex = 3;
            DisplaySelect.SelectedIndexChanged += DisplaySelect_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(chkAutoSave);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnImport);
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(label2);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 145);
            panel2.MinimumSize = new System.Drawing.Size(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(550, 50);
            panel2.TabIndex = 4;
            // 
            // chkAutoSave
            // 
            chkAutoSave.AutoSize = true;
            chkAutoSave.Dock = System.Windows.Forms.DockStyle.Right;
            chkAutoSave.Location = new System.Drawing.Point(123, 0);
            chkAutoSave.Name = "chkAutoSave";
            chkAutoSave.Size = new System.Drawing.Size(84, 50);
            chkAutoSave.TabIndex = 5;
            chkAutoSave.Text = "Auto";
            chkAutoSave.UseVisualStyleBackColor = true;
            chkAutoSave.CheckedChanged += ChkAutoSave_CheckedChanged;
            // 
            // btnImport
            // 
            btnImport.Dock = System.Windows.Forms.DockStyle.Right;
            btnImport.Location = new System.Drawing.Point(288, 0);
            btnImport.Name = "btnImport";
            btnImport.Size = new System.Drawing.Size(131, 50);
            btnImport.TabIndex = 3;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += BtnImport_Click;
            // 
            // btnExport
            // 
            btnExport.Dock = System.Windows.Forms.DockStyle.Right;
            btnExport.Location = new System.Drawing.Point(419, 0);
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(131, 50);
            btnExport.TabIndex = 4;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += BtnExport_Click;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 30);
            label2.TabIndex = 2;
            label2.Text = "Config";
            // 
            // dlgImportConfig
            // 
            dlgImportConfig.DefaultExt = "json";
            dlgImportConfig.Title = "Import Config File";
            // 
            // dlgExportConfig
            // 
            dlgExportConfig.DefaultExt = "json";
            dlgExportConfig.FileName = "config.json";
            dlgExportConfig.Title = "Export Config File";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(DisplaySelect);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(550, 58);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(numColorDrift);
            panel4.Controls.Add(label3);
            panel4.Dock = System.Windows.Forms.DockStyle.Top;
            panel4.Location = new System.Drawing.Point(0, 58);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(550, 43);
            panel4.TabIndex = 6;
            // 
            // numColorDrift
            // 
            numColorDrift.Location = new System.Drawing.Point(407, 4);
            numColorDrift.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numColorDrift.Name = "numColorDrift";
            numColorDrift.Size = new System.Drawing.Size(131, 35);
            numColorDrift.TabIndex = 1;
            numColorDrift.ValueChanged += NumColorDrift_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(0, 6);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(288, 30);
            label3.TabIndex = 0;
            label3.Text = "Maximum Color Drift Allowed";
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(numCaptureSpeed);
            panel5.Dock = System.Windows.Forms.DockStyle.Top;
            panel5.Location = new System.Drawing.Point(0, 101);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(550, 43);
            panel5.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(0, 6);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(321, 30);
            label5.TabIndex = 1;
            label5.Text = "Screenshot Interval (milliseconds)";
            // 
            // numCaptureSpeed
            // 
            numCaptureSpeed.Location = new System.Drawing.Point(407, 4);
            numCaptureSpeed.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numCaptureSpeed.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            numCaptureSpeed.Name = "numCaptureSpeed";
            numCaptureSpeed.Size = new System.Drawing.Size(131, 35);
            numCaptureSpeed.TabIndex = 0;
            numCaptureSpeed.Value = new decimal(new int[] { 16, 0, 0, 0 });
            numCaptureSpeed.ValueChanged += numCaptureSpeed_ValueChanged;
            // 
            // Control
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(550, 252);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new System.Drawing.Size(574, 9000);
            MinimumSize = new System.Drawing.Size(574, 64);
            Name = "Control";
            Text = "ScreenshotHud Control Panel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numColorDrift).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCaptureSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer CaptureTimer;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DisplaySelect;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.OpenFileDialog dlgImportConfig;
        private System.Windows.Forms.SaveFileDialog dlgExportConfig;
        private System.Windows.Forms.CheckBox chkAutoSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numColorDrift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.Button btnOverlay;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown numCaptureSpeed;
        private System.Windows.Forms.Label label5;
    }
}

