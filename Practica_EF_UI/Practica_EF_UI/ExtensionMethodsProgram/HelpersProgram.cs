using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Entities;
using Practica_EF_UI.ExtensionMethodsLogic;

namespace Practica_EF_Logic
{
    //ExtensionMethos seria desde donde se escribe en program y de interactua con logic.
    public static class  HelpersProgram
    {
        public static string CallMenu()
        {
            string typOperation = null;
            do
            {
                typOperation = InteractionUserHelpers.Menu();
            } while (String.IsNullOrEmpty(typOperation));

            return typOperation;
        }
        public static void ListCustomers()
        {
            CustomersLogic customers = new CustomersLogic();

            foreach (Customers cust in customers.GetAll())
            {
                Console.WriteLine($"\n CUSTOMER:");
                Console.WriteLine($"NOMBRE: {cust.ContactName}");
                Console.WriteLine($"ID: {cust.CustomerID}.");
                Console.WriteLine($"REGION: {cust.Region}.");
            }
        }

        // aca aregalr..sino crea un nuevo objeto cada vez que se use
        public static void ListShippers()
        {
            ShippersLogic shippers = new ShippersLogic();
            foreach (Shippers sh in shippers.GetAll())
            {
                Console.WriteLine($"\n SHIPER:");
                Console.WriteLine($"ID: {sh.ShipperID}");
                Console.WriteLine($"COMPANIA: {sh.CompanyName}.");
                Console.WriteLine($"PHONE: {sh.Phone}.");
            }
        }

        public static void ListOrders()
        {
            OrdersLogic ordersLogic = new OrdersLogic();
            foreach (var ord in ordersLogic.GetAll())
            {
                Console.WriteLine($"\n ORDEN:");
                Console.WriteLine($"NUMERO: {ord.Order_Details}.");
                Console.WriteLine($"COMPANIA: {ord.Customers.CompanyName}.");
                Console.WriteLine($"ID CUSTOMERS: {ord.Customers.CustomerID}.");
            }
        }

        public static void ListOrdersDetails(this OrderDetailsLogic ordersLogic)
        {
            foreach (Order_Details ord in ordersLogic.GetAll())
            {
                Console.WriteLine($"\n DETALLE ORDEN:");
                Console.WriteLine($"ID_DETALLE: {ord.OrderID}.");
                Console.WriteLine($"PRECIO UNIDAD: {ord.UnitPrice}.");
            }
        }

        public static void Delete_Shipper(this ShippersLogic shipperLogic, int id)
        {
            try
            {
                shipperLogic.Delete(id);
                Console.WriteLine("Transportista Eliminado");
            }
            catch (NotSupportedException ex)
            {
                throw new NotSupportedException(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                throw new ObjectDisposedException(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException(ex.Message);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public static void Insert_Shipper(this ShippersLogic shipperLo)
        {
            Console.WriteLine(" \n INGRESE NOMBRE DE LA COMPANIA");
            string compani = InteractionUserHelpers.InsertDates();
            try
            {
                Shippers newShip = new Shippers();
                newShip.CompanyName = compani;
                shipperLo.Insert(newShip);
                Console.WriteLine("Shiper Insertado");
            }
            catch (NotSupportedException ex)
            {
                throw new NotSupportedException(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                throw new ObjectDisposedException(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

        public static void GetCustomerById(this CustomersLogic customerLogic, string selection)
        {
            try
            {
                Customers c = customerLogic.GetById(selection);
                Console.WriteLine(" \n LOS DATOS DE CLIENTE SON: ");
                Console.WriteLine($"COMPANIA: {c.CompanyName}. CONTACTO: {c.ContactName}. REGION: {c.Region}.");
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException( ex.Message);
            }
            catch (System.InvalidOperationException ex)
            {
                throw new System.InvalidOperationException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateCustomerById( this CustomersLogic customerLogic, string selectionIdCustomers)
        {
            Console.WriteLine("\n QUIERE  EDITAR EL NOMBRE DEL CONTACTO DEL CLIENTES?");
            String rsta = Practica_EF_UI.ExtensionMethodsLogic.InteractionUserHelpers.Continuar();
            rsta = rsta.ToUpper();
            if (rsta.Equals("SI"))
            {
                string newDate = null;
                Console.WriteLine(" \nINGRESE UN NUEVO NOMBRE DE CONTACTO");
                newDate = InteractionUserHelpers.InsertDates();
                Console.WriteLine(newDate);
                try
                {
                    Customers customers = new Customers();
                    customers.ContactName = newDate;
                    customers.CustomerID = selectionIdCustomers.ToUpper();
                    customerLogic.Update(customers);
                }
                catch (ObjectDisposedException ex)
                {
                    throw new ObjectDisposedException(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException(ex.Message);

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);

                }
            }
        }

   }
}
