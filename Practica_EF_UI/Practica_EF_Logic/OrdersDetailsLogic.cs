using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Entities;

namespace Practica_EF_Logic
{
    public class OrderDetailsLogic : BaseLogic, IABMLogic<Order_Details>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public List<Order_Details> GetAll()
        {
            return context.Order_Details.ToList();
        }
        public void GetByCodigo(string id)
        {
            throw new NotImplementedException();
        }
        public void GetById(int id)
        {
            throw new NotImplementedException();
        }
        public string Update(Order_Details id)
        {
            throw new NotImplementedException();
        }
        public void Insert(Shippers newShiper)
        {
            throw new NotImplementedException();
        }
    }
}
