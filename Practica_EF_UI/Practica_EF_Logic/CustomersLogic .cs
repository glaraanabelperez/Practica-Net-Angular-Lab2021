using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Entities;

namespace Practica_EF_Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public string Delete(string id)
        {
            Customers customers = context.Customers.Find(id);
            context.Customers.Remove(customers);

            try
            {
                context.SaveChanges();
                return "OK";
            }
            catch (NotSupportedException ex)
            {
                throw ex;
            }
            catch (ObjectDisposedException ex)
            {
                throw ex;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public Customers GetById(string id)
        {
            try
            {
                Customers cust = new Customers();
                cust = (from c in context.Customers
                        where c.CustomerID.Equals(id)
                        select c).Single();
                return  cust;

            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (System.InvalidOperationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customers GetById(int id)
        {
            throw new NotImplementedException();
        }

        public string Insert(Customers newCustom)
        {
            context.Customers.Add(newCustom);
            try
            {
                context.SaveChanges();
                return "OK";
            }
            catch (NotSupportedException ex)
            {
                throw ex;
            }
            catch (ObjectDisposedException ex)
            {
                throw ex;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public string Update(Customers custom)
        {
            context.Entry(custom).State = EntityState.Modified;

            try
            {
                context.SaveChanges();
                return "OK";
            }
            catch (ObjectDisposedException ex)
            {
                throw ex;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Exist(string custom_id)
        {
            try
            {
                string id = (from c in context.Customers
                             where c.CustomerID.Contains(custom_id)
                             select c.CustomerID).Single();
                return id;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (System.InvalidOperationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
