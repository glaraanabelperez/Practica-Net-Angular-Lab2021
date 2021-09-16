
using System;
using System.Windows.Forms;
using ExcerciseExtensionMethods.ExtensionMethodsHelpers;

namespace ExcerciseExtensionMethods.Entities
{
    public class DividingForZero : Calculations
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

        public override Tuple<bool, int> ConversionStringToNumber(string entrada)
        {
            var resultConvertion = Tuple.Create(false, 0);
            try
            {
                resultConvertion = entrada.ThrowingFormatExceptionAndNumber();
                return resultConvertion;
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
            int rsta = 0;
            try
            {
                rsta = Divisor.ThrowingDividenByZero(dividendo);
                Console.WriteLine(rsta);
            }
            catch (DivideByZeroException ex)
            {
                Message = ex.Message;
                MessageResult("DivideByZeroException");
            }
            return rsta;
        }
    }
}

