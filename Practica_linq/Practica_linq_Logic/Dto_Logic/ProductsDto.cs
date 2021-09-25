using System;
using System.Collections.Generic;
using Practica_linq_Entities;

namespace Practica_linq_Logic
{
    public class ProductsDto : BaseLogic
    {
        public Products Product { get; set; }

        public virtual Categories Categories { get; set; }

        public virtual ICollection<Order_Details> Order_Details { get; set; }

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int? SupplierID { get; set; }

        public int? CategoryID { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

        public short? UnitsOnOrder { get; set; }

        public short? ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

      
        //public override string Get_T_TO_String()
        //{
        //    String rstaString;

        //    if (Product != null)
        //    {
        //        rstaString = $" \n Nombre del Producto: {Product.ProductName} \n Nombre Contacto: {Product.ProductID }";
        //    }
        //    else
        //    {
        //        rstaString = "No podemos devolver la informacion!";
        //    }
        //    return rstaString;
        //}
    }
}