using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_linq_Entities;

namespace Practica_linq_Logic.Dto_Logic
{
    public class CustomersDto : BaseLogic
    {

        public Customers customCustomer { get; set; }

        public string CustomerID { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public String OrderDate { get; set; }

        //public override string Get_T_TO_String()
        //{
        //    String objectString =
        //                   " \n Nombre de la Compania: " + customCustomer.CompanyName +
        //                   " \n Nombre Contacto: " + customCustomer.ContactName +
        //                   " \n Adress: " + customCustomer.Address +
        //                   " \n Region: " + customCustomer.Region;

        //    return objectString;
        //}
    }
}
