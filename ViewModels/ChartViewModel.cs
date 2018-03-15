using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using CryptoNow.Models;
using CryptoNow.Services;

using GalaSoft.MvvmLight;

namespace CryptoNow.ViewModels
{
    public class ChartViewModel : ViewModelBase
    {
        public ChartViewModel()
        {
        }

        public List<BlockchainChartValue> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                //return SampleDataService.GetChartSampleData();
                return BlockchainService.GetValues().Result;
            }
        }
    }
}
