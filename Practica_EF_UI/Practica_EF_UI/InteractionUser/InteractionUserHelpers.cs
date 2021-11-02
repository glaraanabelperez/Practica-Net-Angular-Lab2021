using System;


namespace Practica_EF_UI.ExtensionMethodsLogic
{
    public static class InteractionUser
    {
      
        public static string Continuar()
        {
            String entrie;
            do
            {
                Console.WriteLine("\n DESEA CONITNUAR? (si/no)");
                entrie = Console.ReadLine();
            } while (String.IsNullOrEmpty(entrie));

            return entrie;
        }
        public static string InsertDataAndCheck(string instructions)
        {
            String entrie;
            do
            {
                Console.WriteLine($" \n INGRESE {instructions}");
                entrie = Console.ReadLine().ToUpper();
            } while (String.IsNullOrEmpty(entrie));

            return entrie;
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

        public static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static string Menu()
        {
            String operation;
            Console.WriteLine(" \nBuen dia!");
            Console.WriteLine(" \nINGRESA LA LETRA DE LA ENTIDAD CON LA CUAL TRABAJAR:" +
                " \n  ORDENES ('OR'), \n  ORDENES DETALLE('OD'), \n  CLIENTES ('CU'), \n  ENVIOS('SH'),\n  SALIR ('S') ");
            operation = Console.ReadLine();
            operation = operation.ToUpper();
            operation = operation.Equals("OR") ? "ORDERS" : operation.Equals("OD") ? "ORDER_DETAILS"
                 : operation.Equals("CU") ? "CUSTOMERS"
                 : operation.Equals("SH") ? "SHIPPERS"
                 : operation.Equals("S") ? "SALIR"
                 : null;
            return operation;
        }
    }
}
