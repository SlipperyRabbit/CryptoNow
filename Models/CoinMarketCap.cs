using System;
using System.ComponentModel.DataAnnotations;

//using Telerik.Data.Core;

namespace CryptoNow.Models
{
    public class CoinMarketCap
    {
        [Display(Description = "ID", AutoGenerateField = false)]
        public string Id { get; set; }
        [Display(Description = "Name")]
        public string Name { get; set; }
        [Display(Description = "Symbol")]
        public string Symbol { get; set; }
        [Display(Description = "Rank")]
        public int Rank { get; set; }
        [Display(Description = "Price USD")]
        public decimal PriceUsd { get; set; }
        public string PriceUsdFmt => PriceUsd.ToString("C");
        [Display(Description = "Price BTC")]
        public decimal PriceBtc { get; set; }
        [Display(Description = "24 H Volume")]
        public decimal HVolume24 { get; set; }
        public string HVolume24Fmt => HVolume24.ToString("C0");
        [Display(Description = "Market Cap")]
        public decimal MarketCapUsd { get; set; }
        public string MarketCapUsdFmt => MarketCapUsd.ToString("C0");
        [Display(Description = "Available Supply")]
        public decimal AvailableSupply { get; set; }
        public string AvailableSupplyFmt => AvailableSupply.ToString("N0");
        [Display(Description = "Total Supply")]
        public decimal TotalSupply { get; set; }
        public string TotalSupplyFmt => TotalSupply.ToString("N0");
        [Display(Description = "Max Supply")]
        public decimal? MaxSupply { get; set; }

        public string MaxSupplyFmt
        {
            get
            {
                if (MaxSupply == null) return string.Empty;
                return ((decimal)MaxSupply).ToString("N0");
            }
        }
        [Display(Description = "1H Percent Change")]
        public decimal PercentChange1H { get; set; }
        public string PercentChange1HFmt => PercentChange1H.ToString("P");
        [Display(Description = "24H Percent Change")]
        public decimal PercentChange24H { get; set; }
        public string PercentChange24HFmt => PercentChange24H.ToString("P");
        [Display(Description = "7D Percent Change")]
        public decimal PercentChange7D { get; set; }
        public string PercentChange7DFmt => PercentChange7D.ToString("P");
        [Display(Description = "Last Updated")]
        public DateTime LastUpdated { get; set; }
    }
}
