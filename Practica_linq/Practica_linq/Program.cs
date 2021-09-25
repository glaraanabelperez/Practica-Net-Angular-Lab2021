using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_linq_Entities;
using Practica_linq_Logic;

namespace Practica_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomersLogic custLogic = new CustomersLogic();
            ProductsLogic productsLogic = new ProductsLogic();

            //1
            Console.WriteLine("\n 1 Customer con la letra 's' en su nombre");

            custLogic.Set_customCustomer_Acording_Name();
            String s = custLogic.Get_customCustomer_TO_String();
            Console.WriteLine(s);


            //2
            Console.WriteLine("\n 2 Productos sin Stock");

            productsLogic.Set_ProductsDto_By_Unit_Stock( 0 );
            Console.WriteLine(productsLogic.Get_ProductsDto_ToString(productsLogic.productsDto));

            //3
            Console.WriteLine(" \n 3 Productos con Stock y Precio MAyor a 3");

            productsLogic.Set_ProductsDto_By_Price_Stock( 3 );
            Console.WriteLine(productsLogic.Get_ProductsDto_ToString(productsLogic.productsDto));

            //4
            Console.WriteLine("\n 4 Customers de la Region WA");

            custLogic.Set_Customers_Dto_By_Region("WA");
            Console.WriteLine(custLogic.Get_Customers_Dto_To_String());

            //5
            Console.WriteLine("\n 5 Productos con el id buscado");
            try
            {
                productsLogic.Set_Product_By_Id( 789 );
                Console.WriteLine(productsLogic.Get_Product_TO_String());
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("\n Hay un error con el codigo del producto que busca.");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("\n No se encuentra lo que esta buscando");
            }

            //6
            Console.WriteLine("\n 6 Customers Nombres Convertidos");

            List<String> nombres = custLogic.Set_Customers_Dto_By__Name();
            Console.WriteLine(custLogic.Get_List_TO_ToString(nombres));

            ////7
            Console.WriteLine("\n 7 Set Custom_DTO JOin Customer-Orders");
            custLogic.Set__Customers_Dto_join_Orders("WA");
            Console.WriteLine(custLogic.Get_Customers_Dto_ToString_Date());

            Console.WriteLine("\n Fin");


            Console.ReadLine();

        }
    }
}
