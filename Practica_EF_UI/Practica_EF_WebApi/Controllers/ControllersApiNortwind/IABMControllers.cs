using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Practica_EF_WebApi.Controllers.ControllersApiNortwind
{
    interface IABMControllers<T>
    {

        //List<T> GetAll();

        [HttpGet]
        IHttpActionResult Get(string custId);

        [HttpPost]
        IHttpActionResult Insert([FromBody] T customerRequest);

        [HttpPut]
        IHttpActionResult Put([FromBody] T customerRequest);

        [HttpDelete]
        IHttpActionResult Delete(string custId);


    }
}
