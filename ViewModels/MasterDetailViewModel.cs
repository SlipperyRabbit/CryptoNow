using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using CryptoNow.Models;
using CryptoNow.Services;

using GalaSoft.MvvmLight;

using Microsoft.Toolkit.Uwp.UI.Controls;

namespace CryptoNow.ViewModels
{
    public class MasterDetailViewModel : ViewModelBase
    {
        //private SampleOrder _selected;

        //public SampleOrder Selected
        //{
        //    get { return _selected; }
        //    set { Set(ref _selected, value); }
        //}

        //public ObservableCollection<SampleOrder> SampleItems { get; private set; } = new ObservableCollection<SampleOrder>();
        private CoinMarketCap _selected;

        public CoinMarketCap Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }
        public ObservableCollection<CoinMarketCap> CoinItems { get; private set; } = new ObservableCollection<CoinMarketCap>();

        public MasterDetailViewModel()
        {
        }

        public async Task LoadDataAsync(MasterDetailsViewState viewState)
        {
            //SampleItems.Clear();
            CoinItems.Clear();

            //var data = await SampleDataService.GetSampleModelDataAsync();
            var data = await CoinMarketCapService.GetTicker();

            foreach (var item in data)
            {
                //SampleItems.Add(item);
                CoinItems.Add(item);
            }

            if (viewState == MasterDetailsViewState.Both)
            {
                //Selected = SampleItems.First();
                Selected = CoinItems.First();
            }
        }
    }
}
