using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
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
            catch (ArgumentNullException e)
            {
                return RedirectToAction("Index", "Error", new { mensaje = e.Message });
            }
            catch (UriFormatException e)
            {
                return RedirectToAction("Index", "Error", new { mensaje = e.Message });
            }
            catch (WebException e)
            {
                return RedirectToAction("Index", "Error", new { mensaje = e.Message });
            }
 

        }

        

    }
  

}

