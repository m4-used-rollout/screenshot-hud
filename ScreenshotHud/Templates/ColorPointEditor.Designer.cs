
namespace ScreenshotHud.Templates
{
    partial class ColorPointEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnPointer;
            System.Windows.Forms.Button btnDelete;
            this.label1 = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.NumericUpDown();
            this.yBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.gBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.bBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chkMatching = new System.Windows.Forms.CheckBox();
            btnPointer = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPointer
            // 
            btnPointer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnPointer.AutoSize = true;
            btnPointer.Image = global::ScreenshotHud.Properties.Resources._9990f3d7247c46cae16abb679d5290dcU9dKwIJvjkFqh1mu_4;
            btnPointer.Location = new System.Drawing.Point(237, 7);
            btnPointer.Name = "btnPointer";
            btnPointer.Size = new System.Drawing.Size(37, 35);
            btnPointer.TabIndex = 10;
            btnPointer.UseVisualStyleBackColor = true;
            btnPointer.Click += new System.EventHandler(this.btnPointer_Click);
            // 
            // btnDelete
            // 
            btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnDelete.AutoSize = true;
            btnDelete.Location = new System.Drawing.Point(644, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(37, 40);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "X";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // xBox
            // 
            this.xBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.xBox.Location = new System.Drawing.Point(31, 8);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(79, 35);
            this.xBox.TabIndex = 1;
            this.xBox.ValueChanged += new System.EventHandler(this.xBox_ValueChanged);
            // 
            // yBox
            // 
            this.yBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.yBox.Location = new System.Drawing.Point(149, 8);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(82, 35);
            this.yBox.TabIndex = 3;
            this.yBox.ValueChanged += new System.EventHandler(this.yBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // rBox
            // 
            this.rBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rBox.Location = new System.Drawing.Point(311, 8);
            this.rBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(71, 35);
            this.rBox.TabIndex = 5;
            this.rBox.ValueChanged += new System.EventHandler(this.rBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "R";
            // 
            // gBox
            // 
            this.gBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gBox.Location = new System.Drawing.Point(419, 8);
            this.gBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(71, 35);
            this.gBox.TabIndex = 7;
            this.gBox.ValueChanged += new System.EventHandler(this.gBox_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "G";
            // 
            // bBox
            // 
            this.bBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bBox.Location = new System.Drawing.Point(527, 8);
            this.bBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(71, 35);
            this.bBox.TabIndex = 9;
            this.bBox.ValueChanged += new System.EventHandler(this.bBox_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "B";
            // 
            // chkMatching
            // 
            this.chkMatching.AutoSize = true;
            this.chkMatching.Enabled = false;
            this.chkMatching.Location = new System.Drawing.Point(616, 16);
            this.chkMatching.Name = "chkMatching";
            this.chkMatching.Size = new System.Drawing.Size(22, 21);
            this.chkMatching.TabIndex = 11;
            this.chkMatching.UseVisualStyleBackColor = true;
            // 
            // ColorPointEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(btnDelete);
            this.Controls.Add(this.chkMatching);
            this.Controls.Add(btnPointer);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.label1);
            this.Name = "ColorPointEditor";
            this.Size = new System.Drawing.Size(690, 50);
            ((System.ComponentModel.ISupportInitialize)(this.xBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown xBox;
        private System.Windows.Forms.NumericUpDown yBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown rBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown gBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown bBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPointer;
        private System.Windows.Forms.CheckBox chkMatching;
    }
}
