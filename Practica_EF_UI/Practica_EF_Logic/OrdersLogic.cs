using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Entities;

namespace Practica_EF_Logic
{
    public class OrdersLogic : BaseLogic, IABMLogic<Orders>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public List<Orders> GetAll()
        {
            return context.Orders.ToList();
        }
        public void GetByCodigo(string id)
        {
            throw new NotImplementedException();
        }
        public void GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Insert(Shippers newShiper)
        {
            throw new NotImplementedException();
        }
        public string Update(Orders c)
        {
            throw new NotImplementedException();
        }
    }
}
