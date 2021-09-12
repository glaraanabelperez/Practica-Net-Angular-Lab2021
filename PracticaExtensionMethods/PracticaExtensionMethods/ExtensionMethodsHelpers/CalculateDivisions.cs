using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExtensionMethods.ExtensionMethodsHelpers
{
    public static class CalculationValidations
    {
        public static int CalculateDivisionsForCero(this int dividendo)
        {
            int divisor = 0;
            if (divisor == 0)
                throw new DivideByZeroException();

            return dividendo / divisor;
        }

        public static int CalculateDivisionsForCero(this int dividendo, int divisor )
        {
            if (divisor == 0)
                throw new DivideByZeroException();

            return divisor / dividendo;
        }

    }
}
