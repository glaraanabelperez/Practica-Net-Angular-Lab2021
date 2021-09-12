using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaExtensionMethods.ExtensionMethodsHelpers;

namespace PracticaExtensionMethods.Clases
{
    public class Dividing : CalculationsOfDivisions
    {
        public Dividing(int divisor) : base(divisor)
        {

        }
        public override void MessageResult(String tipMessage)
        {
            if (tipMessage.Equals("FormatException") || tipMessage.Equals("DivideByZeroException"))
            {
                Message = "Operacion sin exito";
            }
            else
            {
                Message = "Operacion Exitosa";
            }
        }

        public override int CalculateDivisions(int dividendo, int divisor)
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

        public override int CalculateDivisionsForCero(int dividendo)
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
