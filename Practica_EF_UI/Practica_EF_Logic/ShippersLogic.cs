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
        public string Delete(string obj)
        {
            throw new NotImplementedException();
        }

        public string Delete(int obj_id)
        {
            Customers customers = context.Customers.Find(obj_id);
            context.Customers.Remove(customers);

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
                throw new ObjectDisposedException("El Dato no existe en la Base de Datos");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("El Dato no esta dsipnible");

            }
            catch (Exception)
            {
                throw new Exception("Algo paso... Seguro que los datos estan siendo usados y no pueden borrarse");

            }
        }

        public List<Shippers> GetAll()
        {
            throw new NotImplementedException();
        }

        public Shippers GetById(string obj)
        {
            throw new NotImplementedException();
        }

        public Shippers GetById(int obj)
        {
            throw new NotImplementedException();
        }

        public string Insert(Shippers obj)
        {
            context.Shippers.Add(obj);
            try
            {
                context.SaveChanges();
                return "OK";
            }
            catch (NotSupportedException)
            {
                throw new NotSupportedException("Error al insertar");
            }
            catch (ObjectDisposedException)
            {
                throw new ObjectDisposedException("El dato no se puede insertar");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("El dato no esta disponible para Insertar");
            }
            catch (Exception)
            {
                throw new Exception("Algo paso");

            }
        }

        public string Update(Shippers obj)
        {
            throw new NotImplementedException();
        }
    }
}
