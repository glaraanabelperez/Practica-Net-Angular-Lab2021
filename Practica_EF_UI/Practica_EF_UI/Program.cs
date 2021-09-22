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
            string entrie=InteractionUserHelpers.Menu();
            switch (entrie)
            {
                case "Orders":
                    ListOperations();
                    string selection;
                    try
                    {
                        selection = InteractionUserHelpers.SelectionID();
                        Console.WriteLine($"CODIGO SELECCIONADO: {selection}");
                        try
                        {
                            GetCustomerById(selection);
                        }
                        catch (System.InvalidOperationException)
                        {
                            Console.WriteLine($"El cliente no existe");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"Ops algo salio mal!");
                        }
                    }
                    catch (NullReferenceException)
                    {
                        Console.WriteLine("Debe Ingresar una opcion para poder operar o salir del sistema");
                    }

                    break;

                case "Order_Details":
                    Console.WriteLine($"Measured value is  too high.");
                    break;

                case "Customers":
                    Console.WriteLine($"Measured value is too high.");
                    break;

                case "Shippers":
                    Console.WriteLine("Failed measurement.");
                    break;

                default:
                    Console.WriteLine($"Measured value is .");
                    break;
            }

 
            Console.ReadLine();

        }

        public static void ListOperations()
        {
            OrdersLogic ordersLogic = new OrdersLogic();

            Console.WriteLine($"Ordenes Disponibles:");
            foreach (Orders ord in ordersLogic.GetAllOrders())
            {
                Console.WriteLine(ord.ToString());
                
                //Console.WriteLine($"Orden:");
                //Console.WriteLine($"Numero_orden: {ord.OrderID}.");
                //Console.WriteLine($"Compania: {ord.Customers.CompanyName}.");
                //Console.WriteLine($"IdCustomer: {ord.Customers.CustomerID}.");

            }
        }
        public  static void  GetCustomerById(string selection) {

            CustomersLogic custom = new CustomersLogic();
            try
            {
                Customers c = custom.GetById(selection);
                Console.WriteLine("Los datos del Cliente son: ");
                Console.WriteLine($"Compania: {c.CompanyName}. " +
                    $"Contacto: {c.CompanyName}. Region: {c.Region}.");
            }
            catch (System.InvalidOperationException)
            {
                throw new System.InvalidOperationException();
            }
 

        }
    }
}


