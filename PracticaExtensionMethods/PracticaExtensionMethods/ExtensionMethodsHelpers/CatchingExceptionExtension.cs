using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExtensionMethods.ExtensionMethodsHelpers
{
    public static class CatchingExceptionExtension
    {
        public static Tuple<bool, int> ConversionStringToNumber(this String entrie)
        {
            int i = 0;
            bool result = int.TryParse(entrie, out i); //i now = 108

            if (!result)
                throw new FormatException();

             return Tuple.Create(true, i);
        }

        public static int DividingAndCatchingException(this  int divisor, int dividendo)
        {
            if (divisor == 0)
                throw new DivideByZeroException();
            return dividendo / divisor;
        }

    }
}
