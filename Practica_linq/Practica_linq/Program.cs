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


            ////1
            //Console.WriteLine("Customer con la letra 's' en su nombre");

            //custLogic.Set_Custom_Acording_Name();
            //String s = custLogic.Get_T_String(custLogic.custom);
            //Console.WriteLine(s);


            ////2
            //Console.WriteLine("Productos sin Stock");

            //productsLogic.Set_All_Acording_Unit_Stock(0);
            //Console.WriteLine(productsLogic.Get_IEnumerable_String(productsLogic.products));

            ////3
            //Console.WriteLine("Productos con Stock y Precio MAyor a 3");

            //productsLogic.Set_All_Acording_Price_Stock(3);
            //Console.WriteLine(productsLogic.Get_IEnumerable_String(productsLogic.products));

            ////4
            //Console.WriteLine("Customers de la Region WA");

            //custLogic.Set_All_Acording_Region("WA");
            //Console.WriteLine(custLogic.Get_IEnumerable_String(custLogic.customers));

            ////5
            //Console.WriteLine("Productos con el id buscado");
            //try
            //{
            //    productsLogic.Set_Object_Acording_Id(11);
            //    Console.WriteLine(productsLogic.Get_T_String(productsLogic.product));
            //}
            //catch (ArgumentNullException)
            //{
            //    Console.WriteLine("Hay un error con el codigo del producto que busca.");
            //}
            //catch (InvalidOperationException)
            //{
            //    Console.WriteLine("No se encuentra lo que esta buscando");
            //}

            //6
            Console.WriteLine("Customers Nombres Convertidos");

            List<String> nombres = custLogic.Set_All_Acording_Name();
            Console.WriteLine(custLogic.Get_All__ToString(nombres));

            ////7
            //Console.WriteLine("Join entre Customers y Orders");
            //custLogic.Set_Custom_Join_Region_Orders("WA");
            //Console.WriteLine(custLogic.Get_All_CustomerDto_ToString(custLogic.customDto));


            Console.ReadLine();

        }
    }
}
