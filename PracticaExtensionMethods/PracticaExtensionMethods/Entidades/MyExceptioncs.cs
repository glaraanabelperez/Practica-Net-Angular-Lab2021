using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExtensionMethods.Entidades
{
    class MyExceptioncs:Exception
    {
        public MyExceptioncs(String message) : base("No existe la operacion:  " + message)
        {

        }
    }
}
