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
        Shippers ship;

        public string Delete(Shippers ship)
        {
            var shiper_delete = context.Shippers.Find(ship.ShipperID);
            context.Shippers.Remove(shiper_delete);

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
                throw new ObjectDisposedException("El Transporte no existe en la Base de Datos");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
        }

        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public Shippers GetById(Shippers shipper)
        {
            try
            {
                ship = context.Shippers.Find(shipper.ShipperID);
                return ship;
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

        public String  Insert(Shippers ship)
        {
            context.Shippers.Add(ship);
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
                throw new ObjectDisposedException("algo?");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();

            }

        }

        public string Update(Shippers ship)
        {
            throw new NotImplementedException();
        }

    }
}
