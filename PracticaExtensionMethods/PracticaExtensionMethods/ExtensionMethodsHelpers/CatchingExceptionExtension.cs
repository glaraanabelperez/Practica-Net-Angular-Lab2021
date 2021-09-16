using System;

namespace ExcerciseExtensionMethods.ExtensionMethodsHelpers
{
    public static class CatchingExceptionExtension
    {
        public static Tuple<bool, int> ThrowingFormatExceptionAndNumber(this String entrie)
        {
            int i = 0;
            bool result = int.TryParse(entrie, out i); //i now = 108

            if (!result)
                throw new FormatException();

             return Tuple.Create(true, i);
        }

        public static int ThrowingDividenByZero(this  int divisor, int dividendo)
        {
            if (divisor == 0)
                throw new DivideByZeroException();
            return dividendo / divisor;
        }

    }
}
