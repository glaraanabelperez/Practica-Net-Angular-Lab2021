using System;


namespace PracticaExtensionMethods.Clases
{
    public abstract class CalculationsOfDivisions
    {
        protected int Divisor {get; set;}
        public String Message { get; set; }

        public CalculationsOfDivisions(int divisor)
            {
            this.Divisor = divisor;
            }


        public abstract void MessageResult(String tipeMessage);

        public abstract int CalculateDivisionsForCero(int dividendo);

        public abstract int CalculateDivisions(int dividendo, int divisor);

        protected abstract int ConversionToDivisons(string entrada);

        protected int DividingAndCatchingException(int dividendo)
        {
            if (Divisor == 0)
                throw new DivideByZeroException();

            return dividendo / Divisor;
        }



    }
}
