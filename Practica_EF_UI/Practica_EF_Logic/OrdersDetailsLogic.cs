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
        public string Delete(string obj)
        {
            throw new NotImplementedException();
        }

        public string Delete(int obj)
        {
            throw new NotImplementedException();
        }

        public List<Order_Details> GetAll()
        {
            return context.Order_Details.ToList();
        }

        public Order_Details GetById(string obj)
        {
            throw new NotImplementedException();
        }

        public Order_Details GetById(int obj)
        {
            throw new NotImplementedException();
        }

        public string Insert(Order_Details obj)
        {
            throw new NotImplementedException();
        }

        public string Update(Order_Details obj)
        {
            throw new NotImplementedException();
        }
    }
}
