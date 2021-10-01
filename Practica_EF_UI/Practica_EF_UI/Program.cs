using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Entities;
using Practica_EF_Logic;
using Practica_EF_UI.ExtensionMethodsLogic;

namespace Practica_EF_UI
{
    class Program 
    {
        static void Main(string[] args)
        {
            string typOperation="";
            do
            {
                if (typOperation.Equals("MENU") || typOperation=="")
                {
                    typOperation = HelpersProgram.CallMenu();
                    typOperation=typOperation.ToUpper();
                }
                typOperation = InitOperation(typOperation);

            } while (!typOperation.Equals("FIN"));

            Console.WriteLine("HASTA LUEGO!!");

        }

        public static string InitOperation(string typOperation)
        {
            string changeOperation = "no";

            switch (typOperation)
            {

                case "ORDERS":
                    Console.WriteLine(" \n ORDERS");
                    HelpersProgram.ListOrders();

                    Console.WriteLine(" \n QUIERE ACCEDER AL CLIENTE DE LA ORDEN?");
                    changeOperation = InteractionUserHelpers.Continuar();
                    changeOperation = changeOperation.ToUpper();

                    if (changeOperation.Equals("SI"))
                    {
                        return "CUSTOMERS";
                    }
                    else
                    {
                        Console.WriteLine(" \nESTA INGRESANDO DATOS INVALIDOS");
                        return "MENU";
                    }


                case "ORDER_DETAILS":
                    Console.WriteLine(" \n ORDER_DETAILS");
                    OrderDetailsLogic ordersLogic = new OrderDetailsLogic();
                    ordersLogic.GetAll();

                    break;


                case "CUSTOMERS":
                    CustomersLogic customerLogic = new CustomersLogic();
                    string selectionIdCustomers = null;

                    Console.WriteLine(" \n CUSTOMERS");
                    HelpersProgram.ListCustomers();

                    Console.WriteLine(" \n INGRESE CODIGO A BUSCAR DE LOS INDICADOS ANTERIORMENTE");
                    do
                    {
                        selectionIdCustomers = InteractionUserHelpers.InsertDates();
                        changeOperation = changeOperation.ToUpper();
                        Console.WriteLine($" \n CODIGO SELECCIONADO: {selectionIdCustomers}");
//Ver bucle
                        try
                        {
                            customerLogic.UpdateCustomerById(selectionIdCustomers);
                            try
                            {
                                customerLogic.GetCustomerById(selectionIdCustomers);
                                selectionIdCustomers = null;
                            }
                            catch (ArgumentNullException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (System.InvalidOperationException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        catch (ObjectDisposedException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                    } while (selectionIdCustomers == null);

                    return "MENU";

                case "SHIPPERS":

                    Console.WriteLine(" \n SHIPPERS");
                    ShippersLogic shipperLo = new ShippersLogic();
                    HelpersProgram.ListShippers();

                    Console.WriteLine(" \n DESEA ELIMINAR (E) o INSERTAR (I) UN TRANSPORTE?");
                    string selection = InteractionUserHelpers.InsertDates();
                    selection = selection.ToUpper();

                    if (selection.Equals("E"))
                    {
                        Console.WriteLine(" \n SELECCIONE UN ID DEL TRANSPORTE A ELIMINAR");
                        int idShipper = InteractionUserHelpers.InsertNumber();
                        try
                        {
                            shipperLo.Delete_Shipper(idShipper);
                        }
                        catch (NotSupportedException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (ObjectDisposedException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    if (selection.Equals("I"))
                     {
                        try
                        {
                            shipperLo.Insert_Shipper();
                        }
                        catch (NotSupportedException ex)
                        {
                           Console.WriteLine(ex.Message);
                        }
                        catch (ObjectDisposedException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);

                        }
                    }
                    HelpersProgram.ListShippers();

                    return "MENU";

                case "SALIR":
                    return "FIN";

                default:
                    Console.WriteLine($"INGRESE UNA OPCION");
                    break;
            }
            return "MENU";
        }

    }
}


