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
        public void ProductOutsideStock()
        {
            //Arrange
            int x = 0;
            ProductsLogic prod_actual = new ProductsLogic();
            Products Product = new Products();

            //Actual
            Product=prod_actual.get_Product_By_Unit_Stock(x);

            //var result=context.Customers.First(Customers => Customers.CompanyName.Contains("a"));
            //context.Products.First(p => p.UnitsInStock == x);

            //Assert
            Assert.AreEqual(prod_actual.ProductID, Product.ProductID);
            //Assert.IsInstanceOfType()
        }

      }
}
