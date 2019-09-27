using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using PrismMahappTest.Organizer.Event;

namespace PrismMahappTest.Organizer.ViewModels
{
    public class NavigationItemViewModel:BindableBase
    {
        private readonly string _detailViewModelName;
        private readonly IEventAggregator _eventAggregator;

        public int Id { get; }

        private string _displayMember;
        public string DisplayMember
        {
            get { return _displayMember; }
            set { _displayMember = value; RaisePropertyChanged(); }
        }

        public ICommand OpenDetailViewCommand { get; }
        public NavigationItemViewModel(int id, string displayMember,
                 string detailViewModelName, IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            Id = id;
            DisplayMember = displayMember;
            _detailViewModelName = detailViewModelName;
            OpenDetailViewCommand = new DelegateCommand(OnOpenDetailViewExecute);
        }

        private void OnOpenDetailViewExecute()
        {
            _eventAggregator.GetEvent<OpenDetailViewEvent>()
                .Publish(new OpenDetailViewEventArgs
                {
                    Id = Id,
                    ViewModelName = _detailViewModelName
                });
        }

    }
}
