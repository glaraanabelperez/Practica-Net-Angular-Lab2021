using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_EF_Logic.ExtensionMethodsLogic
{
    public static class InteractionUserHelpers
    {
        public static string InsertCodigoString()
        {
            Console.WriteLine(" \n INGRESE EL CODIGO A BUSCAR");
            String entrada = Console.ReadLine();
            return ValidationNull(entrada);
        }
        public static string ValidationNull(this String entrie)
        {
            if (String.IsNullOrEmpty(entrie))
            {
                throw new NullReferenceException();
            }
            return entrie;

        }

    }
}
