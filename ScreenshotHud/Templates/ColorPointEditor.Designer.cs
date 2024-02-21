
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
            label1 = new System.Windows.Forms.Label();
            xBox = new System.Windows.Forms.NumericUpDown();
            yBox = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            rBox = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            gBox = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            bBox = new System.Windows.Forms.NumericUpDown();
            label5 = new System.Windows.Forms.Label();
            chkMatching = new System.Windows.Forms.CheckBox();
            chkInverse = new System.Windows.Forms.CheckBox();
            btnPointer = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)xBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bBox).BeginInit();
            SuspendLayout();
            // 
            // btnPointer
            // 
            btnPointer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnPointer.AutoSize = true;
            btnPointer.Image = Properties.Resources._9990f3d7247c46cae16abb679d5290dcU9dKwIJvjkFqh1mu_4;
            btnPointer.Location = new System.Drawing.Point(237, 7);
            btnPointer.Name = "btnPointer";
            btnPointer.Size = new System.Drawing.Size(37, 35);
            btnPointer.TabIndex = 10;
            btnPointer.UseVisualStyleBackColor = true;
            btnPointer.Click += btnPointer_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnDelete.Location = new System.Drawing.Point(782, 6);
            btnDelete.Margin = new System.Windows.Forms.Padding(6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(35, 40);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "X";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(0, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(25, 30);
            label1.TabIndex = 0;
            label1.Text = "X";
            // 
            // xBox
            // 
            xBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            xBox.Location = new System.Drawing.Point(31, 8);
            xBox.Name = "xBox";
            xBox.Size = new System.Drawing.Size(79, 35);
            xBox.TabIndex = 1;
            xBox.ValueChanged += xBox_ValueChanged;
            // 
            // yBox
            // 
            yBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            yBox.Location = new System.Drawing.Point(149, 8);
            yBox.Name = "yBox";
            yBox.Size = new System.Drawing.Size(82, 35);
            yBox.TabIndex = 3;
            yBox.ValueChanged += yBox_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(118, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(25, 30);
            label2.TabIndex = 2;
            label2.Text = "Y";
            // 
            // rBox
            // 
            rBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            rBox.Location = new System.Drawing.Point(311, 8);
            rBox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            rBox.Name = "rBox";
            rBox.Size = new System.Drawing.Size(71, 35);
            rBox.TabIndex = 5;
            rBox.ValueChanged += rBox_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(280, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(26, 30);
            label3.TabIndex = 4;
            label3.Text = "R";
            // 
            // gBox
            // 
            gBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            gBox.Location = new System.Drawing.Point(419, 8);
            gBox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            gBox.Name = "gBox";
            gBox.Size = new System.Drawing.Size(71, 35);
            gBox.TabIndex = 7;
            gBox.ValueChanged += gBox_ValueChanged;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(388, 10);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(27, 30);
            label4.TabIndex = 6;
            label4.Text = "G";
            // 
            // bBox
            // 
            bBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            bBox.Location = new System.Drawing.Point(527, 8);
            bBox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            bBox.Name = "bBox";
            bBox.Size = new System.Drawing.Size(71, 35);
            bBox.TabIndex = 9;
            bBox.ValueChanged += bBox_ValueChanged;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(496, 10);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(25, 30);
            label5.TabIndex = 8;
            label5.Text = "B";
            // 
            // chkMatching
            // 
            chkMatching.AutoSize = true;
            chkMatching.Enabled = false;
            chkMatching.Location = new System.Drawing.Point(754, 15);
            chkMatching.Name = "chkMatching";
            chkMatching.Size = new System.Drawing.Size(22, 21);
            chkMatching.TabIndex = 11;
            chkMatching.UseVisualStyleBackColor = true;
            // 
            // chkInverse
            // 
            chkInverse.AutoSize = true;
            chkInverse.Location = new System.Drawing.Point(614, 10);
            chkInverse.Name = "chkInverse";
            chkInverse.Size = new System.Drawing.Size(92, 34);
            chkInverse.TabIndex = 13;
            chkInverse.Text = "Invert";
            chkInverse.UseVisualStyleBackColor = true;
            chkInverse.CheckedChanged += chkInverse_CheckedChanged;
            // 
            // ColorPointEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(chkInverse);
            Controls.Add(chkMatching);
            Controls.Add(btnDelete);
            Controls.Add(btnPointer);
            Controls.Add(bBox);
            Controls.Add(label5);
            Controls.Add(gBox);
            Controls.Add(label4);
            Controls.Add(rBox);
            Controls.Add(label3);
            Controls.Add(yBox);
            Controls.Add(label2);
            Controls.Add(xBox);
            Controls.Add(label1);
            Name = "ColorPointEditor";
            Size = new System.Drawing.Size(823, 50);
            ((System.ComponentModel.ISupportInitialize)xBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)yBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)rBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)gBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)bBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.CheckBox chkInverse;
    }
}
