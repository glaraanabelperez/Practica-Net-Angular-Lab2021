using System;
using System.Collections.Generic;
using System.Linq;
using Practica_linq_Entities;

namespace Practica_linq_Logic
{
    public partial class ProductsLogic : BaseLogic, IABMLogic<Products>
    {
        public Products product { get; set; }
        public IEnumerable<Products>  products { get; set; }


        public void Set_Object_Acording_Stock(int x)
        {
            product = context.Products.First(p => p.UnitsInStock == x);
        }
        public void Set_Object_Acording_Id(int x)
        {
            try
            {
                product = context.Products.First(p => p.ProductID == x);
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException();
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
        }
        public void Set_All_AcordingToPriceAndStock(decimal x)
        {
            products = context.Products
            .Where(p => p.UnitsInStock!=0 && p.UnitPrice>x);
        }
        public void Set_All_Acording_Unit_Stock(int x)
        {
            products = context.Products.Where(p => p.UnitsInStock == 0);
        }
        public String Get_IEnumerable_String(IEnumerable<Products> customers)
        {
            //
            String rstaString=null;
            if (products!=null)
            {
                foreach (var p in products)
                {
                    rstaString += "\n";
                    rstaString += $"\n Producto: { p.ProductName}\n Id_Categoria: {p.CategoryID}\n Precio: {p.UnitPrice}\n Stock: {p.UnitsInStock}";
                }
            }
            else
            {
                rstaString = "No podemos devolver la informacion!";
            }
            
            return rstaString;
        }
        public string Get_Object_String(Products obj)
        {
            String rstaString;
            if (product != null)
            {
                rstaString = $" \n Nombre del Producto: {obj.ProductName} \n Nombre Contacto: {obj.ProductID }";
            }
            else
            {
                rstaString = "No podemos devolver la informacion!";
            }
            return rstaString;
        }
        public void Set_All_Acording_Region(string s)
        {
            throw new NotImplementedException();
        }
    }
}
