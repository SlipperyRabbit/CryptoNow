using System;

using CryptoNow.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CryptoNow.Views
{
    public sealed partial class MasterDetailDetailControl : UserControl
    {
        public CoinMarketCap TickerItem
        {
            get { return GetValue(TickerItemProperty) as CoinMarketCap; }
            set { SetValue(TickerItemProperty, value); }
        }

        public static readonly DependencyProperty TickerItemProperty = DependencyProperty.Register("TickerItem", typeof(CoinMarketCap), typeof(MasterDetailDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public MasterDetailDetailControl()
        {
            InitializeComponent();
        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as MasterDetailDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
