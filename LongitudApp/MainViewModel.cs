
using System.ComponentModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace LongitudApp.ViewModels
{
    [QueryProperty(nameof(SelectedTab), nameof(SelectedTab))]
    public class MainViewModel : INotifyPropertyChanged
    {
        private string selectedTab;

        public event PropertyChangedEventHandler PropertyChanged;

        public string SelectedTab
        {
            get => selectedTab;
            set
            {
                selectedTab = value;
                OnPropertyChanged(nameof(SelectedTab));
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}