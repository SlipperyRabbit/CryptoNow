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

        public List<BlockchainChartValue> Source => BlockchainService.GetValues().Result;
    }
}
