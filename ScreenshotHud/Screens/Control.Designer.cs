
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
            this.components = new System.ComponentModel.Container();
            this.CaptureTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPreview = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplaySelect = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkAutoSave = new System.Windows.Forms.CheckBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dlgImportConfig = new System.Windows.Forms.OpenFileDialog();
            this.dlgExportConfig = new System.Windows.Forms.SaveFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numColorDrift = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOverlay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColorDrift)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptureTimer
            // 
            this.CaptureTimer.Enabled = true;
            this.CaptureTimer.Interval = 50;
            this.CaptureTimer.Tick += new System.EventHandler(this.CaptureTimer_Tick);
            // 
            // btnPreview
            // 
            this.btnPreview.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPreview.Location = new System.Drawing.Point(207, 0);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(113, 57);
            this.btnPreview.TabIndex = 0;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Controls.Add(this.btnEditor);
            this.panel1.Controls.Add(this.btnOverlay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 57);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Windows";
            // 
            // btnEditor
            // 
            this.btnEditor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditor.Location = new System.Drawing.Point(320, 0);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(122, 57);
            this.btnEditor.TabIndex = 2;
            this.btnEditor.Text = "Editor";
            this.btnEditor.UseVisualStyleBackColor = true;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(207, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 50);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Display to Capture:";
            // 
            // DisplaySelect
            // 
            this.DisplaySelect.FormattingEnabled = true;
            this.DisplaySelect.Location = new System.Drawing.Point(207, 12);
            this.DisplaySelect.Name = "DisplaySelect";
            this.DisplaySelect.Size = new System.Drawing.Size(331, 38);
            this.DisplaySelect.TabIndex = 3;
            this.DisplaySelect.SelectedIndexChanged += new System.EventHandler(this.DisplaySelect_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.chkAutoSave);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 50);
            this.panel2.TabIndex = 4;
            // 
            // chkAutoSave
            // 
            this.chkAutoSave.AutoSize = true;
            this.chkAutoSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkAutoSave.Location = new System.Drawing.Point(123, 0);
            this.chkAutoSave.Name = "chkAutoSave";
            this.chkAutoSave.Size = new System.Drawing.Size(84, 50);
            this.chkAutoSave.TabIndex = 5;
            this.chkAutoSave.Text = "Auto";
            this.chkAutoSave.UseVisualStyleBackColor = true;
            this.chkAutoSave.CheckedChanged += new System.EventHandler(this.ChkAutoSave_CheckedChanged);
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImport.Location = new System.Drawing.Point(288, 0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(131, 50);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExport.Location = new System.Drawing.Point(419, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(131, 50);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Config";
            // 
            // dlgImportConfig
            // 
            this.dlgImportConfig.DefaultExt = "json";
            this.dlgImportConfig.Title = "Import Config File";
            // 
            // dlgExportConfig
            // 
            this.dlgExportConfig.DefaultExt = "json";
            this.dlgExportConfig.FileName = "config.json";
            this.dlgExportConfig.Title = "Export Config File";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.DisplaySelect);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 58);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numColorDrift);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 43);
            this.panel4.TabIndex = 6;
            // 
            // numColorDrift
            // 
            this.numColorDrift.Location = new System.Drawing.Point(407, 4);
            this.numColorDrift.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numColorDrift.Name = "numColorDrift";
            this.numColorDrift.Size = new System.Drawing.Size(131, 35);
            this.numColorDrift.TabIndex = 1;
            this.numColorDrift.ValueChanged += new System.EventHandler(this.NumColorDrift_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Maximum Color Drift Allowed";
            // 
            // btnOverlay
            // 
            this.btnOverlay.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOverlay.Location = new System.Drawing.Point(442, 0);
            this.btnOverlay.Name = "btnOverlay";
            this.btnOverlay.Size = new System.Drawing.Size(108, 57);
            this.btnOverlay.TabIndex = 3;
            this.btnOverlay.Text = "Overlay";
            this.btnOverlay.UseVisualStyleBackColor = true;
            this.btnOverlay.Click += new System.EventHandler(this.BtnOverlay_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(550, 208);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(574, 9000);
            this.MinimumSize = new System.Drawing.Size(574, 64);
            this.Name = "Control";
            this.Text = "ScreenshotHud Control Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColorDrift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

