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
        public static Bitmap CurrentShot { get; set; }
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

        public static void Snap()
        {
            if (Screen == null)
                return;
            lock (Screen)
            {
                if (CurrentShot?.Width != Bounds.Width || CurrentShot?.Height != Bounds.Height)
                {
                    CurrentShot = new Bitmap(Bounds.Width, Bounds.Height, PixelFormat.Format32bppArgb);
                    ShotGraphics = Graphics.FromImage(CurrentShot);
                }
                ShotGraphics.CopyFromScreen(Bounds.Left, Bounds.Top, 0, 0, Bounds.Size);
                Notify();
            }
        }
    }
}
