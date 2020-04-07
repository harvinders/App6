using System;

using App6.ViewModels;

using Windows.UI.Xaml.Controls;

namespace App6.Views
{
    public sealed partial class BlankPage : Page
    {
        public BlankViewModel ViewModel { get; } = new BlankViewModel();

        public BlankPage()
        {
            InitializeComponent();
        }
    }
}
