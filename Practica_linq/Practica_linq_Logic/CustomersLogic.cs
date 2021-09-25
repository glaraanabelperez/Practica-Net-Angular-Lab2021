using System;
using System.Collections.Generic;
using System.Linq;
using Practica_linq_Entities;
using Practica_linq_Logic.Dto_Logic;
using Practica_linq_Logic.Helperes_Logic;

namespace Practica_linq_Logic
{

    public partial class CustomersLogic : CustomersDto
    {
        public IEnumerable<CustomersDto> Customers_Dto { get; set; }

        public void Set_customCustomer_Acording_Name()
        {
            customCustomer = context.Customers.First(custom => custom.CompanyName.Contains("s"));
        }

        public void Set_Customers_Dto_By_Region(String s)
        {
            Customers_Dto = context.Customers
                .Where(c => c.Region.Equals("WA"))
                .Select( c => new CustomersDto { 
                    CompanyName=c.CompanyName,
                    ContactName=c.ContactName,
                    Region=c.Region,
                });
        }

        public void Set__Customers_Dto_join_Orders(String s)
        {
            DateTime date1 = new DateTime(1997, 1, 1);
            Customers_Dto = from cus in context.Customers
                            join order in context.Orders
                            on new { cus.CustomerID } equals new { order.CustomerID }
                            where cus.Region.Equals(s) && order.OrderDate > date1
                            select new CustomersDto
                            {
                                CompanyName = cus.CompanyName,
                                ContactName = cus.ContactName,
                                Region = cus.Region,
                                OrderDate = order.OrderDate.ToString()
                            };

        }

        public List<String> Set_Customers_Dto_By__Name()
        {
            Func<String, String> convertToUper = minuscula => minuscula.Convert_ToUper_AndLower();
            List<String> customName = (from cust in context.Customers select cust.ContactName).Select(convertToUper).ToList();
            return customName;
        }

        public string Get_Customers_Dto_To_String()
        {
            String rstaString = null;
            if (Customers_Dto != null)
            {
                foreach (var c in Customers_Dto)
                {
                    rstaString += $"\n Cliente: { c.CompanyName}\n Contacto: {c.ContactName}\n Region: {c.Region}";
                    rstaString += "\n";
                }
            }
            else
            {
                rstaString = "NO se ha encontrado lo que esta buscando";
            }

            return rstaString;
        }

        public  String Get_customCustomer_TO_String()
        {
            String objectString =
                           " \n Nombre de la Compania: " + customCustomer.CompanyName +
                           " \n Nombre Contacto: " + customCustomer.ContactName +
                           " \n Adress: " + customCustomer.Address +
                           " \n Region: " + customCustomer.Region;

            return objectString;
        }

        public string Get_Customers_Dto_ToString_Date()
        {

            String rstaString = null;
            if (rstaString == null)
            {
                foreach (var c in Customers_Dto)
                {

                    rstaString += $"\n Nombre Compania: { c.CompanyName}\n Nombre Contacto: {c.ContactName}\n Region: {c.Region}\n Fecha Orden:  {c.OrderDate} ";
                    rstaString += "\n";
                }
            }
            else
            {
                rstaString = "NO se ha encontrado lo que esta buscando";
            }
            return rstaString;

        }

        public string Get_List_TO_ToString(List<String> customName)
        {
            String rstaString = null;
            if (rstaString == null)
            {
                foreach (var item in customName)
                {
                    Console.WriteLine($"\n {item}");
                }
            }
            else
            {
                rstaString = "NO se ha encontrado lo que esta buscando";
            }
            return rstaString;

        }

    }
}

