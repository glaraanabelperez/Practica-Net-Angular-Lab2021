using Practica_EF_Data;

namespace Practica_EF_Logic
{
    //protected
    public class BaseLogic
    {
        protected readonly NorthwindContext context;
        public BaseLogic()
        {
            context = new NorthwindContext();
        }

    }

}