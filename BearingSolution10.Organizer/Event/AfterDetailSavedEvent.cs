using Prism.Events;

namespace BearingSolution10.Organizer.Event
{
    public class AfterDetailSavedEvent : PubSubEvent<AfterDetailSavedEventArgs> { }
    public class AfterDetailSavedEventArgs
    {
        public int Id { get; set; }
        public string DisplayMember { get; set; }
        public string ViewModelName { get; set; }
    }
}
