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
            string typOperation;
            typOperation=CallMenu();

            do
            {
                typOperation = InitOperation(typOperation);

            } while (!typOperation.Equals("INICIO"));

            Console.ReadLine();

        }

        public static string InitOperation(string typOperation)
        {
            string changeOperation = "no";

            switch (typOperation)
            {
                case "ORDERS":
                    ListOrders();
                    Console.WriteLine(" \n QUIERE ACCEDER AL CLIENTE DE LA ORDEN?");
                    changeOperation = InteractionUserHelpers.Continuar();

                    if (changeOperation.Equals("si"))
                    {
                        return "CUSTOMERS";
                    }
                    else
                    {
                        return "INICIO";
                    }

                case "ORDER_DETAILS":
                    OrderDetailsLogic ordersLogic = new OrderDetailsLogic();
                    ListOrdersDetails(ordersLogic);
                    break;

                case "CUSTOMERS":
                    CustomersLogic customerLogic = new CustomersLogic();
                    string selectionIdCustomers;
                    Console.WriteLine("BIENVENIDOS A CUSTOMERS");
                    Console.WriteLine("INGRESE CODIGO A BUSCAR DE LOS INDICADOS ANTERIORMENTE");
                    try
                    {
                        selectionIdCustomers = InteractionUserHelpers.InsertDates();
                        Console.WriteLine($"\n CODIGO SELECCIONADO: {selectionIdCustomers}");
                        GetCustomerById(customerLogic, selectionIdCustomers);
                        UpdateCustomerById(customerLogic, selectionIdCustomers);
                    }
                    catch (NullReferenceException)
                    {
                        Console.WriteLine("NO AH INHGRESADO NINGUN DATO");
                    }
                    return "INICIO";

                case "SHIPPERS":
                    ShippersLogic shipperLo = new ShippersLogic();
                    shipperLo.GetAll();

                    Console.WriteLine("Seleccione numero del iD_Shipper para eliminar o ingrese nuevo numero en cado de Agregar in Transporte");
                    int idShipper;
                    try
                    {
                        idShipper = InteractionUserHelpers.InsertNumber();
                        Console.WriteLine("Desea Eliminar (e) o Insertar (i) un Transporte?");
                        string selection = InteractionUserHelpers.InsertDates();
                        if (selection.Equals("e"))
                        {
                            Delete_Shipper(shipperLo, idShipper);
                            shipperLo.GetAll();
                        }
                        if (selection.Equals("i"))
                        {
                            Insert_Shipper(shipperLo, idShipper);
                            shipperLo.GetAll();
                        }

                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("No ha podido realizar la operacion");
                    }
                    return "INICIO";

                default:
                    Console.WriteLine($"INGRESE UNA OPCION");
                    break;
            }
            return "INICIO";
        }
        public static string CallMenu()
        {
            string typOperation = null;
            do
            {
                typOperation = InteractionUserHelpers.Menu();
            } while (String.IsNullOrEmpty(typOperation));

            return typOperation;
        }
        public static void ListOrders()
        {
            OrdersLogic ordersLogic = new OrdersLogic();

            Console.WriteLine($"Ordenes Disponibles:");
            foreach (Orders ord in ordersLogic.GetAll())
            {
                Console.WriteLine($"Orden:");
                Console.WriteLine($"Numero_orden: {ord.OrderID}.");
                Console.WriteLine($"Compania: {ord.Customers.CompanyName}.");
                Console.WriteLine($"IdCustomer: {ord.Customers.CustomerID}.");
            }
        }
        public static void ListOrdersDetails(OrderDetailsLogic ordersLogic)
        {
            Console.WriteLine($"DETALLE ORDEN:");
            foreach (Order_Details ord in ordersLogic.GetAll())
            {
                Console.WriteLine($"Id Detalle: {ord.OrderID}.");
                Console.WriteLine($"Precio unidad: {ord.UnitPrice}.");
            }
        }
        public static void Delete_Shipper(ShippersLogic shipperLogic, int id)
        {
            try
            {
                shipperLogic.Delete(id);
                Console.WriteLine("Transportista Eliminado");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("HUBO UN PROBLEMA CON LA CONSULTA.");
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("EL TRANSPORTISTA NO SE HA ENCONTRADO.");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("EL TRANSPORTISTA NO SE PUEDE EDITAR.");

            }
        }
        public static void Insert_Shipper(ShippersLogic shipperLogic, int id)
        {
           
            try
            {
                Shippers newShip = new Shippers();
                newShip.CompanyName = "Mercadores";
                newShip.ShipperID = id;
                shipperLogic.Insert(newShip);
                Console.WriteLine("Shiper INsertado");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("HUBO UN PROBLEMA CON LA CONSULTA.");
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("EL TRANSPORTISTA NO SE HA ENCONTRADO.");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("EL TRANSPORTISTA NO SE PUEDE EDITAR.");

            }
        }
        public static void GetCustomerById(CustomersLogic custom, string selection) {
            try
            {
                custom.GetByCodigo(selection);
                Customers c = custom.customer;
                Console.WriteLine("Los datos del Cliente son: ");
                Console.WriteLine($"Compania: {c.CompanyName}. " +
                    $"Contacto: {c.CompanyName}. Region: {c.Region}.");
            }
            catch (System.InvalidOperationException)
            {
                throw new System.InvalidOperationException();
            }
        }
        public static void UpdateCustomerById(CustomersLogic customerLogic, string selectionIdCustomers)
        {
            try
            {
                Console.WriteLine("\n QUIERE  EDITAR EL NOMBRE DEL CONTACTO DEL CLIENTES?");
                if (InteractionUserHelpers.Continuar().Equals("si"))
                {
                    string newDate = null;
                    do
                    {
                        Console.WriteLine("INGRESE UN NUEVO NOMBRE DE CONTACTO");
                        try
                        {
                            newDate = InteractionUserHelpers.InsertDates();
                        }
                        catch (System.InvalidOperationException)
                        {
                            Console.WriteLine($"LOS DATOS NO PUEDE QUEDAR VACIOS");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"OPS ALGO AH SALIDO MAL!");
                        }
                    } while (newDate == null);

                    try
                    {
                        Customers customers = new Customers();
                        customers.ContactName = newDate;
                        customerLogic.Update(customers);
                    }
                    catch (NotSupportedException)
                    {
                        Console.WriteLine("HUBO UN PROBLEMA CON LA CONSULTA.");
                    }
                    catch (ObjectDisposedException)
                    {
                        Console.WriteLine("EL CUSTOMER NO SE HA ENCONTRADO.");
                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine("EL CUSTOMER NO SE PUEDE EDITAR.");

                    }
                    GetCustomerById(customerLogic, selectionIdCustomers);
                }
            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine($"LOS DATOS NO PUEDEN SER NULOS!");
            }
            catch (Exception)
            {
                Console.WriteLine($"OPS ALGO AH SALIDO MAL!");
            }
        }
    }
}


