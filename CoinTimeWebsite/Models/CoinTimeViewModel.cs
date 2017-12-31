using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static CoinTimeWebsite.Models.CoinbaseExchangeRateModel;

namespace CoinTimeWebsite.Models
{
    public static class CoinTimeViewModel
    {
        public static string GetCoinbaseExchangeRate()
        {
            CoinTimeService.CTSerrviceClient proxy = new CoinTimeService.CTSerrviceClient();
            var data = proxy.GetCoinbaseExchangeRate();
            //var result = JsonConvert.DeserializeObject<Rootobject>(data);
            return data;
        }
    }
}