
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
            this.yBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.hBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.destXBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.destYBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            btnPointer = new System.Windows.Forms.Button();
            btnWidthPointer = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destXBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destYBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPointer
            // 
            btnPointer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnPointer.AutoSize = true;
            btnPointer.Image = global::ScreenshotHud.Properties.Resources._9990f3d7247c46cae16abb679d5290dcU9dKwIJvjkFqh1mu_4;
            btnPointer.Location = new System.Drawing.Point(437, 6);
            btnPointer.Name = "btnPointer";
            btnPointer.Size = new System.Drawing.Size(37, 35);
            btnPointer.TabIndex = 15;
            btnPointer.UseVisualStyleBackColor = true;
            btnPointer.Click += new System.EventHandler(this.btnPointer_Click);
            // 
            // btnWidthPointer
            // 
            btnWidthPointer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnWidthPointer.AutoSize = true;
            btnWidthPointer.Image = global::ScreenshotHud.Properties.Resources._9990f3d7247c46cae16abb679d5290dcU9dKwIJvjkFqh1mu_4;
            btnWidthPointer.Location = new System.Drawing.Point(729, 6);
            btnWidthPointer.Name = "btnWidthPointer";
            btnWidthPointer.Size = new System.Drawing.Size(37, 35);
            btnWidthPointer.TabIndex = 15;
            btnWidthPointer.UseVisualStyleBackColor = true;
            btnWidthPointer.Click += new System.EventHandler(this.btnWidthPointer_Click);
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
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // yBox
            // 
            this.yBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.yBox.Location = new System.Drawing.Point(349, 7);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(82, 35);
            this.yBox.TabIndex = 14;
            this.yBox.ValueChanged += new System.EventHandler(this.yBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Y";
            // 
            // xBox
            // 
            this.xBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.xBox.Location = new System.Drawing.Point(231, 7);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(79, 35);
            this.xBox.TabIndex = 12;
            this.xBox.ValueChanged += new System.EventHandler(this.xBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "W";
            // 
            // wBox
            // 
            this.wBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.wBox.Location = new System.Drawing.Point(523, 7);
            this.wBox.Name = "wBox";
            this.wBox.Size = new System.Drawing.Size(79, 35);
            this.wBox.TabIndex = 12;
            this.wBox.ValueChanged += new System.EventHandler(this.wBox_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "H";
            // 
            // hBox
            // 
            this.hBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.hBox.Location = new System.Drawing.Point(641, 7);
            this.hBox.Name = "hBox";
            this.hBox.Size = new System.Drawing.Size(82, 35);
            this.hBox.TabIndex = 14;
            this.hBox.ValueChanged += new System.EventHandler(this.hBox_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(885, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            // 
            // destXBox
            // 
            this.destXBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.destXBox.Location = new System.Drawing.Point(916, 8);
            this.destXBox.Name = "destXBox";
            this.destXBox.Size = new System.Drawing.Size(79, 35);
            this.destXBox.TabIndex = 12;
            this.destXBox.ValueChanged += new System.EventHandler(this.destXBox_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1003, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "Y";
            // 
            // destYBox
            // 
            this.destYBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.destYBox.Location = new System.Drawing.Point(1034, 8);
            this.destYBox.Name = "destYBox";
            this.destYBox.Size = new System.Drawing.Size(82, 35);
            this.destYBox.TabIndex = 14;
            this.destYBox.ValueChanged += new System.EventHandler(this.destYBox_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(772, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "Destination";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(0, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 35);
            this.txtName.TabIndex = 17;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // CaptureBoxEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(btnDelete);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(btnWidthPointer);
            this.Controls.Add(this.hBox);
            this.Controls.Add(btnPointer);
            this.Controls.Add(this.destYBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.wBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.destXBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.label1);
            this.Name = "CaptureBoxEditor";
            this.Size = new System.Drawing.Size(1162, 50);
            ((System.ComponentModel.ISupportInitialize)(this.yBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destXBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destYBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
