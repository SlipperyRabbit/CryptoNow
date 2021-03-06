﻿using System;

using CryptoNow.ViewModels;

using Windows.UI.Xaml.Controls;

namespace CryptoNow.Views
{
    public sealed partial class TabbedPage : Page
    {
        private TabbedViewModel ViewModel
        {
            get { return DataContext as TabbedViewModel; }
        }

        public TabbedPage()
        {
            InitializeComponent();
        }
    }
}
