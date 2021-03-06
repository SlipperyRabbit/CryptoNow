﻿using System;

using CryptoNow.ViewModels;

using Windows.UI.Xaml.Controls;

namespace CryptoNow.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
