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
        public Customers customer { get; set; }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
        public void GetByCodigo(string id)
        {
            try
            {
                Customers cust = new Customers();
                cust = (from c in context.Customers
                        where c.CustomerID.Equals(id)
                        select c).Single();
                this.customer = cust;

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
        public void GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Insert(Shippers newShiper)
        {
            throw new NotImplementedException();
        }
        public string Update(Customers c)
        {
            var customerUpdate = context.Customers.Find(customer.CustomerID);
            customerUpdate.ContactName = c.ContactName;

            string message;
            try
            {
                context.SaveChanges();
                message = "MUY BIEN SE EDITO EL CUSTOMER";
            }
            catch (NotSupportedException)
            {
                throw new NotSupportedException();
            }
            catch (ObjectDisposedException)
            {
                throw new ObjectDisposedException(customerUpdate.ContactName);
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();

            }
            return message;
        }
    }
}
