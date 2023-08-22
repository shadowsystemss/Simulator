using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace Simulator.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        public RelayCommand ExitCommand { get; set; }
        public RelayCommand MinimizeCommand { get; set; }

        private int _value;
        public int Value { get => _value;
            set {
                if (_value == value) return;
                OnPropertyChanging();
                _value = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel(App app, MainWindow mainWindow)
        {
            ExitCommand = new RelayCommand(app.Shutdown);
            MinimizeCommand = new RelayCommand(() => mainWindow.WindowState = System.Windows.WindowState.Minimized);

            mainWindow.DataContext = this;
        }
    }
}
