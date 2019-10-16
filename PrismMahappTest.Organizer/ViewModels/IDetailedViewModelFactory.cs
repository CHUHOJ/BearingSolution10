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
        Func<ProgrammingLanguageDetailViewModel> _programLanguageDetailVMCreator;
        Func<PersonDetailViewModel> _personDetailVMCreator;
        Func<MeetingDetailViewModel> _meetingDetailVMCreator;

        public DetailViewModelFactory(Func<ProgrammingLanguageDetailViewModel> programLanguageDetailVMCreator, Func<PersonDetailViewModel> personDetailVMCreator, Func<MeetingDetailViewModel> meetingDetailVMCreator)
        {
            _programLanguageDetailVMCreator=programLanguageDetailVMCreator;
            _personDetailVMCreator=personDetailVMCreator;
            _meetingDetailVMCreator=meetingDetailVMCreator;
        }
        public IDetailViewModel GetDetailViewModel(string viewModelName)
        {
            IDetailViewModel vm;
            switch (viewModelName)
            {

                case nameof(ProgrammingLanguageDetailViewModel):
                    vm = _programLanguageDetailVMCreator();
                    break;
                case nameof(PersonDetailViewModel):
                    vm = _personDetailVMCreator();
                    break;
                case nameof(MeetingDetailViewModel):
                    vm = _meetingDetailVMCreator();
                    break;
                default:
                    vm = null;
                    break;
            }

            return vm;
        }

        }
}
