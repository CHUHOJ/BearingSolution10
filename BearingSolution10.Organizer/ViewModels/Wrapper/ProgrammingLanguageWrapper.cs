using System;
using System.Collections.Generic;
using BearingSolution10.Infrastructure.Base;
using BearingSolution10.Organizer.Model;

namespace BearingSolution10.Organizer.ViewModels.Wrapper
{
    public class ProgrammingLanguageWrapper : ModelWrapper<ProgrammingLanguage>
    {
        public ProgrammingLanguageWrapper(ProgrammingLanguage model) : base(model) { }

        public int Id { get { return Model.Id; } }

        public string Name
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }
}

