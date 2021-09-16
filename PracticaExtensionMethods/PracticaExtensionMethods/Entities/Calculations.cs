using System;

namespace ExcerciseExtensionMethods.Entities
{
    public abstract class Calculations
    {
        public int Divisor {get; set;}
        public String Message { get; set; }

        public Calculations(int divisor)
            {
            this.Divisor = divisor;
            }

        public abstract Tuple<bool, int> ConversionStringToNumber(string entrada);

        public abstract void MessageResult(string tipeMessage);

        public abstract int CalculateDivisionsByZero(int dividendo);



    }
}
