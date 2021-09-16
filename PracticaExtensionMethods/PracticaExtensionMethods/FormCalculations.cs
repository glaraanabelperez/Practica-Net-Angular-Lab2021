using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using ExcerciseExtensionMethods.Entities;
using ExcerciseExtensionMethods.ExtensionMethodsHelpers;

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
            lblResultCalculo.Text = "";
            String dividendTexto = txtBoxDividendo.Text;

            Calculations excercise1 = new DividingForZero();
            var resultConvertion = Tuple.Create(false, 0);

            resultConvertion = excercise1.ConversionStringToNumber(dividendTexto);
            lblDividend.Text = excercise1.Message;

            int resultDivision = 0;
            if (resultConvertion.Item1)
            {
                resultDivision = excercise1.CalculateDivisionsByZero(resultConvertion.Item2);
                lblResultCalculo.Text = excercise1.Message;
                txtBoxResult.Text = resultDivision.ToString();
            }
            txtBoxResult.Text = resultDivision.ToString();
        }

        private void CalculateDivision_Click(object sender, EventArgs e)
        {
            lblResultCalculo.Text = "";
            txtBoxResult.Text = "";
            txtBoxDivisor.Enabled = true;
            lblDivendTwo.Text = "";

            Calculations excercise1 = new Dividing();

            var resultConvertion = Tuple.Create(false, 0);
            var resultConvertion2 = Tuple.Create(false, 0);

            String dividend = txtBoxDividend2.Text;
            String divisor = txtBoxDivisor.Text;
            resultConvertion = excercise1.ConversionStringToNumber(dividend);
            resultConvertion2 = excercise1.ConversionStringToNumber(divisor);
            lblDivendTwo.Text = excercise1.Message;

            int result = 0;
            if (resultConvertion.Item1 & resultConvertion2.Item1)
            {
              excercise1.Divisor = resultConvertion2.Item2;
              result = excercise1.CalculateDivisionsByZero(resultConvertion.Item2);
              lblResultCalculo.Text = excercise1.Message;
            }
           
            txtBoxResult.Text = result.ToString();
        }

        private void buttonOperaciones_Click(object sender, EventArgs e)
        {
            bool result = false;
            var resultConvertion = Tuple.Create(false, 0);
            Logic logic = new Logic();

            try
            {
                resultConvertion = txtBoxOperations.Text.ThrowingFormatExceptionAndNumber();
            }
            catch (FormatException ex)
            {
                lblTipoOperacion.Text = ex.Message;
            }

            if (resultConvertion.Item1)
            {
                try
                {
                    result = logic.LockForOperations(resultConvertion.Item2);
                    lblTipoOperacion.Text = "Bien";
                }
                catch (IndexOutOfRangeException ex)
                {
                    lblTipoOperacion.Text = ex.Message;
                }
                txtBoxOperations.Text = result.ToString();
            }
        }

        private void btnMyOwnException(object sender, EventArgs e)
        {
            Logic logic = new Logic();
            var resultConvertion = Tuple.Create(false, 0);

            lblMyExceptionOperation.Text = "";
            lblExcptionMessage.Text = "";
            try
            {
                //ExtensionMethodsHelpers directo
                resultConvertion = txtBoxOperationMyException.Text.ThrowingFormatExceptionAndNumber();
            }
            catch (FormatException ex)
            {
                lblMyExceptionOperation.Text = ex.Message;
            }
            if (string.IsNullOrEmpty(txtBoxExceptionMessage.Text))
            {
                lblExcptionMessage.Text = "El campo no puede quedar vacio";
                return;
            }

            bool result = false;
            if (resultConvertion.Item1)
            {
                try
                {
                    result = logic.LockForOperations(resultConvertion.Item2, txtBoxExceptionMessage.Text);
                    MessageBox.Show(logic.message);
                }
                catch (MyExceptions ex)
                {
                    MessageBox.Show(ex.Message);
                }
             }
        }

    }

}

