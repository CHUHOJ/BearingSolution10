using System;
using BearingSolution10.Infrastructure.Base;
using BearingSolution10.Organizer.Model;

namespace BearingSolution10.Organizer.ViewModels.Wrapper
{
    public class MeetingWrapper:ModelWrapper<Meeting>
    {
        public MeetingWrapper(Meeting model) : base(model) { }

        public int Id { get { return Model.Id; } }

        public string Title
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public DateTime DateFrom
        {
            get { return GetValue<DateTime>(); }
            set
            {
                SetValue(value);
                if (DateTo < DateFrom)
                {
                    DateTo = DateFrom;
                }
            }
        }

        public DateTime DateTo
        {
            get { return GetValue<DateTime>(); }
            set
            {
                SetValue(value);
                if (DateTo < DateFrom)
                {
                    DateFrom = DateTo;
                }
            }
        }
    }
}

