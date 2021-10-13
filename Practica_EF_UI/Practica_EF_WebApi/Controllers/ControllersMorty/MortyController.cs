using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Practica_EF_Logic.Practica.EF.Logic.APIMory;
using Practica_EF_WebApi.Models;

namespace Practica_EF_WebApi.Controllers.ControllersMorty
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class MortyController : ApiController
    {
        public ApiMortyLogic logic = new ApiMortyLogic();

        [HttpGet]
        public List<CharactersViewApi> GetAll()
        {

            List<CharactersViewApi> listChar;
            string logicRequest;
    
            logicRequest = logic.RequestDataApiMorty();
            listChar = logicRequest.SetCharactersViewOfJsonMorty();
            return listChar;

        }

    }
}
