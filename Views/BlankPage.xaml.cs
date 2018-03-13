using System;

using CryptoNow.ViewModels;

using Windows.UI.Xaml.Controls;

namespace CryptoNow.Views
{
    public sealed partial class BlankPage : Page
    {
        private BlankViewModel ViewModel
        {
            get { return DataContext as BlankViewModel; }
        }

        public BlankPage()
        {
            InitializeComponent();
        }
    }
}
