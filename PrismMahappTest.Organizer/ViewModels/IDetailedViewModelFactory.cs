using Prism.Events;
using PrismMahappTest.Infrastructure.Services;
using PrismMahappTest.Organizer.Data.Repositories;
using PrismMahappTest.Organizer.Data.Lookups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismMahappTest.Organizer.ViewModels
{
    public interface IDetailedViewModelFactory
    {
        IDetailViewModel GetDetailViewModel(string viewModelName);
    }

    public class DetailViewModelFactory : IDetailedViewModelFactory
    {
        IEventAggregator eventAggregator;
        IMessageDialogService messageDialogService;
        IProgrammingLanguageRepository programmingLanguageRepository;
        IPersonRepository personRepository;
        IMeetingRepository meetingRepository;
        IProgrammingLanguageDataService programmingLanguageDataService;
        public DetailViewModelFactory(IEventAggregator eventAggregator,
            IMessageDialogService messageDialogService,IProgrammingLanguageRepository programmingLanguageRepository, 
            IPersonRepository personRepository, IMeetingRepository meetingRepository, IProgrammingLanguageDataService programmingLanguageDataService)
        {
            this.eventAggregator = eventAggregator;
            this.messageDialogService = messageDialogService;
            this.programmingLanguageRepository = programmingLanguageRepository;
            this.personRepository = personRepository;
            this.meetingRepository = meetingRepository;
            this.programmingLanguageDataService = programmingLanguageDataService;
        }
        public IDetailViewModel GetDetailViewModel(string viewModelName)
        {
            IDetailViewModel vm;
            switch (viewModelName)
            {

                case nameof(ProgrammingLanguageDetailViewModel):
                    vm = new ProgrammingLanguageDetailViewModel(eventAggregator, messageDialogService, programmingLanguageRepository);
                    break;
                case nameof(PersonDetailViewModel):
                    vm = new PersonDetailViewModel(personRepository, eventAggregator, messageDialogService, programmingLanguageDataService);
                    break;
                case nameof(MeetingDetailViewModel):
                    vm = new MeetingDetailViewModel(eventAggregator, messageDialogService, meetingRepository);
                    break;
                default:
                    vm = null;
                    break;
            }

            return vm;
        }

        }
}
