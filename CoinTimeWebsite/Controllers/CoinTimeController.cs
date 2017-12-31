using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoinTimeWebsite.Controllers
{
    public class CoinTimeController : Controller
    {
        // GET: CoinTime
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}