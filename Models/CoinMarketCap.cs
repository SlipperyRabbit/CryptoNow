using System;
using System.ComponentModel.DataAnnotations;

//using Telerik.Data.Core;

namespace CryptoNow.Models
{
    public class CoinMarketCap
    {
        //[Display]
        [Display(AutoGenerateField = false )]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int Rank { get; set; }
        public decimal PriceUsd { get; set; }
        public decimal PriceBtc { get; set; }
        public decimal HVolume24 { get; set; }
        public decimal MarketCapUsd { get; set; }
        public decimal AvailableSupply { get; set; }
        public decimal TotalSupply { get; set; }
        public decimal? MaxSupply { get; set; }
        public decimal PercentChange1H { get; set; }
        public decimal PercentChange24H { get; set; }
        public decimal PercentChange7D { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
