using CoinTimeWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoinTimeWebsite.Controllers 
{
    [RoutePrefix("api/cointime")]
    public class CTApiController : ApiController
    {
        // GET api/<controller>
        [Route("")]
        [HttpGet]
        public string GetCoinbaseExchangeRate()
        {
            var data = FeedsViewModel.GetCoinbaseExchangeRate();
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