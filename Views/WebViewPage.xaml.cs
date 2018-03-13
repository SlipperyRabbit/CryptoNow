using System;

using CryptoNow.ViewModels;

using Windows.UI.Xaml.Controls;

namespace CryptoNow.Views
{
    public sealed partial class WebViewPage : Page
    {
        private WebViewViewModel ViewModel
        {
            get { return DataContext as WebViewViewModel; }
        }

        public WebViewPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
