using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoNow.Models;
using CryptoNow.Strings;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CryptoNow.Helpers
{
    public class BlockChainChartJsonConverter : JsonConverter
    {
        private readonly Type[] _types;

        public BlockChainChartJsonConverter(params Type[] types)
        {
            _types = types;
        }

        public override bool CanConvert(Type sourceType) =>
            sourceType == typeof(BlockchainChart);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            //var charts = new ObservableCollection<BlockchainChart>();
            var token = JToken.Load(reader);
            var jo = JObject.Parse(token.ToString());
            var chart = new BlockchainChart
            {
                Status = (string)jo[Keys.BlockchainChartKey.status],
                Name = (string)jo[Keys.BlockchainChartKey.name],
                Unit = (string)jo[Keys.BlockchainChartKey.unit],
                Period = (string)jo[Keys.BlockchainChartKey.period],
                Description = (string) jo[Keys.BlockchainChartKey.description]
            };
            var values = jo[Keys.BlockchainChartKey.values];
            if (values.Type != JTokenType.Array)
                throw new JsonSerializationException("Unexpected token type: " + token.Type.ToString());
            chart.Values = new List<BlockchainChartValue>();
            foreach (var element in values)
            {
                var jv = JObject.Parse(element.ToString());
                //var date = j
                var value = new BlockchainChartValue
                {
                    X = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds((int) jv[Keys.BlockchainChartKey.x]),
                    Y = (decimal) jv[Keys.BlockchainChartKey.y]
                };
                chart.Values.Add(value);
            }
            //charts.Add(chart);
            return chart;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
