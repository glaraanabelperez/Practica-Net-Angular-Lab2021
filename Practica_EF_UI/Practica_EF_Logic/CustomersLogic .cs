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

        public Customers cust { get; set; }

        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public string Delete(string customer_id)
        {
            Customers customers = context.Customers.Find(customer_id);
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
                throw new ObjectDisposedException("El Clientes no existe en la Base de Datos");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("El Clientes no esta dsipnible");

            }
            catch (Exception ex)
            {
                throw new Exception($"Hubo un error interno {ex.Message}");

            }
        }

        public string Delete(int obj)
        {
            throw new NotImplementedException();
        }

        public Customers GetById(int obj)
        {
            throw new NotImplementedException();
        }

        public Customers GetById(String custom)
        {
            try
            {
                cust = (from c in context.Customers
                        where c.CustomerID.Equals(custom)
                        select c).Single();
                return cust;
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Ha ocurrido un error, no se aceptan datos nulos");
            }
            catch (System.InvalidOperationException)
            {
                throw new System.InvalidOperationException("Lo que busca no se encuentra disponible");
            }
            catch (Exception ex)
            {
                throw new Exception($"Hubo un error: {ex.Message}");
            }
        }
        
        public string Insert(Customers newCustom)
        {
            context.Customers.Add(newCustom);
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
                throw new ObjectDisposedException("El Cliente no se puede insertar");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("El cliente no esta disponible para Insertar");
            }
            catch (Exception ex)
            {
                throw new Exception($"Hubo un error interno {ex.Message}");

            }
        }

        public string Exist(string  custom_id)
        {
            try
            {
                string id = (from c in context.Customers
                             where c.CustomerID.Contains(custom_id)
                             select c.CustomerID).Single();
                return id;
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Ha ocurrido un error, no se aceptan datos nulos");
            }
            catch (System.InvalidOperationException)
            {
                throw new System.InvalidOperationException("Lo que busca no se encuentra disponible");
            }
            catch (Exception ex)
            {
                throw new Exception($"Hubo un error  {ex.Message}");
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
          catch (ObjectDisposedException)
          {
              throw new ObjectDisposedException("El cliente no esta disponible en los datos");
          }
          catch (InvalidOperationException)
          {
              throw new InvalidOperationException("No se encuentra disponible el ciente para realizarle cambios");

          }
          catch (Exception ex)
          {
                throw ex ;
          }

        }

    }
}
