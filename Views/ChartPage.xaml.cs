using System;
using Windows.UI.Xaml;
using CryptoNow.ViewModels;

using Windows.UI.Xaml.Controls;

namespace CryptoNow.Views
{
    public sealed partial class ChartPage : Page
    {
        private ChartViewModel ViewModel
        {
            get => DataContext as ChartViewModel;
            //set => DataContext = value;
        }

        // TODO WTS: Change the chart as appropriate to your app.
        // For help see http://docs.telerik.com/windows-universal/controls/radchart/getting-started
        public ChartPage()
        {
            InitializeComponent();
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            Bindings.Update();
        }
    }
}
