
namespace ScreenshotHud
{
    partial class Preview
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
            this.CaptureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptureBox
            // 
            this.CaptureBox.BackColor = System.Drawing.Color.Black;
            this.CaptureBox.Location = new System.Drawing.Point(0, 0);
            this.CaptureBox.Name = "CaptureBox";
            this.CaptureBox.Size = new System.Drawing.Size(824, 536);
            this.CaptureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CaptureBox.TabIndex = 1;
            this.CaptureBox.TabStop = false;
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 536);
            this.Controls.Add(this.CaptureBox);
            this.Name = "Preview";
            this.Text = "ScreenshotHud Capture Preview";
            ((System.ComponentModel.ISupportInitialize)(this.CaptureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CaptureBox;
    }
}