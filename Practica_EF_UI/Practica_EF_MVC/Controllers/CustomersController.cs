﻿using System;
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

    public class CustomersController : Controller
    {
        private CustomersLogic customLogic;
      
        public CustomersController()
        {
            customLogic = new CustomersLogic();
        }

        public ActionResult Index(string mensaje)
        {
            ViewBag.Mensaje = "Buen dia";

            if (mensaje == null)
            {
                ViewBag.Mensaje = "Buen Dia!!";
            }
            else
            {
                ViewBag.Mensaje = mensaje;
            }

            List<CustomerView> customers_view;
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

        public ActionResult Delete(string custId)
        {
            string mensaje="OK";
            try
            {
                customLogic.Delete(custId);
                return RedirectToAction("Index", "Customers",  new { mensaje = mensaje });
            }
            catch (NotSupportedException)
            {
                mensaje = "La accion no se puede realizar";
            }
            catch (ObjectDisposedException)
            {
                mensaje = "El Clientes no se encuentra entre los datos";
            }
            catch (InvalidOperationException)
            {
                mensaje = "El Clientes no esta disponible";
            }
            catch (Exception)
            {
                mensaje = "Algo paso... Seguro que los datos estan siendo usados y no pueden borrarse";
            }

            return RedirectToAction("Index", "Error", new { mensaje=mensaje });

        }

        [HttpGet]
        public ActionResult Edit(string custId)
        {
            string mensaje = null;

            if ( custId!=null && custId.Equals("NUEVO"))
            {
                CustomerView custView = new CustomerView();
                return View(custView);
            }

            try
            {
                Customers cust = customLogic.GetById(custId);
                CustomerView custView = cust.MapCustomerToCustomerView();

                return View(custView);
            }
            catch (ArgumentNullException ex)
            {
                mensaje = ex.Message;
            }
            catch (System.InvalidOperationException ex)
            {
                mensaje = ex.Message;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return RedirectToAction("Index", "Customers", new { mensaje = mensaje });

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
            Customers customerEntitie= custom.MapCustomerViewToCustomer();
            string mensaje = null;

            if (custom.CustomerID==null)
            {
                try
                {
                    customerEntitie.CustomerID = SetNewId();
                    customLogic.Insert(customerEntitie);
                    mensaje = "El Insert ok";
                    return RedirectToAction("Index", "Customers", new { mensaje = mensaje });
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
                    mensaje = "El Edit ok";
                    return RedirectToAction("Index", "Customers", new { mensaje = mensaje });
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

            return View(custom);

        }


    }
}