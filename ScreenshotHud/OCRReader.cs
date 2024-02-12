using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Globalization;
using Windows.Graphics.Imaging;
using Windows.Media.Ocr;

namespace ScreenshotHud
{
    public static class OCRReader
    {
        private static readonly Language ocrLanguage = new("en");
        private static OcrEngine ocrEngine { get => OcrEngine.TryCreateFromLanguage(ocrLanguage); }

        public static async Task<string> Scan(Bitmap bitmap)
        {
            using var stream = new Windows.Storage.Streams.InMemoryRandomAccessStream();
            bitmap.Save(stream.AsStream(), ImageFormat.Bmp);
            BitmapDecoder decoder = await BitmapDecoder.CreateAsync(stream);
            SoftwareBitmap softwareBitmap = await decoder.GetSoftwareBitmapAsync();
            var ocrResult = await ocrEngine.RecognizeAsync(softwareBitmap);
            return ocrResult?.Text ?? "";
        }
    }
}
