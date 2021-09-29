using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica_EF_Entities;
using Practica_EF_Logic;
using Practica_EF_MVC.Models;

namespace Practica_EF_MVC.Controllers
{
    public class CustomersController : Controller
    {
        private CustomersLogic customLogic { get; set; }
        private Customers customEntitie { get; set; }
        private CustomerView customerView { get; set; }
        public List<CustomerView> customers_viewList { get; set; }

        public CustomersController()
        {
            customLogic = new CustomersLogic();
        }

        public ActionResult Index()
        {
        var cust = customLogic.GetAll();
            customers_viewList = cust.Select(c => new CustomerView
            {
                CustomerID = c.CustomerID,
                ContactName = c.ContactName,
                CompanyName = c.CompanyName,
                Country = c.Country
            }).ToList();

            return View(customers_viewList);
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
            customEntitie = new Customers { 
                CustomerID = custom.CustomerID,
                CompanyName=custom.CompanyName,
                ContactName=custom.ContactName,
                Country=custom.Country
            };
            string message;
            try
            {
                customLogic.Insert(customEntitie);
                message = "El dato ah sido insertado";
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


        //public ActionResult Create()
        //{
        //    return View();
        //}



        //public ActionResult Create([Bind(Include = "LastName, FirstMidName, EnrollmentDate")] Student student)
        //{
        //    Response.Write("<script> console.log('Holacc')</script>");
        //    Response.Write(student.EnrollmentDate);
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            db.Students.Add(student);
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }
        //    }
        //    catch (DataException)
        //    {
        //        ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
        //    }
        //    return View(student);
        //}




        //public ActionResult Delete(int? id, bool? saveChangesError = false)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    if (saveChangesError.GetValueOrDefault())
        //    {
        //        ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
        //    }
        //    Student student = db.Students.Find(id);
        //    if (student == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(student);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id)
        //{
        //    try
        //    {
        //        Student student = db.Students.Find(id);
        //        db.Students.Remove(student);
        //        //Student studentToDelete = new Student() { ID = id };
        //        //db.Entry(studentToDelete).State = EntityState.Deleted;
        //        db.SaveChanges();
        //    }
        //    catch (DataException/* dex */)
        //    {
        //        return RedirectToAction("Delete", new { id = id, saveChangesError = true });
        //    }
        //    return RedirectToAction("Index");
        //}







        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,LastName,FirstMidName,EnrollmentDate")] Student student)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(student).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(student);
        //}



        //[HttpPost, ActionName("Edit")]
        //[ValidateAntiForgeryToken]
        //public ActionResult EditPost(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    var studentToUpdate = db.Students.Find(id);
        //    if (TryUpdateModel(studentToUpdate, "",
        //       new string[] { "LastName", "FirstMidName", "EnrollmentDate" }))
        //    {
        //        try
        //        {
        //            db.SaveChanges();
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