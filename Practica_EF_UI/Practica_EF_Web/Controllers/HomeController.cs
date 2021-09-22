using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica_EF_Entities;
using Practica_EF_Data;

namespace Practica_EF_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}


