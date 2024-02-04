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
        public static double AspectRatio => CurrentShot.Width / (double)CurrentShot.Height;
        private static Graphics ShotGraphics { get; set; }

        private static List<Action<Bitmap>> ShotUpdateCallbacks { get; } = new List<Action<Bitmap>>();

        public static void Register(Action<Bitmap> callback)
        {
            if (!ShotUpdateCallbacks.Contains(callback))
                ShotUpdateCallbacks.Add(callback);
            if (CurrentShot != null)
                callback(CurrentShot);
        }

        public static void Unregister(Action<Bitmap> callback)
        {
            ShotUpdateCallbacks.Remove(callback);
        }

        private static void Notify()
        {
            ShotUpdateCallbacks.ForEach(f => f(CurrentShot));
        }

        public static void Freeze()
        {
            if (frozenShot == null)
            {
                frozenShot = currentShot.Clone(new Rectangle(0, 0, currentShot.Width, currentShot.Height), currentShot.PixelFormat);
            }
            else
            {
                frozenShot.Dispose();
                frozenShot = null;
            }
        }

        public static void Snap()
        {
            if (Screen == null)
                return;
            lock (Screen)
            {
                if (CurrentShot?.Width != Bounds.Width || CurrentShot?.Height != Bounds.Height)
                {
                    frozenShot = null;
                    CurrentShot = new Bitmap(Bounds.Width, Bounds.Height, PixelFormat.Format32bppArgb);
                    ShotGraphics = Graphics.FromImage(CurrentShot);
                }
                ShotGraphics.CopyFromScreen(Bounds.Left, Bounds.Top, 0, 0, Bounds.Size);
                Notify();
            }
        }
    }
}
