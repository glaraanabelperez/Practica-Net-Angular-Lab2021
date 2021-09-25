using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_linq_Data;


namespace Practica_linq_Entities
{
    public class BaseLogic : BaseEntities
    {
        protected readonly NorthwindContext context;
        public BaseEntities ObjectResponse;

        public BaseLogic()
        {
            context = new NorthwindContext();
        
        }

    }
}
