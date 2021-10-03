using System;
using System.Collections.Generic;
using System.Linq;
using Practica_EF_Entities;
using Practica_EF_Logic;
using Practica_EF_MVC.Models;
using System.Data;
using System.Web.Http;
using Practica_EF_Web_3.Controllers.HelperesControllers;


namespace Practica_EF_MVC.Controllers
{
    public class CustomersController : ApiController
    {
        private CustomersLogic customLogic;
      
        public CustomersController()
        {
            customLogic = new CustomersLogic();
        }

        [HttpGet]
        public List<CustomerResponse> GetAllCustomers()
        {
            var cust = customLogic.GetAll();

            List<CustomerView> customers_view = cust.Select(c => new CustomerView
            {
                CustomerID = c.CustomerID,
                ContactName = c.ContactName,
                CompanyName = c.CompanyName,
                Country = c.Country
            }).ToList();

            return customers_view;
        }


        public IHttpActionResult GetCustomer(string custId)
        {
            if (custId != null && custId.Equals(""))
            {
                //throw new InvalidOperationException("Mal");
                return ControllersHelperesEXceptions.HttpNotFoundResult();
            }

            try
            {
                Customers cust = customLogic.GetById(custId);
                CustomerView custView = cust.MapCustomerToCustomerView();

                return (IHttpActionResult)custView;
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Ha ocurrido un error, no es posible mostrarle lo que esta buscando");
            }
            catch (System.InvalidOperationException)
            {
                throw new System.InvalidOperationException("Lo que busca no se encuentra disponible");
            }
            catch (Exception)
            {
                throw new Exception("Algo paso...");
            }
        }

        public IHttpActionResult Add([FromBody] CustomerView custom)
        {
            Customers customerEntitie = custom.MapCustomerViewToCustomer();

            if (custom.CustomerID == null)
            {

                customerEntitie.CustomerID = SetNewId();
                customLogic.Insert(customerEntitie);
                Customers cust = customLogic.GetById(customerEntitie.CustomerID);
                CustomerView custView = cust.MapCustomerToCustomerView();
                return (IHttpActionResult)custView;
            }
            return ControllersHelperesEXceptions.HttpNotFoundResult();

        }

        public String SetNewId()
        {
            Random rnd = new Random();
            int id_num = rnd.Next(1, 10);
            string id_String = "A";
            id_String += id_num.ToString();

            return id_String;
        }

    }
}