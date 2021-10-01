using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica_EF_MVC.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(string mensaje)
        {
            if(mensaje==null)
            {
                ViewBag.Mensaje1 = "Estamos trabajando en ello...";
            }
            else
            {
                ViewBag.Mensaje1 = mensaje;
            }
            return View();
        }
    }
}