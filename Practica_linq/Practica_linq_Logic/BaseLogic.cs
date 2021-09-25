using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_linq_Data;


namespace Practica_linq_Entities
{
    public  class BaseLogic 
    {
        protected readonly NorthwindContext context;

        public BaseLogic()
        {
            context = new NorthwindContext();
        }

        //public abstract string Get_T_TO_String();


    }
}
