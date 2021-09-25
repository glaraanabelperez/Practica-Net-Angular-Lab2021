using System;
using System.Collections.Generic;
using System.Linq;
using Practica_linq_Entities;

namespace Practica_linq_Logic
{
    public partial class ProductsLogic : ProductsDto
    {
        //public Products product { get; set; }
        public IEnumerable<Products> products { get; set; }
        public IEnumerable<ProductsDto> productsDto { get; set; }


        public void Set_Product_By_Stock(int x)
        {
            Product = context.Products.First(p => p.UnitsInStock == x);
        }
        public void Set_Product_By_Id(int x)
        {
            try
            {
                Product = context.Products.First(p => p.ProductID == x);
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
        public void Set_All_Acording_Price_Stock(decimal x)
        {
            productsDto = context.Products
            .Where(p => p.UnitsInStock!=0 && p.UnitPrice>x)
            .Select( p => new ProductsDto { 
                ProductName=p.ProductName,
                UnitPrice=p.UnitPrice,
                UnitsInStock=p.UnitsInStock
            });
        }
        public void Set_All_Acording_Unit_Stock(int x)
        {
            products = context.Products.Where(p => p.UnitsInStock == 0);
        }
        public String Get_ProductsDto_ToString(IEnumerable<ProductsDto> customers)
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

        public string Get_T_TO_String()
        {
            String rstaString;

            if (Product != null)
            {
                rstaString = $" \n Nombre del Producto: {Product.ProductName} \n Nombre Contacto: {Product.ProductID }";
            }
            else
            {
                rstaString = "No podemos devolver la informacion!";
            }
            return rstaString;
        }

        public string Get_IEnumerable_TO_String(IEnumerable<Products> t)
        {
            throw new NotImplementedException();
        }
    }
}
