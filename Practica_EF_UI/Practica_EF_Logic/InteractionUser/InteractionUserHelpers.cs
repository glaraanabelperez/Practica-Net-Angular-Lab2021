using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Logic.ExtensionMethodsLogic;

namespace Practica_EF_Logic.ExtensionMethodsLogic
{
    public static class InteractionUserHelpers
    {
        public static string Menu()  
        {
           String operation;
           Console.WriteLine("Buen dia!");
           Console.WriteLine("INGRESA LA LETRA DE LA ENTIDAD CON LA CUAL TRABAJAR:" +
               " \n  ORDENES ('or'), \n  ORDENES DETALLE('od'), \n  CLIENTES ('c'), \n  ENVIOS('e'),\n  SALIR ('s') ");
           operation = Console.ReadLine();
           operation = operation.Equals("or") ? "ORDERS" : operation.Equals("od") ? "ORDER_DETAILS"
                : operation.Equals("c") ? "CUSTOMERS"
                : operation.Equals("e") ? "SHIPPERS"
                : operation.Equals("s") ? "s"
                : null;
            return operation;
        }
 
        public static string Continuar()
        {
            String entrie;
            do
            {
                Console.WriteLine("\n DESEA CONITNUAR? (si/no)");
                entrie = Console.ReadLine();
            } while (String.IsNullOrEmpty(entrie) );
            return entrie;
        }
        public static string InsertDates()
        {
            Console.WriteLine(" \n INGRESE EL DATO");
            String entrada = Console.ReadLine();
            return entrada.ThrowingNulReference();
        }
        public static int InsertNumber()
        {
            Console.WriteLine(" \n INGRESE EL Numero");
            String entrada = Console.ReadLine();
            try
            {
                int result = Int32.Parse(entrada);
                return result;
            }
            catch (FormatException)
            {
                throw new Exception();
            }
        }
    }
}
