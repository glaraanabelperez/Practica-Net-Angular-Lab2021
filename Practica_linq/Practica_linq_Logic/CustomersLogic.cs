using System;
using System.Collections.Generic;
using System.Linq;
using Practica_linq_Entities;
using Practica_linq_Logic.Dto_Logic;

namespace Practica_linq_Logic
{

    public partial class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {
        public Customers custom { get; set; }
        public IEnumerable<Customers> customers { get; set; }

        public IEnumerable<CustomersDto> customDto;

        public void Set_Custom_Acording_Name()
        {
            custom = context.Customers.First(custom => custom.CompanyName.Contains("s"));
        }

        public void Set_Custom_Join_Region_Orders(String s)
        {
            

            DateTime date1 = new DateTime(1997, 1, 1);
            customDto = from cus in context.Customers
                            join order in context.Orders
                            on new { cus.CustomerID } equals new { order.CustomerID }
                            where cus.Region.Equals(s) && order.OrderDate > date1
                            select new CustomersDto
                            {
                                CompanyName = cus.CompanyName,
                                ContactName = cus.ContactName,
                                Region = cus.Region,
                                OrderDate = (DateTime)order.OrderDate,
                            };          
        }

        public void Set_All_Acording_Region(String s)
        {
            customers = context.Customers.Where(c => c.Region.Equals("WA"));
        }

        public List<String> Set_All_Acording_Name()
        {
            Func<String, String> convertToUper = minuscula => Convert_ToUper_AndLower( minuscula);
            customers = (from cust in context.Customers select cust);
            List<String> customName = (from cust in context.Customers select cust.ContactName).Select(convertToUper).ToList();
            return customName;
        }

        public string Convert_ToUper_AndLower(String name)
        {
            String convertName= $"Mayuscula: {name.ToUpper()}, Minuscula: {name.ToLower()}";
            return convertName;
        }

        public void Set_All_Acording_Unit_Stock(int x)
        {
            throw new NotImplementedException();
        }

        public string Get_IEnumerable_String(IEnumerable<Customers> customers)
        {
            String rstaString = null;
            if (customers != null)
            {
                foreach (var c in customers)
                {
                    rstaString += $"\n Producto: { c.CompanyName}\n Id_Categoria: {c.ContactName}\n Precio: {c.Region}";
                    rstaString += "\n";
                }
            }
            else
            {
                rstaString = "NO se ha encontrado lo que esta buscando";
            }

            return rstaString;
        }

        public string Get_T_String(Customers c)
        {
            String objectString =
                " \n Nombre de la Compania: " + c.CompanyName +
                " \n Nombre Contacto: " + c.ContactName +
                " \n Adress: " + c.Address +
                " \n Region: " + c.Region;

            return objectString;
        }

        public string Get_All_CustomerDto_ToString(IEnumerable<CustomersDto> custDto)
        {

            String rstaString = null;
            if (rstaString == null)
            {
                foreach (var c in custDto)
                {

                    rstaString += $"\n Nombre Compania: { c.CompanyName}\n Nombre Contacto: {c.ContactName}\n Region: {c.Region}\n Fecha Orden: {c.OrderDate}";
                    rstaString += "\n";
                }
            }
            else
            {
                rstaString = "NO se ha encontrado lo que esta buscando";
            }
            return rstaString;

        }
        public string Get_All__ToString(List<String> customName)
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

