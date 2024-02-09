using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenshotHud.Models
{
    public class Notifier<T>
    {
        public Notifier() { }
        public Notifier(Func<T> valueGetter)
        {
            GetValue = valueGetter;
        }
        private List<Action<T>> Subscribers { get; } = new List<Action<T>>();
        private Func<T> GetValue { get; }
        public void Register(Action<T> callback)
        {
            if (!Subscribers.Contains(callback))
                Subscribers.Add(callback);
            if (GetValue != null && GetValue() != null)
                callback(GetValue());
        }
        public void Unregister(Action<T> callback)
        {
            Subscribers.Remove(callback);
        }
        public void Notify()
        {
            if (GetValue == null)
                return;
            Notify(GetValue());
        }
        public void Notify(T value)
        {
            Subscribers.ForEach(f => f(value));
        }
    }
}
