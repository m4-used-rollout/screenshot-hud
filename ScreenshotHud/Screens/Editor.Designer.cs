
namespace ScreenshotHud.Screens
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CaptureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNewScreen = new System.Windows.Forms.Button();
            this.ScreenSelect = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFreeze = new System.Windows.Forms.Button();
            this.chkScreenshot = new System.Windows.Forms.CheckBox();
            this.btnNewCaptureBox = new System.Windows.Forms.Button();
            this.btnNewPoint = new System.Windows.Forms.Button();
            this.chkMatching = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pointSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.boxPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointSource)).BeginInit();
            this.pointPanel.SuspendLayout();
            this.boxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CaptureBox
            // 
            this.CaptureBox.BackColor = System.Drawing.Color.Black;
            this.CaptureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CaptureBox.Location = new System.Drawing.Point(0, 164);
            this.CaptureBox.Name = "CaptureBox";
            this.CaptureBox.Size = new System.Drawing.Size(1416, 720);
            this.CaptureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CaptureBox.TabIndex = 2;
            this.CaptureBox.TabStop = false;
            this.CaptureBox.Click += new System.EventHandler(this.CaptureBox_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNewScreen);
            this.panel1.Controls.Add(this.ScreenSelect);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1416, 56);
            this.panel1.TabIndex = 3;
            // 
            // btnAddNewScreen
            // 
            this.btnAddNewScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddNewScreen.Location = new System.Drawing.Point(1181, 0);
            this.btnAddNewScreen.Name = "btnAddNewScreen";
            this.btnAddNewScreen.Size = new System.Drawing.Size(147, 56);
            this.btnAddNewScreen.TabIndex = 1;
            this.btnAddNewScreen.Text = "New Screen";
            this.btnAddNewScreen.UseVisualStyleBackColor = true;
            this.btnAddNewScreen.Click += new System.EventHandler(this.btnAddNewScreen_Click);
            // 
            // ScreenSelect
            // 
            this.ScreenSelect.Enabled = false;
            this.ScreenSelect.FormattingEnabled = true;
            this.ScreenSelect.Location = new System.Drawing.Point(12, 12);
            this.ScreenSelect.Name = "ScreenSelect";
            this.ScreenSelect.Size = new System.Drawing.Size(1027, 38);
            this.ScreenSelect.TabIndex = 0;
            this.ScreenSelect.SelectedValueChanged += new System.EventHandler(this.ScreenSelect_SelectedValueChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(1328, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 56);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFreeze);
            this.panel2.Controls.Add(this.chkScreenshot);
            this.panel2.Controls.Add(this.btnNewCaptureBox);
            this.panel2.Controls.Add(this.btnNewPoint);
            this.panel2.Controls.Add(this.chkMatching);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1416, 47);
            this.panel2.TabIndex = 4;
            // 
            // btnFreeze
            // 
            this.btnFreeze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFreeze.Location = new System.Drawing.Point(1181, 4);
            this.btnFreeze.Name = "btnFreeze";
            this.btnFreeze.Size = new System.Drawing.Size(102, 40);
            this.btnFreeze.TabIndex = 6;
            this.btnFreeze.Text = "Freeze";
            this.btnFreeze.UseVisualStyleBackColor = true;
            this.btnFreeze.Click += new System.EventHandler(this.btnFreeze_Click);
            // 
            // chkScreenshot
            // 
            this.chkScreenshot.AutoSize = true;
            this.chkScreenshot.Location = new System.Drawing.Point(928, 8);
            this.chkScreenshot.Name = "chkScreenshot";
            this.chkScreenshot.Size = new System.Drawing.Size(199, 34);
            this.chkScreenshot.TabIndex = 5;
            this.chkScreenshot.Text = "Save Screenshots";
            this.chkScreenshot.UseVisualStyleBackColor = true;
            this.chkScreenshot.CheckedChanged += new System.EventHandler(this.chkScreenshot_CheckedChanged);
            // 
            // btnNewCaptureBox
            // 
            this.btnNewCaptureBox.AutoSize = true;
            this.btnNewCaptureBox.Location = new System.Drawing.Point(742, 4);
            this.btnNewCaptureBox.Name = "btnNewCaptureBox";
            this.btnNewCaptureBox.Size = new System.Drawing.Size(180, 40);
            this.btnNewCaptureBox.TabIndex = 4;
            this.btnNewCaptureBox.Text = "Add Capture Box";
            this.btnNewCaptureBox.UseVisualStyleBackColor = true;
            this.btnNewCaptureBox.Click += new System.EventHandler(this.btnNewCaptureBox_Click);
            // 
            // btnNewPoint
            // 
            this.btnNewPoint.AutoSize = true;
            this.btnNewPoint.Location = new System.Drawing.Point(588, 4);
            this.btnNewPoint.Name = "btnNewPoint";
            this.btnNewPoint.Size = new System.Drawing.Size(148, 40);
            this.btnNewPoint.TabIndex = 3;
            this.btnNewPoint.Text = "Add Point";
            this.btnNewPoint.UseVisualStyleBackColor = true;
            this.btnNewPoint.Click += new System.EventHandler(this.btnNewPoint_Click);
            // 
            // chkMatching
            // 
            this.chkMatching.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMatching.AutoSize = true;
            this.chkMatching.Enabled = false;
            this.chkMatching.Location = new System.Drawing.Point(1289, 8);
            this.chkMatching.Name = "chkMatching";
            this.chkMatching.Size = new System.Drawing.Size(127, 34);
            this.chkMatching.TabIndex = 2;
            this.chkMatching.Text = "Matching";
            this.chkMatching.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(92, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(490, 35);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // pointPanel
            // 
            this.pointPanel.AutoSize = true;
            this.pointPanel.Controls.Add(this.label2);
            this.pointPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pointPanel.Location = new System.Drawing.Point(0, 103);
            this.pointPanel.Name = "pointPanel";
            this.pointPanel.Size = new System.Drawing.Size(1416, 30);
            this.pointPanel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.pointPanel.SetFlowBreak(this.label2, true);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Points";
            // 
            // boxPanel
            // 
            this.boxPanel.AutoSize = true;
            this.boxPanel.Controls.Add(this.label3);
            this.boxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxPanel.Location = new System.Drawing.Point(0, 133);
            this.boxPanel.Name = "boxPanel";
            this.boxPanel.Size = new System.Drawing.Size(1416, 30);
            this.boxPanel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.boxPanel.SetFlowBreak(this.label3, true);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Capture Boxes";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1416, 884);
            this.Controls.Add(this.boxPanel);
            this.Controls.Add(this.pointPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CaptureBox);
            this.MinimumSize = new System.Drawing.Size(1304, 64);
            this.Name = "Editor";
            this.Text = "ScreenshotHud Screen Editor";
            ((System.ComponentModel.ISupportInitialize)(this.CaptureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointSource)).EndInit();
            this.pointPanel.ResumeLayout(false);
            this.pointPanel.PerformLayout();
            this.boxPanel.ResumeLayout(false);
            this.boxPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CaptureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNewScreen;
        private System.Windows.Forms.ComboBox ScreenSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMatching;
        private System.Windows.Forms.BindingSource pointSource;
        private System.Windows.Forms.FlowLayoutPanel pointPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewCaptureBox;
        private System.Windows.Forms.Button btnNewPoint;
        private System.Windows.Forms.FlowLayoutPanel boxPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkScreenshot;
        private System.Windows.Forms.Button btnFreeze;
    }
}