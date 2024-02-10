
namespace ScreenshotHud.Templates
{
    partial class CaptureBoxEditor
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
            System.Windows.Forms.Button btnWidthPointer;
            System.Windows.Forms.Button btnDelete;
            yBox = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            xBox = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            wBox = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            hBox = new System.Windows.Forms.NumericUpDown();
            label5 = new System.Windows.Forms.Label();
            destXBox = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            destYBox = new System.Windows.Forms.NumericUpDown();
            label7 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            chkOCR = new System.Windows.Forms.CheckBox();
            btnPointer = new System.Windows.Forms.Button();
            btnWidthPointer = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)yBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)destXBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)destYBox).BeginInit();
            SuspendLayout();
            // 
            // btnPointer
            // 
            btnPointer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnPointer.AutoSize = true;
            btnPointer.Image = Properties.Resources._9990f3d7247c46cae16abb679d5290dcU9dKwIJvjkFqh1mu_4;
            btnPointer.Location = new System.Drawing.Point(437, 6);
            btnPointer.Name = "btnPointer";
            btnPointer.Size = new System.Drawing.Size(37, 35);
            btnPointer.TabIndex = 15;
            btnPointer.UseVisualStyleBackColor = true;
            btnPointer.Click += btnPointer_Click;
            // 
            // btnWidthPointer
            // 
            btnWidthPointer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnWidthPointer.AutoSize = true;
            btnWidthPointer.Image = Properties.Resources._9990f3d7247c46cae16abb679d5290dcU9dKwIJvjkFqh1mu_4;
            btnWidthPointer.Location = new System.Drawing.Point(729, 6);
            btnWidthPointer.Name = "btnWidthPointer";
            btnWidthPointer.Size = new System.Drawing.Size(37, 35);
            btnWidthPointer.TabIndex = 15;
            btnWidthPointer.UseVisualStyleBackColor = true;
            btnWidthPointer.Click += btnWidthPointer_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnDelete.AutoSize = true;
            btnDelete.Location = new System.Drawing.Point(1122, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(37, 40);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "X";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // yBox
            // 
            yBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            yBox.Location = new System.Drawing.Point(349, 7);
            yBox.Name = "yBox";
            yBox.Size = new System.Drawing.Size(82, 35);
            yBox.TabIndex = 14;
            yBox.ValueChanged += yBox_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(318, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(25, 30);
            label2.TabIndex = 13;
            label2.Text = "Y";
            // 
            // xBox
            // 
            xBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            xBox.Location = new System.Drawing.Point(231, 7);
            xBox.Name = "xBox";
            xBox.Size = new System.Drawing.Size(79, 35);
            xBox.TabIndex = 12;
            xBox.ValueChanged += xBox_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(200, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(25, 30);
            label1.TabIndex = 11;
            label1.Text = "X";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(492, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 30);
            label3.TabIndex = 11;
            label3.Text = "W";
            // 
            // wBox
            // 
            wBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            wBox.Location = new System.Drawing.Point(523, 7);
            wBox.Name = "wBox";
            wBox.Size = new System.Drawing.Size(79, 35);
            wBox.TabIndex = 12;
            wBox.ValueChanged += wBox_ValueChanged;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(610, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(28, 30);
            label4.TabIndex = 13;
            label4.Text = "H";
            // 
            // hBox
            // 
            hBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            hBox.Location = new System.Drawing.Point(641, 7);
            hBox.Name = "hBox";
            hBox.Size = new System.Drawing.Size(82, 35);
            hBox.TabIndex = 14;
            hBox.ValueChanged += hBox_ValueChanged;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(885, 10);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(25, 30);
            label5.TabIndex = 11;
            label5.Text = "X";
            // 
            // destXBox
            // 
            destXBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            destXBox.Location = new System.Drawing.Point(916, 8);
            destXBox.Name = "destXBox";
            destXBox.Size = new System.Drawing.Size(79, 35);
            destXBox.TabIndex = 12;
            destXBox.ValueChanged += destXBox_ValueChanged;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(1003, 10);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(25, 30);
            label6.TabIndex = 13;
            label6.Text = "Y";
            // 
            // destYBox
            // 
            destYBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            destYBox.Location = new System.Drawing.Point(1034, 8);
            destYBox.Name = "destYBox";
            destYBox.Size = new System.Drawing.Size(82, 35);
            destYBox.TabIndex = 14;
            destYBox.ValueChanged += destYBox_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(772, 10);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(119, 30);
            label7.TabIndex = 16;
            label7.Text = "Destination";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(0, 6);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(192, 35);
            txtName.TabIndex = 17;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // chkOCR
            // 
            chkOCR.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkOCR.AutoSize = true;
            chkOCR.Location = new System.Drawing.Point(1165, 8);
            chkOCR.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            chkOCR.Name = "chkOCR";
            chkOCR.Size = new System.Drawing.Size(81, 34);
            chkOCR.TabIndex = 19;
            chkOCR.Text = "OCR";
            chkOCR.UseVisualStyleBackColor = true;
            chkOCR.CheckedChanged += chkOCR_CheckedChanged;
            // 
            // CaptureBoxEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(chkOCR);
            Controls.Add(btnDelete);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(btnWidthPointer);
            Controls.Add(hBox);
            Controls.Add(btnPointer);
            Controls.Add(destYBox);
            Controls.Add(label4);
            Controls.Add(yBox);
            Controls.Add(label6);
            Controls.Add(wBox);
            Controls.Add(label2);
            Controls.Add(destXBox);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(xBox);
            Controls.Add(label1);
            Name = "CaptureBoxEditor";
            Size = new System.Drawing.Size(1275, 50);
            ((System.ComponentModel.ISupportInitialize)yBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)xBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)wBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)hBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)destXBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)destYBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown yBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown xBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown wBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown hBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown destXBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown destYBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkOCR;
    }
}
