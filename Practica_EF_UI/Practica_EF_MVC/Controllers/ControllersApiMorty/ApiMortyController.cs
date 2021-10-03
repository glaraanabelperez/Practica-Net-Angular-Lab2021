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

    public class ApiMortyController : Controller, IABMControllers<CharactersView>
    {
        public ApiMortyController()
        {
        }

        public ActionResult Index(string mensaje)
        {
            mensaje = mensaje == null ? ViewBag.Mensaje = "Buen Dia!!" : ViewBag.Mensaje = mensaje;

            HttpWebRequest request = ConexionApiMorty();

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    //if (response.GetResponseStream().Length > 0)
                    //{

                    //}
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return View(new { mensaje = "Error en la peticion de datos" });

                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            JObject jsonResponse = JObject.Parse(responseBody);
                            //List<CharactersView> listMorty = JsonConvert.DeserializeObject<List<CharactersView>>(responseBody);
                            List<CharactersView> listMorty2 = jsonResponse.MapCustomerToCustomerView();

                            return View(responseBody);
                        }
                    }
                }
            }
            catch (WebException)
            {
                return View(new { mensaje = "Error de conexion" });
            }

        }

        private HttpWebRequest ConexionApiMorty()
        {
            var url = $"https://rickandmortyapi.com/api/character";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            //request.HaveResponse.ToString();
            return request;
        }

        public ActionResult Delete(string custId)
        {
            throw new NotImplementedException();
        }

        public ActionResult Edit(string custId)
        {
            throw new NotImplementedException();
        }

        public ActionResult Result_Edit(CharactersView custom)
        {
            throw new NotImplementedException();
        }

    }
}