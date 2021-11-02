using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Entities;

namespace Practica_EF_Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {
        public string Delete(int id)
        {
            var shiper_delete = context.Shippers.Find(id);
            context.Shippers.Remove(shiper_delete);
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

        public string Delete(string obj)
        {
            throw new NotImplementedException();
        }

        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public Shippers GetById(int id)
        {
            return context.Shippers.Find(id);
        }

        public Shippers GetById(string id)
        {
            throw new NotImplementedException();
        }

        public string Insert(Shippers newShiper)
        {
            context.Shippers.Add(newShiper);
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

        public string Update(Shippers obj)
        {
            throw new NotImplementedException();
        }

    }
}
