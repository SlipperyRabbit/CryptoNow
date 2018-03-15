using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using CryptoNow.Models;
using CryptoNow.Services;

using GalaSoft.MvvmLight;

namespace CryptoNow.ViewModels
{
    public class GridViewModel : ViewModelBase
    {
        public ObservableCollection<CoinMarketCap> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                //return SampleDataService.GetGridSampleData();
                var ticker = CoinMarketCapService.GetTicker();
                return ticker.Result;
            }
        }

        public ObservableCollection<CoinMarketCap> DisconnectedSource
        {
            get
            {
                var coins = new ObservableCollection<CoinMarketCap>();
                var coin = new CoinMarketCap();
                coins.Add(coin);
                return coins;
            }
        }
    }
}
