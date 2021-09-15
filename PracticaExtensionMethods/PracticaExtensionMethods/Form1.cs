using System;
using System.Windows.Forms;
using PracticaExtensionMethods.Clases;
using PracticaExtensionMethods.Entidades;
using PracticaExtensionMethods.ExtensionMethodsHelpers;

namespace PracticaExtensionMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void DivisionX0_Click(object sender, EventArgs e)
        {
            labelResultCalculo.Text = "";
            String dividendTexto = textBoxDividendo.Text;

            Calculos excercise1 = new DividingForZero();
            var resultConvertion = Tuple.Create(false, 0);

            resultConvertion = excercise1.ConversionStringToNumber(dividendTexto);
            label1Dividend.Text = excercise1.Message;

            int resultDivision = 0;
            if (resultConvertion.Item1)
            {
                resultDivision = excercise1.CalculateDivisionsByZero(resultConvertion.Item2);
                labelResultCalculo.Text = excercise1.Message;
                textBoxResult.Text = resultDivision.ToString();
            }
            textBoxResult.Text = resultDivision.ToString();
        }

        private void CalculateDivision_Click(object sender, EventArgs e)
        {
            labelResultCalculo.Text = "";
            textBoxResult.Text = "";
            textBoxDivisor.Enabled = true;
            label_divide_divider.Text = "";

            Calculos excercise1 = new Dividing();

            var resultConvertion = Tuple.Create(false, 0);
            var resultConvertion2 = Tuple.Create(false, 0);

            String dividend = textBoxDividend2.Text;
            String divisor = textBoxDivisor.Text;
            resultConvertion = excercise1.ConversionStringToNumber(dividend);
            resultConvertion2 = excercise1.ConversionStringToNumber(divisor);
            label_divide_divider.Text = excercise1.Message;

            int result = 0;
            if (resultConvertion.Item1 & resultConvertion2.Item1)
            {
              excercise1.Divisor = resultConvertion2.Item2;
              result = excercise1.CalculateDivisionsByZero(resultConvertion.Item2);
              labelResultCalculo.Text = excercise1.Message;
            }
           
            textBoxResult.Text = result.ToString();
        }

        private void buttonOperaciones_Click(object sender, EventArgs e)
        {
            //bool result = false;
            //int[] resultConvertion = new int[2];
            //Logic logic = new Logic();

            //try
            //{
            //    resultConvertion = textBoxOperations.Text.ConversionStringToNumber();
            //}
            //catch (FormatException ex)
            //{
            //    labelTipoOperacion.Text = ex.Message;
            //}

            //if (resultConvertion[0] == 1)
            //{
            //    try
            //    {
            //        result = logic.LockForOperations(resultConvertion[1]);
            //        labelTipoOperacion.Text = "Bien";
            //    }
            //    catch (IndexOutOfRangeException ex)
            //    {
            //        labelTipoOperacion.Text = ex.Message;
            //    }
            //}

            //textBoxOperations.Text = result.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logic logic = new Logic();
            var resultConvertion = Tuple.Create(false, 0);

            labelMyExceptionOperation.Text = "";
            label5ExcptionMessage.Text = "";
            try
            {
                //ExtensionMethodsHelpers directo
                resultConvertion = textBoxOperationMyException.Text.ConversionStringToNumber();
            }
            catch (FormatException ex)
            {
                labelMyExceptionOperation.Text = ex.Message;
            }
            if (string.IsNullOrEmpty(textBoxExceptionMessage.Text))
            {
                label5ExcptionMessage.Text = "El campo no puede quedar vacio";
                return;
            }

            bool result = false;
            if (resultConvertion.Item1)
            {
                try
                {
                    result = logic.LockForOperations(resultConvertion.Item2, textBoxExceptionMessage.Text);
                    MessageBox.Show(logic.message);
                }
                catch (MyExceptioncs ex)
                {
                    MessageBox.Show(ex.Message);
                }
             }

        }

      
    
    }

}

