using Microsoft.Maui.Controls;

namespace LongitudApp.Views
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            Children.Add(new KmToMPage());
            Children.Add(new MToCmPage());
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}