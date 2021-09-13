
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaExtensionMethods.ExtensionMethodsHelpers;

namespace PracticaExtensionMethods.Clases
{
    public class DividingForZero : Calculos
    {
        public DividingForZero() : base(0)
        {

        }
        public override void MessageResult(String tipMessage)
        {
            if (tipMessage.Equals("DivideByZeroException"))
            {
                Message = $"Operacion con exito, {Message}";
            }
            if (tipMessage.Equals("FormatException"))
            {
                Message = $"Operacion sin exito, {Message}";
            }

        }

        public override int[] ConversionStringToNumber(string entrada)
        {
            int[] resultConvertion = new int[2];

            try
            {
                resultConvertion = entrada.ConversionStringToNumber();
            }
            catch (FormatException ex)
            {
                Message = ex.Message;
                this.MessageResult("FormatException");
            }

            return resultConvertion;
        }

        public override int CalculateDivisionsByZero(int dividendo)
        {
            return Divisor.DividingAndCatchingException(dividendo);
        }

        public override int CalculateDivisions(int dividendo, int divisor)
        {
            throw new NotImplementedException();
        }
    }
}
