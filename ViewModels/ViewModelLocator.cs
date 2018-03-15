using System;
using CommonServiceLocator;
using CryptoNow.Services;
using CryptoNow.Views;

using GalaSoft.MvvmLight.Ioc;

//using Microsoft.Practices.ServiceLocation;

namespace CryptoNow.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            Register<PivotViewModel, PivotPage>();
            //Register<MainViewModel, MainPage>();
            //Register<BlankViewModel, BlankPage>();
            //Register<TabbedViewModel, TabbedPage>();
            Register<WebViewViewModel, WebViewPage>();
            Register<GridViewModel, GridPage>();
            Register<ChartViewModel, ChartPage>();
            Register<MasterDetailViewModel, MasterDetailPage>();
            Register<SettingsViewModel, SettingsPage>();
        }

        public SettingsViewModel SettingsViewModel => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        public MasterDetailViewModel MasterDetailViewModel => ServiceLocator.Current.GetInstance<MasterDetailViewModel>();

        public ChartViewModel ChartViewModel => ServiceLocator.Current.GetInstance<ChartViewModel>();

        public GridViewModel GridViewModel => ServiceLocator.Current.GetInstance<GridViewModel>();

        public WebViewViewModel WebViewViewModel => ServiceLocator.Current.GetInstance<WebViewViewModel>();

        //public TabbedViewModel TabbedViewModel => ServiceLocator.Current.GetInstance<TabbedViewModel>();

        //public BlankViewModel BlankViewModel => ServiceLocator.Current.GetInstance<BlankViewModel>();

        //public MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();

        public PivotViewModel PivotViewModel => ServiceLocator.Current.GetInstance<PivotViewModel>();

        public NavigationServiceEx NavigationService => ServiceLocator.Current.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
