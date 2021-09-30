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

        public ActionResult Delete(string custId)
        {
            ViewBag.Mensaje1 = null;
            try
            {
                customLogic.Delete(custId);
                ViewBag.Mensaje1 = "El dato ah sido eliminado";
            }
            catch (NotSupportedException)
            {
                ViewBag.Mensaje1 = "La accion no se puede realizar";
            }
            catch (ObjectDisposedException)
            {
                ViewBag.Mensaje1 = "El Clientes no se encuentra entre los datos";
            }
            catch (InvalidOperationException)
            {
                ViewBag.Mensaje1 = "El Clientes no esta disponible";

            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(string custId)
        {
            ViewBag.Mensaje1 = null;
            //ViewBag.CustomerId = null;
            //custView = new CustomerView();

            if ( custId!=null && custId.Equals("NUEVO"))
            {
                CustomerView custView = new CustomerView();
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

        public String SetNewId()
        {
            Random rnd = new Random();
            int id_num = rnd.Next(1, 10);
            string id_String = "A";
            id_String += id_num.ToString();

            return id_String;
        }

        [HttpPost]
        public ActionResult Result_Edit(CustomerView custom)
        {
            Customers customerEntitie= custom.Map_CustomView_to_Customers();
            ViewBag.Mensaje = null;

            if (custom.CustomerID==null)
            {
                try
                {


                    customerEntitie.CustomerID = SetNewId();
                    customLogic.Insert(customerEntitie);
                    ViewBag.Mensaje = "OK";
                    return RedirectToAction("Index");
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
                catch (Exception)
                {
                    ViewBag.Mensaje = "Algo paso";
                }
            }
            else
            {
                try
                {
                    string result = customLogic.Update(customerEntitie);
                    ViewBag.Mensaje = result;
                    return RedirectToAction("Index");

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

            return View(custom);

        }


    }
}