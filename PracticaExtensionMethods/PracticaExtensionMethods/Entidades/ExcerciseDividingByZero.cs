using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaExtensionMethods.ExtensionMethodsHelpers;

namespace PracticaExtensionMethods.Clases
{
    public class ExcerciseDividingByZero : CalculationsOfDivisions
    {
        public ExcerciseDividingByZero(): base(0)
        {

        }
        public override void MessageResult(String tipMessage)
        {
            if (tipMessage.Equals("FormatException"))
            {
                Message = string.Format("Seguro Ingreso una letra o no ingreso nada!, {0}", Message);
            }
            if (tipMessage.Equals("DivideByZeroException"))
            {
                Message = string.Format("Solo Chuck Norris divide por cero!, {0}", Message);
            }
            else
            {
                Message = "Operacion Exitosa";
            }

        }

        public override int CalculateDivisionsForCero(int dividendo)
        {
            int resultado = 0;
            try
            {
                resultado = this.DividingAndCatchingException(dividendo);
            }
            catch (DivideByZeroException ex)
            {
                Message = ex.Message;
                this.MessageResult("DivideByZeroException");
            }

            return resultado;
        }

        public override int CalculateDivisions(int dividendo, int divisor)
        {
            throw new NotImplementedException();
        }

        protected override int ConversionToDivisons(string entrada)
        {
            int result = 0;

            try
            {
                result = entrada.ConversionStringToNumber();
            }
            catch (FormatException ex)
            {
                Message = ex.Message;
                this.MessageResult("FormatException");
            }

            return result;
        }
    }
}
