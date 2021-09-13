using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExtensionMethods.ExtensionMethodsHelpers
{
    public static class CatchingExceptionExtension
    {
        public static int[] ConversionStringToNumber(this String entrie)
        {
            //objetos anonimos....
            int i = 0;
            bool result = int.TryParse(entrie, out i); //i now = 108
            int [] resultToSend = new int[2];

            if (!result)
                throw new FormatException();

            else
            {
                resultToSend[0] = 1;
                resultToSend[1] = i;
            }
            //poner true, 
            return resultToSend;
        }

        public static int DividingAndCatchingException(this  int divisor, int dividendo)
        {
            if (divisor == 0)
                throw new DivideByZeroException();

            return dividendo / divisor;
        }

    }
}
