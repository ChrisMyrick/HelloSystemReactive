using System;

namespace HelloSystem.Reactive.Events
{
    public class FooEventArgs : EventArgs
    {
        public string Message { get; set; }

        public FooEventArgs(string message)
        {
            Message = message;
        }
    }
}
