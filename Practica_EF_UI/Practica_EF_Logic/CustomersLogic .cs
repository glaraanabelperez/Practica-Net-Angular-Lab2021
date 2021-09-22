using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Entities;

namespace Practica_EF_Logic
{
    public class CustomersLogic : BaseLogic
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
        public Customers GetById(string codigo)
        {
            Customers cust = null;
            try
            {
              cust= (from c in context.Customers
                where c.CustomerID.Equals(codigo)
                select c).Single();
                    return cust;
            }
            catch (System.InvalidOperationException)
            {
                throw new System.InvalidOperationException();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }


    }
}
