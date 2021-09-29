using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Entities;

namespace Practica_EF_Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {
        Customers cust;

        public String Delete(Customers custom)
        {
            cust= context.Customers.Find(custom.CustomerID);
            context.Customers.Remove(cust);
            string message;

            try
            {
                context.SaveChanges();
                return "OK";
            }
            catch (NotSupportedException)
            {
                throw new NotSupportedException("La accion no se puede realizar");
            }
            catch (ObjectDisposedException)
            {
                throw new ObjectDisposedException("El Clientes no existe en la Base de Datos");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();

            }
        }

        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public Customers GetById(Customers custom)
        {
            try
            {
                cust= (from c in context.Customers
                        where c.CustomerID.Equals(custom.CustomerID)
                        select c).Single();
                return cust;
            }
            catch (System.InvalidOperationException)
            {
                throw new System.InvalidOperationException();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public String Insert(Customers newCustom)
        {
            context.Customers.Add(newCustom);
            try
            {
                context.SaveChanges();
                return "OK";
            }
            catch (NotSupportedException)
            {
                throw new NotSupportedException();
            }
            catch (ObjectDisposedException)
            {
                throw new ObjectDisposedException("algo?, que iria?");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();

            }
        }

        public String Update(Customers custom)
        {
            //Edit([Bind(Include = "ID,LastName,FirstMidName,EnrollmentDate")] Student student

            //if (ModelState.IsValid)
            //{
            //    db.Entry(student).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //return View(student);



            //EditPost(int ? id)

            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //var studentToUpdate = db.Students.Find(id);
            //if (TryUpdateModel(studentToUpdate, "",
            //   new string[] { "LastName", "FirstMidName", "EnrollmentDate" }))
            //{
            //    try
            //    {
            //        db.SaveChanges();
            //        return RedirectToAction("Index");
            //    }
            //    catch (DataException /* dex */)
            //    {
            //        ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            //    }
            //}
            //return View(studentToUpdate);
            return null;

        }
    }
}
