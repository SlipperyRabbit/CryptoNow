using System;

namespace CryptoNow.Models
{
    public class CoinMarketCap
    {
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
        public decimal PercentageChange1H { get; set; }
        public decimal PercentageChange24H { get; set; }
        public decimal PercentageChange7D { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
