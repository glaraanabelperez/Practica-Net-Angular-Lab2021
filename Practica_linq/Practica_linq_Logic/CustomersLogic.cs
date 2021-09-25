using System;
using System.Collections.Generic;
using System.Linq;
using Practica_linq_Entities;
namespace Practica_linq_Logic
{

    public partial class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {
        public Customers custom { get; set; }
        public IEnumerable<Customers> customers { get; set; }

        public void Set_Object_Acording_Name()
        {
            custom = context.Customers.First(custom => custom.CompanyName.Contains("s"));
        }

        public void Set_All_Acording_Region(String s)
        {
            customers = context.Customers.Where(c => c.Region.Equals("WA"));
        }

        public List<String> Set_All_Acording_Name()
        {
            Func<Customers, String> convertToUper = minuscula => minuscula.ContactName.ToUpper();
            customers = (from cust in context.Customers select cust);
            List<String> customName = (from cust in context.Customers select cust).Select(convertToUper).ToList();
            return customName;
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
                return rstaString;

            }
            else
            {
                rstaString = "NO se ha encontrado lo que esta buscando";
            }

            return rstaString;
        }

        public string Get_Object_String(Customers c)
        {
            String objectString =
                " \n Nombre de la Compania: " + c.CompanyName +
                " \n Nombre Contacto: " + c.ContactName +
                " \n Adress: " + c.Address +
                " \n Region: " + c.Region;

            return objectString;
        }
    }
}

