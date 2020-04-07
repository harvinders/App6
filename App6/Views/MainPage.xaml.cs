using System;

using App6.ViewModels;

using Windows.UI.Xaml.Controls;

namespace App6.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
