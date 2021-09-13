
namespace PracticaExtensionMethods
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDividendo = new System.Windows.Forms.Label();
            this.textBoxDividendo = new System.Windows.Forms.TextBox();
            this.label1Dividend = new System.Windows.Forms.Label();
            this.labelDivisor = new System.Windows.Forms.Label();
            this.textBoxDivisor = new System.Windows.Forms.TextBox();
            this.CalculateDivision = new System.Windows.Forms.Button();
            this.DivisionX0 = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.labelResultCalculo = new System.Windows.Forms.Label();
            this.buttonOperaciones = new System.Windows.Forms.Button();
            this.textBoxDividend2 = new System.Windows.Forms.TextBox();
            this.labelDividend2 = new System.Windows.Forms.Label();
            this.labelDividendo2 = new System.Windows.Forms.Label();
            this.labelTipoOperacion = new System.Windows.Forms.Label();
            this.textBoxOperations = new System.Windows.Forms.TextBox();
            this.tipoOperacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOperationMyException = new System.Windows.Forms.TextBox();
            this.labelMyExceptionOperation = new System.Windows.Forms.Label();
            this.textBoxExceptionMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5ExcptionMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDividendo
            // 
            this.labelDividendo.AutoSize = true;
            this.labelDividendo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDividendo.Location = new System.Drawing.Point(294, 37);
            this.labelDividendo.Name = "labelDividendo";
            this.labelDividendo.Size = new System.Drawing.Size(63, 17);
            this.labelDividendo.TabIndex = 0;
            this.labelDividendo.Text = "Dividend";
            this.labelDividendo.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDividendo
            // 
            this.textBoxDividendo.Location = new System.Drawing.Point(297, 57);
            this.textBoxDividendo.Name = "textBoxDividendo";
            this.textBoxDividendo.Size = new System.Drawing.Size(125, 22);
            this.textBoxDividendo.TabIndex = 2;
            this.textBoxDividendo.TextChanged += new System.EventHandler(this.textBoxDividendo_TextChanged);
            // 
            // label1Dividend
            // 
            this.label1Dividend.AutoSize = true;
            this.label1Dividend.Location = new System.Drawing.Point(294, 89);
            this.label1Dividend.Name = "label1Dividend";
            this.label1Dividend.Size = new System.Drawing.Size(13, 17);
            this.label1Dividend.TabIndex = 3;
            this.label1Dividend.Text = "*";
            // 
            // labelDivisor
            // 
            this.labelDivisor.AutoSize = true;
            this.labelDivisor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDivisor.Location = new System.Drawing.Point(469, 174);
            this.labelDivisor.Name = "labelDivisor";
            this.labelDivisor.Size = new System.Drawing.Size(52, 17);
            this.labelDivisor.TabIndex = 4;
            this.labelDivisor.Text = "Divider";
            this.labelDivisor.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxDivisor
            // 
            this.textBoxDivisor.Location = new System.Drawing.Point(472, 194);
            this.textBoxDivisor.Name = "textBoxDivisor";
            this.textBoxDivisor.Size = new System.Drawing.Size(108, 22);
            this.textBoxDivisor.TabIndex = 5;
            this.textBoxDivisor.TextChanged += new System.EventHandler(this.textBoxDivisor_TextChanged);
            // 
            // CalculateDivision
            // 
            this.CalculateDivision.Location = new System.Drawing.Point(44, 192);
            this.CalculateDivision.Name = "CalculateDivision";
            this.CalculateDivision.Size = new System.Drawing.Size(97, 24);
            this.CalculateDivision.TabIndex = 6;
            this.CalculateDivision.Text = "Divide";
            this.CalculateDivision.UseVisualStyleBackColor = true;
            this.CalculateDivision.Click += new System.EventHandler(this.CalculateDivision_Click);
            // 
            // DivisionX0
            // 
            this.DivisionX0.Location = new System.Drawing.Point(42, 55);
            this.DivisionX0.Name = "DivisionX0";
            this.DivisionX0.Size = new System.Drawing.Size(99, 24);
            this.DivisionX0.TabIndex = 7;
            this.DivisionX0.Text = "Divide/0";
            this.DivisionX0.UseVisualStyleBackColor = true;
            this.DivisionX0.Click += new System.EventHandler(this.DivisionX0_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(758, 54);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 22);
            this.textBoxResult.TabIndex = 9;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(758, 89);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(48, 17);
            this.Result.TabIndex = 10;
            this.Result.Text = "Result";
            // 
            // labelResultCalculo
            // 
            this.labelResultCalculo.AutoSize = true;
            this.labelResultCalculo.Location = new System.Drawing.Point(758, 115);
            this.labelResultCalculo.Name = "labelResultCalculo";
            this.labelResultCalculo.Size = new System.Drawing.Size(13, 17);
            this.labelResultCalculo.TabIndex = 11;
            this.labelResultCalculo.Text = "*";
            this.labelResultCalculo.Click += new System.EventHandler(this.labelResultCalculo_Click);
            // 
            // buttonOperaciones
            // 
            this.buttonOperaciones.Location = new System.Drawing.Point(42, 305);
            this.buttonOperaciones.Name = "buttonOperaciones";
            this.buttonOperaciones.Size = new System.Drawing.Size(99, 23);
            this.buttonOperaciones.TabIndex = 12;
            this.buttonOperaciones.Text = "Consultar";
            this.buttonOperaciones.UseVisualStyleBackColor = true;
            this.buttonOperaciones.Click += new System.EventHandler(this.buttonOperaciones_Click);
            // 
            // textBoxDividend2
            // 
            this.textBoxDividend2.Location = new System.Drawing.Point(296, 194);
            this.textBoxDividend2.Name = "textBoxDividend2";
            this.textBoxDividend2.Size = new System.Drawing.Size(124, 22);
            this.textBoxDividend2.TabIndex = 13;
            // 
            // labelDividend2
            // 
            this.labelDividend2.AutoSize = true;
            this.labelDividend2.Location = new System.Drawing.Point(293, 235);
            this.labelDividend2.Name = "labelDividend2";
            this.labelDividend2.Size = new System.Drawing.Size(13, 17);
            this.labelDividend2.TabIndex = 15;
            this.labelDividend2.Text = "*";
            // 
            // labelDividendo2
            // 
            this.labelDividendo2.AutoSize = true;
            this.labelDividendo2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDividendo2.Location = new System.Drawing.Point(294, 174);
            this.labelDividendo2.Name = "labelDividendo2";
            this.labelDividendo2.Size = new System.Drawing.Size(63, 17);
            this.labelDividendo2.TabIndex = 16;
            this.labelDividendo2.Text = "Dividend";
            // 
            // labelTipoOperacion
            // 
            this.labelTipoOperacion.AutoSize = true;
            this.labelTipoOperacion.Location = new System.Drawing.Point(293, 395);
            this.labelTipoOperacion.Name = "labelTipoOperacion";
            this.labelTipoOperacion.Size = new System.Drawing.Size(13, 17);
            this.labelTipoOperacion.TabIndex = 18;
            this.labelTipoOperacion.Text = "*";
            // 
            // textBoxOperations
            // 
            this.textBoxOperations.Location = new System.Drawing.Point(296, 370);
            this.textBoxOperations.Name = "textBoxOperations";
            this.textBoxOperations.Size = new System.Drawing.Size(283, 22);
            this.textBoxOperations.TabIndex = 19;
            this.textBoxOperations.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tipoOperacion
            // 
            this.tipoOperacion.AutoSize = true;
            this.tipoOperacion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipoOperacion.Location = new System.Drawing.Point(293, 308);
            this.tipoOperacion.Name = "tipoOperacion";
            this.tipoOperacion.Size = new System.Drawing.Size(349, 17);
            this.tipoOperacion.TabIndex = 20;
            this.tipoOperacion.Text = "Introduzca un numero para saber si esta la Operacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(293, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Suma (0), Resta (1), Multiplicacion (2)";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "MyException";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(293, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Suma (0), Resta (1), Multiplicacion (2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(293, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Introduzca un numero para saber si esta la Operacion";
            // 
            // textBoxOperationMyException
            // 
            this.textBoxOperationMyException.Location = new System.Drawing.Point(296, 526);
            this.textBoxOperationMyException.Name = "textBoxOperationMyException";
            this.textBoxOperationMyException.Size = new System.Drawing.Size(283, 22);
            this.textBoxOperationMyException.TabIndex = 24;
            // 
            // labelMyExceptionOperation
            // 
            this.labelMyExceptionOperation.AutoSize = true;
            this.labelMyExceptionOperation.Location = new System.Drawing.Point(293, 555);
            this.labelMyExceptionOperation.Name = "labelMyExceptionOperation";
            this.labelMyExceptionOperation.Size = new System.Drawing.Size(13, 17);
            this.labelMyExceptionOperation.TabIndex = 23;
            this.labelMyExceptionOperation.Text = "*";
            // 
            // textBoxExceptionMessage
            // 
            this.textBoxExceptionMessage.Location = new System.Drawing.Point(708, 526);
            this.textBoxExceptionMessage.Name = "textBoxExceptionMessage";
            this.textBoxExceptionMessage.Size = new System.Drawing.Size(283, 22);
            this.textBoxExceptionMessage.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(705, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Toda Excepcione requiere un mensaje";
            // 
            // label5ExcptionMessage
            // 
            this.label5ExcptionMessage.AutoSize = true;
            this.label5ExcptionMessage.Location = new System.Drawing.Point(705, 552);
            this.label5ExcptionMessage.Name = "label5ExcptionMessage";
            this.label5ExcptionMessage.Size = new System.Drawing.Size(13, 17);
            this.label5ExcptionMessage.TabIndex = 29;
            this.label5ExcptionMessage.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 604);
            this.Controls.Add(this.label5ExcptionMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxExceptionMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOperationMyException);
            this.Controls.Add(this.labelMyExceptionOperation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipoOperacion);
            this.Controls.Add(this.textBoxOperations);
            this.Controls.Add(this.labelTipoOperacion);
            this.Controls.Add(this.labelDividendo2);
            this.Controls.Add(this.labelDividend2);
            this.Controls.Add(this.textBoxDividend2);
            this.Controls.Add(this.buttonOperaciones);
            this.Controls.Add(this.labelResultCalculo);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.DivisionX0);
            this.Controls.Add(this.CalculateDivision);
            this.Controls.Add(this.textBoxDivisor);
            this.Controls.Add(this.labelDivisor);
            this.Controls.Add(this.label1Dividend);
            this.Controls.Add(this.textBoxDividendo);
            this.Controls.Add(this.labelDividendo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDividendo;
        private System.Windows.Forms.TextBox textBoxDividendo;
        private System.Windows.Forms.Label label1Dividend;
        private System.Windows.Forms.Label labelDivisor;
        private System.Windows.Forms.TextBox textBoxDivisor;
        private System.Windows.Forms.Button CalculateDivision;
        private System.Windows.Forms.Button DivisionX0;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label labelResultCalculo;
        private System.Windows.Forms.Button buttonOperaciones;
        private System.Windows.Forms.TextBox textBoxDividend2;
        private System.Windows.Forms.Label labelDividend2;
        private System.Windows.Forms.Label labelDividendo2;
        private System.Windows.Forms.Label labelTipoOperacion;
        private System.Windows.Forms.TextBox textBoxOperations;
        private System.Windows.Forms.Label tipoOperacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOperationMyException;
        private System.Windows.Forms.Label labelMyExceptionOperation;
        private System.Windows.Forms.TextBox textBoxExceptionMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5ExcptionMessage;
    }
}

