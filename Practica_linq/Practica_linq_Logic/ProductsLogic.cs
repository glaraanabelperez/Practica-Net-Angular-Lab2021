using System;
using System.Collections.Generic;
using System.Linq;
using Practica_linq_Entities;

namespace Practica_linq_Logic
{
    public partial class ProductsLogic : ProductsDto
    {
      
        public IEnumerable<ProductsDto> productsDto { get; set; }

        //Metodo solo para UNitest
        public Products get_Product_By_Unit_Stock(int x)
        {
            Products pd = new Products();
            try
            {
                pd = context.Products.First(p => p.UnitsInStock == x);
                return pd;
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Sin coincidencias");
            }
            catch (Exception)
            {
                Console.WriteLine("Sin coincidencias");
            }
            return pd;
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

        public void Set_ProductsDto_By_Price_Stock(decimal precioMayorTres)
        {
            short stockCero = 0;
            productsDto = context.Products
            .Where(p => p.UnitsInStock > stockCero && p.UnitPrice> precioMayorTres)
            .Select( p => new ProductsDto { 
                ProductName=p.ProductName,
                ProductID=p.ProductID,
                UnitPrice=p.UnitPrice,
                UnitsInStock=p.UnitsInStock
            });
        }

        public void Set_ProductsDto_By_Unit_Stock(int x)
        {
            productsDto = context.Products.
                Where(p => p.UnitsInStock == x)
                .Select(
                    p => new ProductsDto
                    {
                        ProductName = p.ProductName,
                        ProductID = p.ProductID,
                        UnitPrice = p.UnitPrice,
                        UnitsInStock = p.UnitsInStock
                    }
                );
        }

        public String Get_ProductsDto_ToString(IEnumerable<ProductsDto> products)
        {
            //
            String rstaString=null;
            if (products!=null)
            {
                foreach (var p in products)
                {
                    rstaString += "\n";
                    rstaString += $"\n Producto: { p.ProductName}\n Id_producto: {p.ProductID}\n Precio: {p.UnitPrice}\n Stock: {p.UnitsInStock}";
                }
            }
            else
            {
                rstaString = "No podemos devolver la informacion!";
            }
            
            return rstaString;
        }

        public string Get_Product_TO_String()
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

    }
}
