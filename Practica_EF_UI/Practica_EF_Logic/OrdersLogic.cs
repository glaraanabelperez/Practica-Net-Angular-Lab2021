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
        public string Delete(string obj)
        {
            throw new NotImplementedException();
        }
        public string Delete(int obj)
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetAll()
        {
            return context.Orders.ToList();
        }

        public Orders GetById(string obj)
        {
            throw new NotImplementedException();
        }

        public Orders GetById(int obj)
        {
            throw new NotImplementedException();
        }

        public string Insert(Orders obj)
        {
            throw new NotImplementedException();
        }

        public string Update(Orders obj)
        {
            throw new NotImplementedException();
        }
    }
}
