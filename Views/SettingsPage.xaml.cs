﻿using System;

using CryptoNow.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CryptoNow.Views
{
    // TODO WTS: Change the URL for your privacy policy in the Resource File, currently set to https://YourPrivacyUrlGoesHere
    public sealed partial class SettingsPage : Page
    {
        private SettingsViewModel ViewModel
        {
            get { return DataContext as SettingsViewModel; }
        }

        public SettingsPage()
        {
            InitializeComponent();
            ViewModel.Initialize();
        }
    }
}
