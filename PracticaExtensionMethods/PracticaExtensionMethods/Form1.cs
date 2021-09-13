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
            Calculos excercise1 = new DividingForZero();

            String dividendTexto = textBoxDividendo.Text;

            int[] resultConvertion = new int[2];
            int resultDivision = 0;

            resultConvertion = excercise1.ConversionStringToNumber(dividendTexto);
            label1Dividend.Text = excercise1.Message;

            labelResultCalculo.Text = "";

            if (resultConvertion[0] == 1)
            {
                try
                {
                    resultDivision = excercise1.CalculateDivisionsByZero(resultConvertion[1]);
                }
                catch (DivideByZeroException ex)
                {
                    excercise1.Message = ex.Message;
                    excercise1.MessageResult("DivideByZeroException");
                }
                labelResultCalculo.Text = excercise1.Message;
            }
            textBoxResult.Text = resultDivision.ToString();
        }

        private void CalculateDivision_Click(object sender, EventArgs e)
        {
            Calculos excercise1 = new Dividing();
            labelResultCalculo.Text = "";
            textBoxResult.Text = "";

            textBoxDivisor.Enabled = true;
            int[] resultConvertion1 = new int[2];
            int[] resultConvertion2 = new int[2];

            String dividend = textBoxDividend2.Text;
            String divisor = textBoxDivisor.Text;

            int result = 0;


            resultConvertion1 = excercise1.ConversionStringToNumber(dividend);
            resultConvertion2 = excercise1.ConversionStringToNumber(divisor);

            labelDividend2.Text = excercise1.Message;
            labelResultCalculo.Text = "";

            if (resultConvertion1[0] == 1 && resultConvertion2[0] == 1)
            {
                try
                {
                    result = excercise1.CalculateDivisions(resultConvertion1[1], resultConvertion2[1]);
                }
                catch (DivideByZeroException ex)
                {
                    excercise1.Message = ex.Message;
                    excercise1.MessageResult("DivideByZeroException");
                }
                labelResultCalculo.Text = excercise1.Message;
                labelDividend2.Text = "";

            }
            textBoxResult.Text = result.ToString();
        }

        private void buttonOperaciones_Click(object sender, EventArgs e)
        {
            bool result = false;
            int[] resultConvertion = new int[2];
            Logic logic = new Logic();

            try
            {
                resultConvertion = textBoxOperations.Text.ConversionStringToNumber();
            }
            catch (FormatException ex)
            {
                labelTipoOperacion.Text = ex.Message;
            }

            if (resultConvertion[0] == 1)
            {
                try
                {
                    result = logic.LockForOperations(resultConvertion[1]);
                    labelTipoOperacion.Text = "Bien";
                }
                catch (IndexOutOfRangeException ex)
                {
                    labelTipoOperacion.Text = ex.Message;
                }
            }

            textBoxOperations.Text = result.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool result = false;
            int[] resultConvertion = new int[2];
            Logic logic = new Logic();
            labelMyExceptionOperation.Text = "";
            label5ExcptionMessage.Text = "";

            try
            {
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

            if (resultConvertion[0] == 1)
                {
                    try
                    {
                        result = logic.LockForOperations(resultConvertion[1], textBoxExceptionMessage.Text);
                    }
                    catch (MyExceptioncs ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

        }

       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        ///////////////////////////////////////////////////////               


        private void Form1_Load(object sender, EventArgs e)
        {
            label1Dividend.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxDividendo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDivisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelResultCalculo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }


    }
}
