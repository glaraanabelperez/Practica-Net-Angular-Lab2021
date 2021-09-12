using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaExtensionMethods.Clases;
using PracticaExtensionMethods.ExtensionMethodsHelpers;

namespace PracticaExtensionMethods
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateDivision_Click(object sender, EventArgs e)
        {
            //textBoxDivisor.Enabled = true;
            //int numberEntrie = 0, numberEntrie2 = 0;
            //int resultDivision = 0;
            //String message = "";
 
            //try
            //{
            //    numberEntrie = textBoxDividendo.Text.ConversionStringToNumber();
            //    numberEntrie2 = textBoxDivisor.Text.ConversionStringToNumber();

            //    resultDivision = numberEntrie.CalculateDivisionsForCero();
            //    message = "Operacion Exitosa";
            //    labelMessage.Text = textBoxDividendo.Text + message;
            //}
            //catch (FormatException ex)
            //{
            //    message = string.Format("Operacion sin exito {0}", ex.Message);
            //    labelMessage.Text = " Ingreso no valido " + message;
            //}
            //catch (OverflowException ex) when (ex.GetType() != typeof(FormatException))
            //{
            //    message = string.Format("Operacion sin exito, {0}", ex.Message);
            //    labelMessage.Text = message;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    message = string.Format("Operacion sin exito, {0}", ex.Message);
            //    labelMessage.Text = message;
            //}
        }

        private void Division0_Click(object sender, EventArgs e)
        {
            CalculationsOfDivisions excercise1 = new ExcerciseDividingByZero();
            textBoxDivisor.Enabled = false;
            String dividend = "";
            int dividendNumber = 0;

            dividend = excercise1.CalculateDivisions(dividend);
            labelMessage.Text = textBoxDividendo.Text + excercise1.Message;

            dividendNumber = excercise1.CalculateDivisionsForCero(dividendNumber);
            labelMessage.Text = textBoxDividendo.Text + excercise1.Message;

 
            //textBoxDivisor.Enabled = false;
            //int numberEntrie = 0;
            //int resultDivision = 0;
            //String message = "";

            //try
            //{
            //    numberEntrie = textBoxDividendo.Text.ConversionStringToNumber();

            //    resultDivision = numberEntrie.CalculateDivisionsForCero();
            //    message = "Operacion Exitosa";
            //    labelMessage.Text = textBoxDividendo.Text + message;
            //}
            //catch (FormatException ex)
            //{
            //    message = string.Format("Operacion sin exito {0}", ex.Message);
            //    labelMessage.Text = " Ingreso no valido " + message;
            //}
            //catch (OverflowException ex) when (ex.GetType() != typeof(FormatException))
            //{
            //    message = string.Format("Operacion sin exito, {0}", ex.Message);
            //    labelMessage.Text = message;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    message = string.Format("Operacion sin exito, {0}", ex.Message);
            //    labelMessage.Text = message;
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelMessage.Text = "";
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


    }
}
