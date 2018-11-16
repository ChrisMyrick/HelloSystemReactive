using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace HelloSystem.Reactive.Events
{
    public class EventAggregator : IEventAggregator
    {
        private bool _disposed;
        private readonly Subject<object> _subject = new Subject<object>();

        /// <summary>
        /// Subscribes a custom event to a method
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="method"></param>
        /// <returns>Disposable event subscription</returns>
        public IDisposable Subscribe<TEvent>(Action<TEvent> method)
        {
            return _subject.OfType<TEvent>()
                .AsObservable()
                .Subscribe(method);
        }

        /// <summary>
        /// Publishes custom event
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="evt"></param>
        public void Publish<TEvent>(TEvent evt)
        {
            _subject.OnNext(evt);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            _subject.Dispose();

            _disposed = true;
        }
    }
}
