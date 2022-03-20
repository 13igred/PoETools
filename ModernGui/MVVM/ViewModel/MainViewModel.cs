using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernGui.Core;

namespace ModernGui.MVVM.ViewModel
{
    class MainViewModel : ViewModelBase
    {

        public RelayCommand LoginViewCommand { get; set; }
        public RelayCommand GemSearchViewCommand { get; set; }
        public RelayCommand SearchItemViewCommand { get; set; }
        public RelayCommand LoadPobViewCommand { get; set; }

        public LoginViewModel LoginVm { get; set; }
        public GemSearchViewModel GemSearchVm { get; set; }
        public LoadPobViewModel LoadPobVM { get; set; }
        public SearchItemViewModel SearchItemVM { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set 
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            LoginVm = new LoginViewModel();
            GemSearchVm = new GemSearchViewModel();
            LoadPobVM = new LoadPobViewModel();
            SearchItemVM = new SearchItemViewModel();
            CurrentView = LoginVm;

            LoginViewCommand = new RelayCommand(o => 
            {
                CurrentView = LoginVm;
            }
            );

            GemSearchViewCommand = new RelayCommand(o =>
            {
                CurrentView = GemSearchVm;
            }
            );

            SearchItemViewCommand = new RelayCommand(o =>
            {
                CurrentView = SearchItemVM;
            }
            );

            LoadPobViewCommand = new RelayCommand(o =>
            {
                CurrentView = LoadPobVM;
            }
            );
        }
    }
}
