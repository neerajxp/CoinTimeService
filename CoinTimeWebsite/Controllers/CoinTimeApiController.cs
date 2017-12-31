using CoinTimeWebsite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static CoinTimeWebsite.Models.CoinbaseExchangeRateModel;
namespace CoinTimeWebsite.Controllers 
{
    [RoutePrefix("api/cointime")]
    public class CoinTimeApiController : ApiController
    {
        // GET api/<controller>
        [Route("GetCoinbaseExchangeRate")]
        [HttpGet]
        public string GetCoinbaseExchangeRate()
        {
            var data = CoinTimeViewModel.GetCoinbaseExchangeRate();
            var result = JsonConvert.DeserializeObject<Rootobject>(data);
            return data;  
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}