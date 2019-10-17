using Prism.Events;

namespace BearingSolution10.Infrastructure.Event
{
    public class AfterDetailClosedEvent : PubSubEvent<AfterDetailClosedEventArgs> { }

    public class AfterDetailClosedEventArgs
    {
        public int Id { get; set; }
        public string ViewModelName { get; set; }
    }
}
