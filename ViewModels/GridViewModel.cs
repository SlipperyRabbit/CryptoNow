using System;
using System.Collections.ObjectModel;

using CryptoNow.Models;
using CryptoNow.Services;

using GalaSoft.MvvmLight;

namespace CryptoNow.ViewModels
{
    public class GridViewModel : ViewModelBase
    {
        public ObservableCollection<SampleOrder> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetGridSampleData();
            }
        }
    }
}
