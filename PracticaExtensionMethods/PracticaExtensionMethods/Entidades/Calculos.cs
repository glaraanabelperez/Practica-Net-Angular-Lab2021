using System;
using PracticaExtensionMethods.Entidades;

namespace PracticaExtensionMethods.Clases
{
    public abstract class Calculos
    {
        protected int Divisor {get; set;}
        public String Message { get; set; }

        public Calculos(int divisor)
            {
            this.Divisor = divisor;
            }

        public abstract int [] ConversionStringToNumber(string entrada);

        public abstract void MessageResult(string tipeMessage);

        public abstract int CalculateDivisionsByZero(int dividendo);

        public abstract int CalculateDivisions(int dividendo, int divisor);


    }
}
