using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using PrismMahappTest.Infrastructure.Services;
using PrismMahappTest.Organizer.Event;

namespace PrismMahappTest.Organizer.ViewModels
{
    public class OrganizerMainViewModel : BindableBase
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly IDetailedViewModelFactory _detailViewModelFactory;
        private readonly IMessageDialogService _messageDialogService;
        public ObservableCollection<IDetailViewModel> DetailViewModels { get; }

        public ICommand CreateNewDetailCommand { get; }
        public ICommand OpenSingleDetailViewCommand { get; }
        public INavigationViewModel NavigationViewModel { get; }

        private IDetailViewModel _selectedDetailViewModel;
        public IDetailViewModel SelectedDetailViewModel
        {
            get { return _selectedDetailViewModel; }
            set
            {
                _selectedDetailViewModel = value;
                RaisePropertyChanged();
            }
        }
        public OrganizerMainViewModel(INavigationViewModel navigationViewModel,
            IDetailedViewModelFactory detailViewModelFactory,
            IEventAggregator eventAggregator,
            IMessageDialogService messageDialogService)
        {
            _eventAggregator = eventAggregator;
            _detailViewModelFactory = detailViewModelFactory;
            _messageDialogService = messageDialogService;

            DetailViewModels = new ObservableCollection<IDetailViewModel>();

            _eventAggregator.GetEvent<OpenDetailViewEvent>()
                .Subscribe(OnOpenDetailView);
            _eventAggregator.GetEvent<AfterDetailDeletedEvent>()
                .Subscribe(AfterDetailDeleted);
            _eventAggregator.GetEvent<AfterDetailClosedEvent>()
                .Subscribe(AfterDetailClosed);

            CreateNewDetailCommand = new DelegateCommand<Type>(OnCreateNewDetailExecute);
            OpenSingleDetailViewCommand = new DelegateCommand<Type>(OnOpenSingleDetailViewExecute);

            NavigationViewModel = navigationViewModel;
        }

        public async Task LoadAsync()
        {
            await NavigationViewModel.LoadAsync();
        }

        private async void OnOpenDetailView(OpenDetailViewEventArgs args)
        {
            var detailViewModel = DetailViewModels.SingleOrDefault(x => x.Id == args.Id
            && x.GetType().Name == args.ViewModelName);

            if (detailViewModel == null)
            {
                detailViewModel = _detailViewModelFactory.GetDetailViewModel(args.ViewModelName);

                try
                {
                    await detailViewModel.LoadAsync(args.Id);
                }
                catch
                {
                    await _messageDialogService.ShowInfoDialogAsync("Could not load the entity, " +
                        "maybe it was deleted in the meantime by another user." +
                        "The navigation is refreshed of you.");
                    await NavigationViewModel.LoadAsync();
                    return;
                }
                DetailViewModels.Add(detailViewModel);

                
            }

            SelectedDetailViewModel = detailViewModel;
        }

        private int nextNewItemId = 0;
        private void OnCreateNewDetailExecute(Type viewModelType)
        {
            OnOpenDetailView(
                new OpenDetailViewEventArgs
                {
                    Id = nextNewItemId--,
                    ViewModelName = viewModelType.Name
                });
        }

        private void OnOpenSingleDetailViewExecute(Type viewModelType)
        {
            OnOpenDetailView(
                new OpenDetailViewEventArgs
                {
                    Id = -1,
                    ViewModelName = viewModelType.Name
                });
        }

        private void AfterDetailDeleted(AfterDetailDeletedEventArgs args)
        {
            RemoveDetailViewModel(args.Id, args.ViewModelName);
        }

        private void AfterDetailClosed(AfterDetailClosedEventArgs args)
        {
            RemoveDetailViewModel(args.Id, args.ViewModelName);
        }

        private void RemoveDetailViewModel(int id, string viewModelName)
        {
            var detailViewModel = DetailViewModels.SingleOrDefault(x => x.Id == id
            && x.GetType().Name == viewModelName);

            if (detailViewModel != null)
            {
                DetailViewModels.Remove(detailViewModel);
            }
        }
    }
}
