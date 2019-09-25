using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrismMahappTest.Infrastructure.Base
{

    /// <summary>
    /// Example wrapper
    /// </summary>
    public class PersonWrapper : ModelWrapper<Person>
    {
        public PersonWrapper(Person person) : base(person) { }
        public string Name
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string JobTitle
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }

    /// <summary>
    /// Example ViewModel
    /// </summary>
    public class ViewAViewModel : BindableBase
    {
        public ViewAViewModel(Person person)
        {
            Person = new PersonWrapper(person);
            ChangePersonCommand = new DelegateCommand(ChangePerson, () => true);
        }

        private void ChangePerson()
        {
            Person = new PersonWrapper(new Person() { Name = "New Name", JobTitle = "New Job title" });
        }

        public ICommand ChangePersonCommand { get; }

        public PersonWrapper _person;
        public PersonWrapper Person
        {
            get { return _person; }
            set { _person = value; RaisePropertyChanged(); }
        }
    }

    /// <summary>
    /// Example Model
    /// </summary>
    public class Person : IPerson
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }

        public Person()
        {
            Name = "Initial Name";
            JobTitle = "Initial Job Title";
        }
    }

    /// <summary>
    /// Example Model interface
    /// </summary>
    public interface IPerson
    {
        string Name { get; set; }
        string JobTitle { get; set; }
    }
}
