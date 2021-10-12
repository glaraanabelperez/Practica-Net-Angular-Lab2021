using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Practica_EF_Logic.Practica.EF.Logic.APIMory;
using Practica_EF_MVC.Models;

namespace Practica_EF_MVC.Controllers
{

    public class ApiMortyController : Controller
    {
        public ApiMortyLogic logic = new ApiMortyLogic();

        public ApiMortyController()
                {
                }

        public ActionResult Index(string mensaje)
        {
            mensaje = mensaje == null ? ViewBag.Mensaje = "Bienvenido a la api de Morty!!" : ViewBag.Mensaje = mensaje;

            List<CharactersView> listChar;
            string logicRequest;
            try
            {
                logicRequest = logic.RequestDataApiMorty();
                listChar = logicRequest.SetCharactersViewOfJsonMorty();
                return View(listChar);

            }
            catch (WebException e)
            {
                return RedirectToAction("Index", "Error", new { mensaje = e.Message });
            }
            catch (NotSupportedException e)
            {
                return RedirectToAction("Index", "Error", new { mensaje = e.Message });
            }

            //List<CharactersView> listChar;

            //ViewBag.Mensaje = mensaje == null ? ViewBag.Mensaje = "Api Morty!!" : ViewBag.Mensaje = mensaje;
            //var url = $"https://rickandmortyapi.com/api/character/[1,2,3,4,5,6,7,8]";
            //var request = (HttpWebRequest)WebRequest.Create(url);
            //request.Method = "GET";
            //request.ContentType = "application/json";
            //request.Accept = "application/json";

            //try
            //{
            //    using (WebResponse response = request.GetResponse())
            //    {
            //        using (Stream strReader = response.GetResponseStream())
            //        {
            //            if (strReader == null) return View();
            //            using (StreamReader objReader = new StreamReader(strReader))
            //            {
            //                string responseBody = objReader.ReadToEnd();
            //                listChar = responseBody.SetCharactersViewOfJsonMorty();
            //                return View(listChar);
            //            }
            //        }
            //    }
            //}
            //catch (WebException ex)
            //{
            //    ViewBag.Mensaje = ex.Message;
            //    return View();
            //}


        }

        

    }
  

}

