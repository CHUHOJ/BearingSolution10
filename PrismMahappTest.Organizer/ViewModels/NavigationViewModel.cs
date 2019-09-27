using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using Prism.Mvvm;
using PrismMahappTest.Organizer.Data.Lookups;
using PrismMahappTest.Organizer.Event;

namespace PrismMahappTest.Organizer.ViewModels
{
    public class NavigationViewModel : BindableBase, INavigationViewModel
    {
        private readonly IPersonLookupDataService _personLookupService;
        private readonly IEventAggregator _eventAggregator;
        private readonly IMeetingLookupDataService _meetingLookupDataService;

        public ObservableCollection<NavigationItemViewModel> Persons { get; }
        public ObservableCollection<NavigationItemViewModel> Meetings { get; }

        public NavigationViewModel(IPersonLookupDataService personLookupService,
            IEventAggregator eventAggregator, IMeetingLookupDataService meetingLookupDataService)
        {
            _personLookupService = personLookupService;
            _eventAggregator = eventAggregator;
            _meetingLookupDataService = meetingLookupDataService;
            Persons = new ObservableCollection<NavigationItemViewModel>();
            Meetings = new ObservableCollection<NavigationItemViewModel>();
            _eventAggregator.GetEvent<AfterDetailSavedEvent>().Subscribe(AfterDetailSaved);
            _eventAggregator.GetEvent<AfterDetailDeletedEvent>().Subscribe(AfterDetailDeleted);
        }
        public async Task LoadAsync()
        {
            var lookup = await _personLookupService.GetPersonLookupAsync();
            Persons.Clear();
            foreach (var item in lookup)
            {
                Persons.Add(new NavigationItemViewModel(item.Id, item.DisplayMember,
                    nameof(PersonDetailViewModel), _eventAggregator));
            }

            lookup = await _meetingLookupDataService.GetMeetingLookupAsync();
            Meetings.Clear();
            foreach (var item in lookup)
            {
                Meetings.Add(new NavigationItemViewModel(item.Id, item.DisplayMember,
                    nameof(MeetingDetailViewModel), _eventAggregator));
            }
        }

        private void AfterDetailSaved(AfterDetailSavedEventArgs args)
        {
            switch (args.ViewModelName)
            {
                case nameof(PersonDetailViewModel):
                    AfterDetailsSaved(Persons, args);
                    break;
                case nameof(MeetingDetailViewModel):
                    AfterDetailsSaved(Meetings, args);
                    break;
            }
        }

        private void AfterDetailsSaved(ObservableCollection<NavigationItemViewModel> items, AfterDetailSavedEventArgs args)
        {
            var lookupItem = items.SingleOrDefault(x => x.Id == args.Id);
            if (lookupItem == null)
            {
                items.Add(new NavigationItemViewModel(args.Id, args.DisplayMember,
                    args.ViewModelName, _eventAggregator));
            }
            else
            {
                lookupItem.DisplayMember = args.DisplayMember;
            }
        }

        private void AfterDetailDeleted(AfterDetailDeletedEventArgs args)
        {
            switch (args.ViewModelName)
            {
                case nameof(PersonDetailViewModel):
                    AfterDetailDeleted(Persons, args);
                    break;
                case nameof(MeetingDetailViewModel):
                    AfterDetailDeleted(Meetings, args);
                    break;
            }
        }

        private void AfterDetailDeleted(ObservableCollection<NavigationItemViewModel> items, AfterDetailDeletedEventArgs args)
        {
            var item = items.SingleOrDefault(x => x.Id == args.Id);
            if (item != null)
            {
                items.Remove(item);
            }
        }
    }
}
