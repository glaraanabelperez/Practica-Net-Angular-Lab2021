using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Practica_EF_Entities;
using Practica_EF_Logic;
using Practica_EF_MVC.Models;
using System.Data;
using System.Net;

namespace Practica_EF_MVC.Controllers
{
    //Se puede hacer metodo estatico para maper customView con Customers o cast!!!!

    public class CustomersController : Controller
    {
        private CustomersLogic customLogic;
        private Customers customEntitie;
        private CustomerView custView;
        public List<CustomerView> customers_view;



        public CustomersController()
        {
            customLogic = new CustomersLogic();
        }

        public ActionResult Index()
        {
        var cust = customLogic.GetAll();
            customers_view = cust.Select(c => new CustomerView
            {
                CustomerID = c.CustomerID,
                ContactName = c.ContactName,
                CompanyName = c.CompanyName,
                Country = c.Country
            }).ToList();

            return View(customers_view);
        }

        public ActionResult Details()
        {
            return View(this.custView);
        }
        public ActionResult Delete(CustomerView custom)
        {
            customEntitie = new Customers { CustomerID = custom.CustomerID };
            string message;
            try
            {
                customLogic.Delete(customEntitie);
                message = "El dato ah sido eliminado";
            }
            catch (NotSupportedException)
            {
                message = "La accion no se puede realizar";
            }
            catch (ObjectDisposedException)
            {
                message = "El Clientes no se encuentra entre los datos";
            }
            catch (InvalidOperationException)
            {
                message = "El Clientes no esta disponible";

            }

            return View(message); ;
        }

        [HttpGet]
        public ActionResult Edit(string custId)
        {
            ViewBag.Mensaje1 = null;
            ViewBag.CustomerId = null;
            custView = new CustomerView();

            if (custId.Equals("NUEVO"))
            {
                custView = new CustomerView();
                return View(custView);
            }

            try
            {
                Customers cust = customLogic.GetById(custId);
                custView = cust.Map_Customers_to_CustomView();
                return View(custView);
            }
            catch (ArgumentNullException ex)
            {
                ViewBag.Mensaje1 = ex.Message;
            }
            catch (System.InvalidOperationException ex)
            {
                ViewBag.Mensaje1 = ex.Message;
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje1 = ex.Message;
            }

            return View(ViewBag.Mensaje1);

        }

        [HttpPost]
        public ActionResult Result_Edit(CustomerView custom)
        {
            ViewBag.Mensaje = null;

            if (custom.CustomerID==null)
            {
                try
                {
                    customLogic.cust.CompanyName = customEntitie.CompanyName;
                    customLogic.cust.ContactName = customEntitie.ContactName;
                    customLogic.cust.Country = customEntitie.Country;
                    customLogic.Insert(customLogic.cust);
                    ViewBag.Mensaje = "OK";
                }
                catch (NotSupportedException)
                {
                    ViewBag.Mensaje = "Error al insertar";
                }
                catch (ObjectDisposedException)
                {
                    ViewBag.Mensaje = "El Cliente no se puede insertar";
                }
                catch (InvalidOperationException)
                {
                    ViewBag.Mensaje = "El cliente no esta disponible para Insertar";

                }
            }
            else
            {
                customEntitie = custom.Map_CustomView_to_Customers();
                try
                {
                    string result = customLogic.Update(customEntitie);
                    ViewBag.Mensaje = result;
                }
                catch (ObjectDisposedException ex)
                {
                    ViewBag.Mensaje = ex.Message;
                }
                catch (InvalidOperationException ex)
                {
                    ViewBag.Mensaje = ex.Message;

                }
            }

            try
            {
                customEntitie = customLogic.GetById(customEntitie.CustomerID);
                custView = customEntitie.Map_Customers_to_CustomView();
                return View(custView);
            }
            catch (ArgumentNullException ex)
            {
                ViewBag.Mensaje = ex.Message;
            }
            catch (System.InvalidOperationException ex)
            {
                ViewBag.Mensaje = ex.Message;
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
            }

            return View(custom);

        }


    }
}