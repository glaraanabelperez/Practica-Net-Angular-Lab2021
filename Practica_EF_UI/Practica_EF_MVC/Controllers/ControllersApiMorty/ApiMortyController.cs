using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Practica_EF_MVC.Models;

namespace Practica_EF_MVC.Controllers
{

    public class ApiMortyController : Controller
    {
        public ApiMortyController()
                {
                }

        public ActionResult Index(string mensaje)
        {

            mensaje = mensaje == null ? ViewBag.Mensaje = "Buen Dia!!" : ViewBag.Mensaje = mensaje;
            var url = $"https://rickandmortyapi.com/api/character";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return View();
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            List<CharactersView> listChar = responseBody.MapCustomerToCustomerView();
                            return View(listChar);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                return View();
            }

            return View();
        }

       

    }

    


}

