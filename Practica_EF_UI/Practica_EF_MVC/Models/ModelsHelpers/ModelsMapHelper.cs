using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;
using Practica_EF_Entities;
using Practica_EF_MVC.Models;

namespace Practica_EF_Logic
{
    public static class ModelsMapHelpers
    {
        public static Customers MapCustomerViewToCustomer(this CustomerView custView)
        {
            Customers cust = new Customers();
            cust.CustomerID = custView.CustomerID;
            cust.CompanyName = custView.CompanyName;
            cust.ContactName = custView.ContactName;
            cust.Country = custView.Country;
            return cust;
        }
        public static CustomerView MapCustomerToCustomerView(this Customers cust)
        {
            CustomerView custView = new CustomerView();
            custView.CustomerID = cust.CustomerID;
            custView.CompanyName = cust.CompanyName;
            custView.ContactName = cust.ContactName;
            custView.Country = cust.Country;

            return custView;
        }

        public static List<CharactersView> MapCustomerToCustomerView(this JObject jsonResponse)
        {
            List<CharactersView> CharcterLIst = new List<CharactersView>();
            foreach(var item in jsonResponse)
            {
                CharactersView Char = new CharactersView();
                Char.name = item.Key;
                CharcterLIst.Add(Char);
            }
        
            return CharcterLIst;
        }

    }
}
