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
        [Display(Description = "Price BTC")]
        public decimal PriceBtc { get; set; }
        [Display(Description = "24 H Volume")]
        public decimal HVolume24 { get; set; }
        [Display(Description = "Market Cap")]
        public decimal MarketCapUsd { get; set; }
        [Display(Description = "Available Supply")]
        public decimal AvailableSupply { get; set; }
        [Display(Description = "Total Supply")]
        public decimal TotalSupply { get; set; }
        [Display(Description = "Max Supply")]
        public decimal? MaxSupply { get; set; }
        [Display(Description = "1H Percent Change")]
        public decimal PercentChange1H { get; set; }
        [Display(Description = "24H Percent Change")]
        public decimal PercentChange24H { get; set; }
        [Display(Description = "7D Percent Change")]
        public decimal PercentChange7D { get; set; }
        [Display(Description = "Last Updated")]
        public DateTime LastUpdated { get; set; }
    }
}
