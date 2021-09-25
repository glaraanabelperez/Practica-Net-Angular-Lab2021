using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica_linq_Data;
using Practica_linq_Entities;
using Practica_linq_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_linq_Logic.Tests_tp_05
{
    [TestClass()]
    public class CustomersLogicTestReturnCustomer : BaseLogic
    {
        [TestMethod()]
        public void GetObjectTest()
        {
            //Arrange
            Customers cust_expected = new Customers();
            NorthwindContext context = new NorthwindContext();

            //Actual
            Customers cust_actual = new Customers();

            cust_actual = context.Customers.Single(Customers => Customers.CompanyName.Contains("a"));

            //Assert
            Assert.Equals(cust_actual, cust_expected);
        }
    }
}