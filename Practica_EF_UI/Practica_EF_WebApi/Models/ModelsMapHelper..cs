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
    public static class ModelsMapHelper
    {
        public static Customers MapCustomerResponseToCustomer(this CustomerResponse customerResponse)
        {
            Customers customer = new Customers();
            customer.CustomerID = customerResponse.CustomerID;
            customer.CompanyName = customerResponse.CompanyName;
            customer.ContactName = customerResponse.ContactName;
            customer.Country = customerResponse.Country;

            return customer;
        }

        public static Customers MapCustomerRequestToCustomer(this CustomerRequest customerRequest)
        {
            Customers customer = new Customers();
            customer.CustomerID = customerRequest.CustomerID;
            customer.CompanyName = customerRequest.CompanyName;
            customer.ContactName = customerRequest.ContactName;
            customer.Country = customerRequest.Country;

            return customer;
        }

        public static CustomerResponse MapCustomerToCustomerResponse(this Customers customer)
        {
            CustomerResponse customerResponse = new CustomerResponse();
            customerResponse.CustomerID = customer.CustomerID;
            customerResponse.CompanyName = customer.CompanyName;
            customerResponse.ContactName = customer.ContactName;
            customerResponse.Country = customer.Country;

            return customerResponse;
        }

        public static CustomerRequest MapCustomerToCustomerRequest(this Customers customer)
        {
            CustomerRequest customerRequest = new CustomerRequest();
            customerRequest.CustomerID = customer.CustomerID;
            customerRequest.CompanyName = customer.CompanyName;
            customerRequest.ContactName = customer.ContactName;
            customerRequest.Country = customer.Country;

            return customerRequest;
        }
    }
}