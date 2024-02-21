using ScreenshotHud.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ScreenshotHud
{
    public static class ShotTaker
    {
        public static Screen Screen { get; set; }
        public static Rectangle Bounds => Screen.Bounds;
        private static Bitmap currentShot;
        private static Bitmap frozenShot;
        public static Bitmap CurrentShot { get => frozenShot ?? currentShot; set => currentShot = value; }
        public static bool IsFrozen => frozenShot != null;
        public static double AspectRatio => CurrentShot.Width / (double)CurrentShot.Height;
        private static Graphics ShotGraphics { get; set; }

        public static Notifier<Bitmap> ShotNotifier { get; } = new Notifier<Bitmap>(()=>CurrentShot);

        public static void Freeze()
        {
            if (frozenShot == null)
            {
                frozenShot = currentShot.Clone(new Rectangle(0, 0, currentShot.Width, currentShot.Height), currentShot.PixelFormat);
            }
            else
            {
                frozenShot = null;
            }
        }

        public static void Snap()
        {
            if (Screen == null)
                return;
            lock (Screen)
            {
                try
                {
                    if (CurrentShot?.Width != Bounds.Width || CurrentShot?.Height != Bounds.Height)
                    {
                        frozenShot = null;
                        CurrentShot = new Bitmap(Bounds.Width, Bounds.Height, PixelFormat.Format32bppArgb);
                        ShotGraphics = Graphics.FromImage(CurrentShot);
                    }
                    ShotGraphics.CopyFromScreen(Bounds.Left, Bounds.Top, 0, 0, Bounds.Size);
                    ShotNotifier.Notify(CurrentShot);
                }
                catch { }
            }
        }
    }
}
