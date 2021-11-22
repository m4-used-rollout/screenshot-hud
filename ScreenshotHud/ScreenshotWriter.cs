using ScreenshotHud.Models;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ScreenshotHud
{
    public static class ScreenshotWriter
    {
        public static void WriteScreenshot(Bitmap screenshot, string filename)
        {
            var path = $"{Program.Config.ScreenshotFolder}\\{filename}-{DateTime.UtcNow.ToString("o").Replace(':','-')}.png";
            if (path.StartsWith("~"))
                path = Application.StartupPath + path[1..];
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            File.WriteAllText(path, DateTime.UtcNow.ToString("o"));
            screenshot.Clone(new Rectangle(0, 0, screenshot.Width, screenshot.Height), PixelFormat.Format32bppRgb).Save(path, ImageFormat.Png);
        }
    }
}
