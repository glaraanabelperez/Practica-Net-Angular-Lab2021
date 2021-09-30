using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Dto;
using Practica_EF_Entities;
using Practica_EF_MVC.Models;

namespace Practica_EF_Logic
{
    public static class HelpersMapDtoModels
    {
        public static  Customers Map_CustomView_to_Customers( this CustomerView custView)
        {
            Customers cust = new Customers();
            cust.CustomerID = custView.CustomerID;
            cust.CompanyName = custView.CompanyName;
            cust.ContactName = custView.ContactName;
            cust.Country = custView.Country;
            return cust;
        }
        public static CustomerView Map_Customers_to_CustomView(this Customers cust)
        {
            CustomerView custView = new CustomerView();
            custView.CustomerID = cust.CustomerID;
            custView.CompanyName = cust.CompanyName;
            custView.ContactName = cust.ContactName;
            custView.Country = cust.Country;

            return custView;
        }
 
    }
}
