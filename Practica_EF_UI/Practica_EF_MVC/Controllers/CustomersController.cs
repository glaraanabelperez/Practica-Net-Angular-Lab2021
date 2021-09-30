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

        //public ActionResult GetByID(CustomerView custom);
        public ActionResult Insert(CustomerView custom)
        {
            string message = null;
            //customEntitie = new Customers
            //{
            //    CustomerID = custom.CustomerID,
            //    CompanyName = custom.CompanyName,
            //    ContactName = custom.ContactName,
            //    Country = custom.Country
            //};

            //if (custom.CustomerID == null)
            //{

            //    try
            //    {
            //        customLogic.Insert(customEntitie);
            //        message = "El dato ah sido insertado";
            //        return View(message); ;
            //    }
            //    catch (NotSupportedException)
            //    {
            //        message = "La accion no se puede realizar";
            //    }
            //    catch (ObjectDisposedException)
            //    {
            //        message = "El Clientes no se encuentra entre los datos";
            //    }
            //    catch (InvalidOperationException)
            //    {
            //        message = "El Clientes no esta disponible";

            //    }
            //}
            //else
            //{
            //    Edit(customEntitie);
            //}

            return View(message);
               
        }

        [HttpGet]
        public ActionResult Edit(string custId)
        {
            String cu = custId;
            ViewBag.M = custId;
            ViewBag.Mensaje1 = null;
            custView = new CustomerView();

            try
            {
                Customers cust = customLogic.GetById(custId);
                //custView = cust.Map_Customers_to_CustomView();
                custView.CompanyName = cust.CustomerID;
                custView.CompanyName = cust.CompanyName;
                custView.ContactName = cust.ContactName;
                custView.Country = cust.Country;

                return View(cust);
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
        public ActionResult Save_Edit(CustomerView custom)
        {
            customEntitie = new Customers()
            {
                CustomerID = custom.CustomerID,
                CompanyName = custom.CompanyName,
                ContactName = custom.ContactName,
                Country = custom.Country
            };

            String message =null;
            try
            {
                customLogic.Update(customEntitie);
                message = "OK";
            }
            catch (System.InvalidOperationException ex)
            {
                message = ex.Message;
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            return View(message);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit_prueba([Bind(Include = "CustomerID,CompanyName,ContactName,Country")] CustomerView custom)
        //{
        //    ViewBag.message =null;

        //    customEntitie = new Customers
        //    {
        //        CustomerID = custom.CustomerID,
        //        CompanyName = custom.CompanyName,
        //        ContactName = custom.ContactName,
        //        Country = custom.Country
        //    };

        //    if (ModelState.IsValid)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            try
        //            {
        //                customLogic.ModifyState(customEntitie);
        //                return RedirectToAction("Index");
        //            }
        //            catch (NotSupportedException)
        //            {
        //                ViewBag.message = "La accion no se puede realizar";
        //            }
        //            catch (ObjectDisposedException)
        //            {
        //                ViewBag.message = "El Clientes no se encuentra entre los datos";
        //            }
        //            catch (InvalidOperationException)
        //            {
        //                ViewBag.message = "El Clientes no esta disponible";
        //            }
        //        }
        //    }
        //    return View(custom);        
        //  }

        //public ActionResult Edit_prueba1(Customers custom)
        //{
        //    if (custom.CustomerID == null)
        //    {
        //        return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
        //    }
        //    var studentToUpdate = customLogic.GetById(custom);

        //    if (TryUpdateModel(studentToUpdate, "",
        //       new string[] { "LastName", "FirstMidName", "EnrollmentDate" }))
        //    {
        //        try
        //        {
        //            customLogic.Save_change();
        //            return RedirectToAction("Index");
        //        }
        //        catch (DataException /* dex */)
        //        {
        //            ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
        //        }
        //    }
        //    return View(studentToUpdate);
        //}


    }
}