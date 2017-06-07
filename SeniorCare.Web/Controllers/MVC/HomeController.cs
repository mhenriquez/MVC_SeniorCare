using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using SeniorCare.Web.Models;
using System.Data.SqlClient;
using System.Net;

namespace SeniorCare.Web.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration = 60, VaryByParam = "none", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult Index()
        {
            ViewBag.Title = "Home";

            return View();
        }
    }
}
