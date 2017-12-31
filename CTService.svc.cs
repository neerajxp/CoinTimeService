using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace CoinTimeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CTService : ICTSerrvice
    {
        public async Task<string> GetCoinbaseExchangeRate()
        {
            using (HttpClient Client = new HttpClient())
            {
                string url = @"https://api.coinbase.com/v2/exchange-rates";
                HttpClient client = new HttpClient();
                var response = await client.GetStringAsync(new Uri(url));
                //var result = JsonConvert.DeserializeObject <RootObject>
                return response;
            }
        }
    }
}
