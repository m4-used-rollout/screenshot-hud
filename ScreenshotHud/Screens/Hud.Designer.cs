
namespace ScreenshotHud.Screens
{
    partial class Hud
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
            this.OverlayBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OverlayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OverlayBox
            // 
            this.OverlayBox.BackColor = System.Drawing.Color.Black;
            this.OverlayBox.Location = new System.Drawing.Point(0, 0);
            this.OverlayBox.MinimumSize = new System.Drawing.Size(300, 64);
            this.OverlayBox.Name = "OverlayBox";
            this.OverlayBox.Size = new System.Drawing.Size(300, 64);
            this.OverlayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OverlayBox.TabIndex = 2;
            this.OverlayBox.TabStop = false;
            this.OverlayBox.Click += new System.EventHandler(this.OverlayBox_Click);
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(298, 64);
            this.Controls.Add(this.OverlayBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Overlay";
            this.Text = "ScreenshotHud HUD";
            ((System.ComponentModel.ISupportInitialize)(this.OverlayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OverlayBox;
    }
}