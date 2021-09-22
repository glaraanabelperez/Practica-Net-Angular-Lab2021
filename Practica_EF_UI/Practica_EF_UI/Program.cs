using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Entities;
using Practica_EF_Logic;
using Practica_EF_Logic.ExtensionMethodsLogic;

namespace Practica_EF_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdersLogic ordersLogic = new OrdersLogic();
            Console.WriteLine($"Ordenes disponibles:");

            foreach (Orders ord in ordersLogic.GetAllOrders())
            {
                Console.WriteLine($" \n Ordenes:");
                Console.WriteLine($"Numero_orden: {ord.OrderID}. Compania: {ord.Customers.CompanyName}. IdCustomer: {ord.Customers.CustomerID}.");
            }
            //Console.ReadLine();
            string selection = null;
            try
            {
                selection = InteractionUserHelpers.InsertCodigoString();
                Console.WriteLine($"Codigo Cliente: {selection}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //do while;retunr??
            Console.WriteLine("Datos del Clientes:");

            CustomersLogic custom = new CustomersLogic();
            try
            {
                Customers c = custom.GetDatesCustomer(selection);
                Console.WriteLine($"Compania: {c.CompanyName}. Contacto: {c.CompanyName}. IdCustomer: {c.CustomerID}. Region: {c.Region}.");
                Console.WriteLine("Los datos del Cliente son: ");
            }
            catch (System.InvalidOperationException ex)
            {
                Console.WriteLine("El cliente no existe" + ex.Message);
                //Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}


