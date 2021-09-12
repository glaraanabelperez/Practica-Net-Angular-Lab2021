using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExtensionMethods.ExtensionMethodsHelpers
{
    public static class ValidationsAndConversions
    {
        public static int ConversionStringToNumber(this String entrie)
        {
            int number = 0, i = 0;
            bool result = int.TryParse(entrie, out i); //i now = 108  
            if (! result)
                throw new FormatException();
            number = int.Parse(entrie);

            return number;
        }
    }
}
