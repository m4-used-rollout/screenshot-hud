using ScreenshotHud.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenshotHud
{
    public class TextLog : IDisposable
    {
        private readonly Dictionary<string, (DateTime Time, string Text)> activeCaptures = [];
        private Task previousTask = Task.FromResult(true);
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

        private Task QueueTask(Action action)
        {
            lock (activeCaptures)
            {
                previousTask = previousTask.ContinueWith(
                  t => action(),
                  CancellationToken.None,
                  TaskContinuationOptions.None,
                  TaskScheduler.Default);
                return previousTask;
            }
        }

        public string LastDetectedText(CaptureBox box)
        {
            lock (activeCaptures)
            {
                return activeCaptures.GetValueOrDefault(box.Name).Text;
            }
        }
        public void FindAndLogText(CaptureBox box)
        {
            var lastCapture = (box.Name, DateTime.UtcNow, box.LastCapture.Clone() as Bitmap);
            QueueTask(async () =>
            {
                try
                {
                    var text = await OCRReader.Scan(lastCapture.Item3);
                    var last = activeCaptures.GetValueOrDefault(lastCapture.Name);
                    lastCapture.Item3.Dispose();

                    if (!string.IsNullOrWhiteSpace(last.Text))
                    {
                        if (text?.Contains(last.Text) ?? false)
                        {
                            // Got more characters from existing capture
                            last.Text = text;
                            activeCaptures[lastCapture.Name] = last;
                            return;
                        }
                        // Flush existing capture
                        WriteLogEntry(last.Time, lastCapture.Name, last.Text);
                    }
                    if (!string.IsNullOrWhiteSpace(text))
                    {
                        // Start new capture
                        last.Time = lastCapture.UtcNow;
                        last.Text = text;
                        activeCaptures[lastCapture.Name] = last;
                    }
                    else
                        activeCaptures.Remove(lastCapture.Name);
                }
                catch { }
            });
        }
        public void Flush(CaptureBox box)
        {
            var boxToFlush = box.Name;

            QueueTask(() =>
            {
                try
                {
                    var last = activeCaptures.GetValueOrDefault(box.Name);
                    if (!string.IsNullOrWhiteSpace(last.Text))
                    {
                        WriteLogEntry(last.Time, box.Name, last.Text);
                    }
                    activeCaptures.Remove(box.Name);
                }
                catch { }
            });
        }

        private void WriteLogEntry(DateTime time, string title, string text)
        {
            try
            {
                Writer.WriteLine($"{time:O} {title}: \"{text}\"");
                Writer.Flush();
            }
            catch { }
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
