using System.ComponentModel;
using System.Windows;
using Capstone.Core;
using Capstone.MVVM.Model;
using Capstone.MVVM.View;

namespace Capstone.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public static RelayCommand DiscoveryViewCommand { get; set; }
        private DocumentModel _document;
        public EditorViewModel Editor { get; set; }
        public FileViewModel File { get; set; } 
        public HomeViewModel HomeVM { get; set; }
        public static DiscoveryViewModel DiscoveryVM { get; set; }
        private object _currentView;
        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            _document = new DocumentModel();
            Editor = new EditorViewModel(_document);
            File = new FileViewModel(_document);
            
            CurrentView = HomeVM;
            
            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });
        }

        public void SetCurrentView(object hvm)
        {
            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });
        }
    }
}