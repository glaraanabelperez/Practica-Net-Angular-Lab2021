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
    public static class  HelpersProgramLogic
    {
        public static string CallMenu()
        {
            string typOperation = null;
            do
            {
                typOperation = InteractionUser.Menu();
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
            foreach (Orders ord in ordersLogic.GetAll())
            {
                Console.WriteLine($"\n ORDEN:");
                Console.WriteLine($"NUMERO: {ord.OrderID}.");
                Console.WriteLine($"COMPANIA: {ord.Customers.CompanyName}.");
                Console.WriteLine($"ID CUSTOMERS: {ord.Customers.CustomerID}.");
            }
        }

        public static void ListOrdersDetails( this OrderDetailsLogic ordersLogic)
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
            catch (NotSupportedException)
            {
                throw new NotSupportedException();
            }
            catch (ObjectDisposedException)
            {
                throw new ObjectDisposedException("Id: shipper_delete");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
        }

        public static void Insert_Shipper(this ShippersLogic shipperLo)
        {
            string compani = InteractionUser.InsertDataAndCheck("NOMBRE DE LA COMPANIA");
            try
            {
                Shippers newShip = new Shippers();
                newShip.CompanyName = compani;
                shipperLo.Insert(newShip);
                Console.WriteLine("Shiper INsertado");
            }
            catch (NotSupportedException)
            {
                throw new NotSupportedException();
            }
            catch (ObjectDisposedException)
            {
                throw new ObjectDisposedException("Id: shipper_delete");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();

            }

        }
        public static Customers GetCustomerById(this CustomersLogic custom, string selection)
        {
            try
            {   
                Customers c = custom.GetById(selection);
                return c;
            }
            catch (Exception ex)
            {
                throw ex;
            }    
        }

        public static void UpdateCustomerById( this CustomersLogic customerLogic, Customers custom)
        {     
                string newData = null;
                newData = InteractionUser.InsertDataAndCheck("NUEVO NOMBRE");          
                try
                {
                    if (customerLogic.Exist(custom.CustomerID) != null)
                    {
                        custom.ContactName = newData;
                        InteractionUser.WriteMessage("EDICION " + customerLogic.Update(custom));
                    }
                    else
                    {
                        InteractionUser.WriteMessage("\nHUBO UN PROBLEMA CON LOS DATOS DE CLIENTES, PUEDE QUE NO ESTEN ENTRE LOS DATOS");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                } 

        }

   }
}
