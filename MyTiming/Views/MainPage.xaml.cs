using System;

using MyTiming.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MyTiming.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
