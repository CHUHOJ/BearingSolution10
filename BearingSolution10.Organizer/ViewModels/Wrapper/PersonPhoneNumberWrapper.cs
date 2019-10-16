using System;
using System.Collections.Generic;
using BearingSolution10.Infrastructure.Base;
using BearingSolution10.Organizer.Model;

namespace BearingSolution10.Organizer.ViewModels.Wrapper
{
    public class PersonPhoneNumberWrapper : ModelWrapper<PersonPhoneNumber>
    {
        public PersonPhoneNumberWrapper(PersonPhoneNumber model) : base(model) { }

        public string Number
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }
}

