using System;
using System.Collections.Generic;
using System.Data;
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
            catch (Exception)
            {
                throw new Exception("Ocurrio un Problema, al borrar los datos");
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
                return cust;

            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un Problema, al traer los datos");
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
            catch (Exception)
            {
                throw new Exception("Ocurrio un Problema, al guardar los datos");
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
            catch (Exception)
            {
                throw new Exception("Ocurrio un Problema, al actualizar los datos");
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
            catch (Exception)
            {
                throw new Exception("Ocurrio un Problema, al buscar los datos");
            }
        }

    }
}