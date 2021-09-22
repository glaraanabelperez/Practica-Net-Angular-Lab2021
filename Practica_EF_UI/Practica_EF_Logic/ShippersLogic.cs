using System;
using System.Collections.Generic;
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
            string message;
            var shiper_delete = context.Shippers.Find(id);
            context.Shippers.Remove(shiper_delete);
            try
            {
                context.SaveChanges();
                message = "MUY BIEN SE ELIMINO EL TRANSPORTISTA";
            }
            catch (NotSupportedException)
            {
                throw new NotSupportedException();
            }
            catch (ObjectDisposedException)
            {
                throw new ObjectDisposedException("Id: order_delete");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();

            }
            return message;
        }

        public List<Shippers> GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetByCodigo(string id)
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public string Update(Shippers id)
        {
            throw new NotImplementedException();
        }
    }
}
