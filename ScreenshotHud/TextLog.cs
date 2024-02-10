using ScreenshotHud.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenshotHud
{
    public class TextLog : IDisposable
    {
        private readonly Dictionary<string, (DateTime Time, string Text)> activeCaptures = [];
        private bool disposedValue;

        private FileStream _file;
        private StreamWriter _writer;
        private FileStream LogFile
        {
            get
            {
                if (_file == null)
                {
                    var path = Program.Config.TextLogFileName;
                    if (path.StartsWith("~"))
                        path = Application.StartupPath + path[1..];
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                    _file = File.Open(path, FileMode.Append, FileAccess.Write, FileShare.Read);
                }
                return _file;
            }
        }
        private StreamWriter Writer { get => _writer ??= new(LogFile); }

        public string LastDetectedText(CaptureBox box) => activeCaptures.GetValueOrDefault(box.Name).Text;
        public void FindAndLogText(CaptureBox box)
        {
            var lastCapture = box.LastCapture.Clone() as Bitmap;
            new Task(() =>
            {
                lock (activeCaptures)
                {
                    var text = OCRReader.Scan(lastCapture).Result;
                    var last = activeCaptures.GetValueOrDefault(box.Name);
                    lastCapture.Dispose();

                    if (!string.IsNullOrWhiteSpace(last.Text))
                    {
                        if (text?.Contains(last.Text) ?? false)
                        {
                            // Got more characters from existing capture
                            last.Text = text;
                            activeCaptures[box.Name] = last;
                            return;
                        }
                        // Flush existing capture
                        WriteLogEntry(last.Time, box.Name, last.Text);
                    }
                    if (!string.IsNullOrWhiteSpace(text))
                    {
                        // Start new capture
                        last.Time = DateTime.UtcNow;
                        last.Text = text;
                        activeCaptures[box.Name] = last;
                    }
                    else
                        activeCaptures.Remove(box.Name);
                }
            }).Start();
        }
        public void Flush(CaptureBox box)
        {
            lock (activeCaptures)
            {
                var last = activeCaptures.GetValueOrDefault(box.Name);
                if (!string.IsNullOrWhiteSpace(last.Text))
                {
                    WriteLogEntry(last.Time, box.Name, last.Text);
                }
                activeCaptures.Remove(box.Name);
            }
        }

        private void WriteLogEntry(DateTime time, string title, string text)
        {
            Writer.WriteLine($"{time:O} {title}: \"{text}\"");
            Writer.Flush();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _writer?.Flush();
                    _file?.Flush();
                    _writer?.Dispose();
                    _file?.Dispose();
                }
                activeCaptures.Clear();
                disposedValue = true;
            }
        }

        ~TextLog()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
