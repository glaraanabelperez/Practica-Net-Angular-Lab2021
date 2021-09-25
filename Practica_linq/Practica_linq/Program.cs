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
            //1
            CustomersLogic custLogic = new CustomersLogic();
            //custLogic.Set_Object();
            //String s = custLogic.Get_Object_String(custLogic.custom);
            //Console.WriteLine("Objeto Customer CompanyName.Contains('s')");
            //Console.WriteLine(s);


            //2
            ProductsLogic productsLogic = new ProductsLogic();
            //productsLogic.Set_All_Acording_Unit_Stock(0);
            //Console.WriteLine("Productos sin Stock");
            //Console.WriteLine(productsLogic.Get_IEnumerable_String(productsLogic.products));

            //3
            //productsLogic.GetAll_AcordingToPriceAndStock(3);
            //Console.WriteLine("Productos con Stock y Precio MAyor a 3");
            //Console.WriteLine(productsLogic.Get_IEnumerable_String(productsLogic.products));

            //4
            //CustomersLogic custLogic = new CustomersLogic();
            //custLogic.Set_IEnumerable_Query();
            //Console.WriteLine("Customers de la Region WA");
            //Console.WriteLine(custLogic.Get_IEnumerable_String(custLogic.customers));

            //5
            try
            {
                productsLogic.Set_Object_Acording_Id(11);
                Console.WriteLine("Productos con el id buscado");
                Console.WriteLine(productsLogic.Get_Object_String(productsLogic.product));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Hay un error con el codigo del producto que busca.");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No se encuentra lo que esta buscando");
            }

            //6
            Console.WriteLine("Customers Nombres Mayuscula");

            List<String> nombres=custLogic.Set_All_Acording_Name();
            foreach(var item in nombres)
            {
                Console.WriteLine($"\n Nombre Mayuscula: {item}");
            }
            Console.ReadLine();

        }
    }
}
