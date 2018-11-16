using HelloSystem.Reactive.Events;
using System;
using System.Windows.Forms;

namespace HelloSystem.Reactive
{
    public partial class FormMain : Form
    {
        private IEventAggregator _eventAggregator = new EventAggregator();

        public FormMain()
        {
            InitializeComponent();
        }

        private void OnFooEventReceived(FooEventArgs evt)
        {
            MessageBox.Show("A subscriber sent the following message: " + evt.Message, "An Event Occurred");
        }

        private void BtnSubscribe_Click(object sender, EventArgs e)
        {
            _eventAggregator.Subscribe<FooEventArgs>(OnFooEventReceived);
        }

        private void BtnPublish_Click(object sender, EventArgs e)
        {
            var publishedEvent = new FooEventArgs("Hello from the event.");
            _eventAggregator.Publish(publishedEvent);
        }
    }
}
