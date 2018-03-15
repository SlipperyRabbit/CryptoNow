using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CryptoNow.Helpers;
using CryptoNow.Models;
using Newtonsoft.Json;

namespace CryptoNow.Services
{
    public static class BlockchainService
    {
        public static async Task<List<BlockchainChartValue>> GetValues()
        {
            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    Formatting = Formatting.None,
                    DateFormatHandling = DateFormatHandling.IsoDateFormat,
                    Converters = new List<JsonConverter> { new BlockChainChartJsonConverter() }
                };

                Uri uri = new Uri("https://api.blockchain.info/charts/market-price?timespan=5weeks&rollingAverage=1hours&format=json");
                HttpClient client = new HttpClient();
                HttpResponseMessage responseGet = await client.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
                var response = await responseGet.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<BlockchainChart>(response, settings);
                return data.Values;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<BlockchainChartValue>();
            }

        }
    }
}
