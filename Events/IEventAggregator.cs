using System;

namespace HelloSystem.Reactive.Events
{
    public interface IEventAggregator : IDisposable
    {
        IDisposable Subscribe<TEvent>(Action<TEvent> method);
        void Publish<TEvent>(TEvent evt);
    }
}
