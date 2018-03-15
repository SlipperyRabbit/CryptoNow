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
    public static class CoinMarketCapService
    {
        public static async Task<ObservableCollection<CoinMarketCap>> GetTicker()
        {

            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    Formatting = Formatting.None,
                    DateFormatHandling = DateFormatHandling.IsoDateFormat,
                    Converters = new List<JsonConverter> { new CoinMarketCapJsonConverter()}
                };
                
                Uri uri = new Uri("https://api.coinmarketcap.com/v1/ticker/");
                HttpClient client = new HttpClient();
                HttpResponseMessage responseGet = await client.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
                var response = await responseGet.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ObservableCollection<CoinMarketCap>>(response, settings);
                //var list = JsonConvert.DeserializeObject<ObservableCollection<CoinMarketCap>>(response, settings).OrderBy(t => t.Rank);
                //return new ObservableCollection<CoinMarketCap>(list);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new ObservableCollection<CoinMarketCap>();
            }
        }
    }
}
