using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoNow.Strings
{
    public static partial class Keys
    {
        public const string CoinKeyToken = "CoinMarketCap";

        public static class CoinKey
        {
            public const string id = "id";
            public const string name = "name";
            public const string symbol = "symbol";
            public const string rank = "rank";
            public const string price_usd = "price_usd";
            public const string price_btc = "price_btc";
            public const string twentfourh_volume_usd = "24h_volume_usd";
            public const string market_cap_usd = "market_cap_usd";
            public const string available_supply = "available_supply";
            public const string total_supply = "total_supply";
            public const string max_supply = "max_supply";
            public const string percent_change_1h = "percent_change_1h";
            public const string percent_change_24h = "percent_change_24h";
            public const string percent_change_7d = "percent_change_7d";
            public const string last_updated = "last_updated";
        }
    }
}
