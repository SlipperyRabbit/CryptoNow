using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoNow.Models;
using CryptoNow.Strings;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CryptoNow.Helpers
{
    //[TypeConverter(typeof(CoinMarketCapTypeConverter))]
    //public class CoinMarketCapConverter
    //{
    //}

    //public class CoinMarketCapTypeConverter : TypeConverter
    //{
    //    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) =>
    //        sourceType == typeof(JObject) || base.CanConvertFrom(context, sourceType);

    //    public CoinMarketCap ConvertFromJson(ITypeDescriptorContext context, CultureInfo culture, JObject value)
    //    {
    //        var jo = (JObject) value;
    //        var coin = new CoinMarketCap
    //        {
    //            Id = (string) jo["id"],
    //            Name = (string) jo["name"],
    //            Symbol = (string) jo["sybol"],
    //            PriceUsd = (decimal)jo["price_usd"]
    //        };
    //        return coin;
    //    }
    //}
    public class CoinMarketCapJsonConverter : JsonConverter
    {
        private readonly Type[] _types;

        public CoinMarketCapJsonConverter(params Type[] types)
        {
            _types = types;
        }

        public override bool CanConvert(Type sourceType) =>
            sourceType == typeof(ObservableCollection<CoinMarketCap>);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var coins = new ObservableCollection<CoinMarketCap>();
            var token = JToken.Load(reader);
            if (token.Type != JTokenType.Array)
                throw new JsonSerializationException("Unexpected token type: " + token.Type.ToString());

            foreach (var element in token)
            {
                var jo = JObject.Parse(element.ToString());
                var coin = new CoinMarketCap
                {
                    Id = (string)jo[Keys.CoinKey.id],
                    Name = (string)jo[Keys.CoinKey.name],
                    Symbol = (string)jo[Keys.CoinKey.symbol],
                    Rank = (int)jo[Keys.CoinKey.rank],
                    PriceUsd = (decimal)jo[Keys.CoinKey.price_usd],
                    PriceBtc = (decimal)jo[Keys.CoinKey.price_btc],
                    HVolume24 = (decimal)jo[Keys.CoinKey.twentfourh_volume_usd],
                    MarketCapUsd = (decimal)jo[Keys.CoinKey.market_cap_usd],
                    AvailableSupply = (decimal)jo[Keys.CoinKey.available_supply],
                    TotalSupply = (decimal)jo[Keys.CoinKey.total_supply],
                    MaxSupply = (decimal?)jo[Keys.CoinKey.max_supply],
                    PercentageChange1H = (decimal)jo[Keys.CoinKey.percent_change_1h],
                    PercentageChange24H = (decimal)jo[Keys.CoinKey.percent_change_24h],
                    PercentageChange7D = (decimal)jo[Keys.CoinKey.percent_change_7d],
                    LastUpdated = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds((int)jo[Keys.CoinKey.last_updated])
                };
                coins.Add(coin);
            }

            return coins;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }

}
