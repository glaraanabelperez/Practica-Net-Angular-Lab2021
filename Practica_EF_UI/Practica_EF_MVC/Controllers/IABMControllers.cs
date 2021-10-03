using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Practica_EF_MVC.Controllers
{
    interface IABMControllers<T>
    {
        ActionResult Index(string mensaje);

        ActionResult Delete(string custId);

        [HttpGet]
        ActionResult Edit(string custId);

        [HttpPost]
        ActionResult Result_Edit(T custom);
    }
}
