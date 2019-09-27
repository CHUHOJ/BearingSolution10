using System;
using System.Collections.Generic;
using PrismMahappTest.Infrastructure.Base;
using PrismMahappTest.Organizer.Model;

namespace PrismMahappTest.Organizer.ViewModels.Wrapper
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

