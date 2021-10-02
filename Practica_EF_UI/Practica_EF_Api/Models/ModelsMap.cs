using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Api.Models.ModelsRequest;
using Practica_EF_Entities;
using Practica_EF_MVC.Models;

namespace Practica_EF_Logic
{
    public static class ModelsMap
    {
        public static CustomersRequest MapCustomerViewToCustomer( this CustomerResponse customerResponse)
        {
            CustomersRequest customerRequest = new CustomersRequest();
            customerRequest.CustomerID = customerResponse.CustomerID;
            customerRequest.CompanyName = customerResponse.CompanyName;
            customerRequest.ContactName = customerResponse.ContactName;
            customerRequest.Country = customerResponse.Country;
            return customerRequest;
        }
        public static CustomerResponse MapCustomerToCustomerView(this CustomersRequest customerRequest)
        {
            CustomerResponse customerResponse = new CustomerResponse();
            customerResponse.CustomerID = customerRequest.CustomerID;
            customerResponse.CompanyName = customerRequest.CompanyName;
            customerResponse.ContactName = customerRequest.ContactName;
            customerResponse.Country = customerRequest.Country;

            return customerResponse;
        }
 
    }
}
