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
            string operation;
            do
            {
               Console.WriteLine("Buen dia!");
               Console.WriteLine("Ingreses la letra de la entidad con la cual desea trabajar:" +
                   "Para Ordernes ('O'), Para Ordenes de detalle ('OD'),Para Clientes ('C'),Para Ennvios ('E'), Para Salir ('S') ");
               operation = Console.ReadLine();
            } while (String.IsNullOrEmpty(operation));

            operation = operation.Equals("ORDERS") ? operation = "ORDERS"
                        : operation.Equals("ORDERDETAIL") ? operation = "ORDER_DETAILS"
                        : operation.Equals("CUSTOMERS") ? operation = "CUSTOMERS"
                        : operation.Equals("SHIPPERS") ? operation = "SHIPPERS"
                        : operation.Equals("S") ? operation = "S"
                        : operation =null;

            if (operation == null)
                Console.WriteLine("Ingrese solo algunas de las teltras indicadas");
                Menu();

            return operation;
        }
        public static string SelectionID()
        {
            Console.WriteLine(" \n INGRESE EL CODIGO A BUSCAR");
            String entrada = Console.ReadLine();
            return entrada.ThrowingNulReference();
        }
        public static bool ValidationsOnlyLetters(string entrada)
        {
            foreach (Char ch in entrada)
            {
                if (!Char.IsLetter(ch) && ch != 32)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
