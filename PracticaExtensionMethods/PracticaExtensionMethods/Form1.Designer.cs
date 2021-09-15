
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
            this.labelDividendo2 = new System.Windows.Forms.Label();
            this.labelTipoOperacion = new System.Windows.Forms.Label();
            this.textBoxOperations = new System.Windows.Forms.TextBox();
            this.tipoOperacion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOperationMyException = new System.Windows.Forms.TextBox();
            this.labelMyExceptionOperation = new System.Windows.Forms.Label();
            this.textBoxExceptionMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5ExcptionMessage = new System.Windows.Forms.Label();
            this.label_divide_divider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDividendo
            // 
            this.labelDividendo.AutoSize = true;
            this.labelDividendo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDividendo.Location = new System.Drawing.Point(220, 8);
            this.labelDividendo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDividendo.Name = "labelDividendo";
            this.labelDividendo.Size = new System.Drawing.Size(49, 13);
            this.labelDividendo.TabIndex = 0;
            this.labelDividendo.Text = "Dividend";
            // 
            // textBoxDividendo
            // 
            this.textBoxDividendo.Location = new System.Drawing.Point(222, 24);
            this.textBoxDividendo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDividendo.Name = "textBoxDividendo";
            this.textBoxDividendo.Size = new System.Drawing.Size(95, 20);
            this.textBoxDividendo.TabIndex = 2;
            // 
            // label1Dividend
            // 
            this.label1Dividend.AutoSize = true;
            this.label1Dividend.Location = new System.Drawing.Point(220, 50);
            this.label1Dividend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1Dividend.Name = "label1Dividend";
            this.label1Dividend.Size = new System.Drawing.Size(11, 13);
            this.label1Dividend.TabIndex = 3;
            this.label1Dividend.Text = "*";
            // 
            // labelDivisor
            // 
            this.labelDivisor.AutoSize = true;
            this.labelDivisor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDivisor.Location = new System.Drawing.Point(351, 120);
            this.labelDivisor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDivisor.Name = "labelDivisor";
            this.labelDivisor.Size = new System.Drawing.Size(40, 13);
            this.labelDivisor.TabIndex = 4;
            this.labelDivisor.Text = "Divider";
            // 
            // textBoxDivisor
            // 
            this.textBoxDivisor.Location = new System.Drawing.Point(353, 136);
            this.textBoxDivisor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDivisor.Name = "textBoxDivisor";
            this.textBoxDivisor.Size = new System.Drawing.Size(82, 20);
            this.textBoxDivisor.TabIndex = 5;
            // 
            // CalculateDivision
            // 
            this.CalculateDivision.Location = new System.Drawing.Point(32, 135);
            this.CalculateDivision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CalculateDivision.Name = "CalculateDivision";
            this.CalculateDivision.Size = new System.Drawing.Size(73, 20);
            this.CalculateDivision.TabIndex = 6;
            this.CalculateDivision.Text = "Divide";
            this.CalculateDivision.UseVisualStyleBackColor = true;
            this.CalculateDivision.Click += new System.EventHandler(this.CalculateDivision_Click);
            // 
            // DivisionX0
            // 
            this.DivisionX0.Location = new System.Drawing.Point(31, 23);
            this.DivisionX0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DivisionX0.Name = "DivisionX0";
            this.DivisionX0.Size = new System.Drawing.Size(74, 20);
            this.DivisionX0.TabIndex = 7;
            this.DivisionX0.Text = "Divide/0";
            this.DivisionX0.UseVisualStyleBackColor = true;
            this.DivisionX0.Click += new System.EventHandler(this.DivisionX0_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(615, 74);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(76, 20);
            this.textBoxResult.TabIndex = 9;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(615, 102);
            this.Result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(37, 13);
            this.Result.TabIndex = 10;
            this.Result.Text = "Result";
            // 
            // labelResultCalculo
            // 
            this.labelResultCalculo.AutoSize = true;
            this.labelResultCalculo.Location = new System.Drawing.Point(615, 124);
            this.labelResultCalculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResultCalculo.Name = "labelResultCalculo";
            this.labelResultCalculo.Size = new System.Drawing.Size(11, 13);
            this.labelResultCalculo.TabIndex = 11;
            this.labelResultCalculo.Text = "*";
            // 
            // buttonOperaciones
            // 
            this.buttonOperaciones.Location = new System.Drawing.Point(32, 248);
            this.buttonOperaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOperaciones.Name = "buttonOperaciones";
            this.buttonOperaciones.Size = new System.Drawing.Size(74, 19);
            this.buttonOperaciones.TabIndex = 12;
            this.buttonOperaciones.Text = "Consultar";
            this.buttonOperaciones.UseVisualStyleBackColor = true;
            this.buttonOperaciones.Click += new System.EventHandler(this.buttonOperaciones_Click);
            // 
            // textBoxDividend2
            // 
            this.textBoxDividend2.Location = new System.Drawing.Point(221, 136);
            this.textBoxDividend2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDividend2.Name = "textBoxDividend2";
            this.textBoxDividend2.Size = new System.Drawing.Size(94, 20);
            this.textBoxDividend2.TabIndex = 13;
            // 
            // labelDividendo2
            // 
            this.labelDividendo2.AutoSize = true;
            this.labelDividendo2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDividendo2.Location = new System.Drawing.Point(220, 120);
            this.labelDividendo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDividendo2.Name = "labelDividendo2";
            this.labelDividendo2.Size = new System.Drawing.Size(49, 13);
            this.labelDividendo2.TabIndex = 16;
            this.labelDividendo2.Text = "Dividend";
            // 
            // labelTipoOperacion
            // 
            this.labelTipoOperacion.AutoSize = true;
            this.labelTipoOperacion.Location = new System.Drawing.Point(220, 321);
            this.labelTipoOperacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoOperacion.Name = "labelTipoOperacion";
            this.labelTipoOperacion.Size = new System.Drawing.Size(11, 13);
            this.labelTipoOperacion.TabIndex = 18;
            this.labelTipoOperacion.Text = "*";
            // 
            // textBoxOperations
            // 
            this.textBoxOperations.Location = new System.Drawing.Point(222, 301);
            this.textBoxOperations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOperations.Name = "textBoxOperations";
            this.textBoxOperations.Size = new System.Drawing.Size(213, 20);
            this.textBoxOperations.TabIndex = 19;
            // 
            // tipoOperacion
            // 
            this.tipoOperacion.AutoSize = true;
            this.tipoOperacion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipoOperacion.Location = new System.Drawing.Point(220, 250);
            this.tipoOperacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tipoOperacion.Name = "tipoOperacion";
            this.tipoOperacion.Size = new System.Drawing.Size(259, 13);
            this.tipoOperacion.TabIndex = 20;
            this.tipoOperacion.Text = "Introduzca un numero para saber si esta la Operacion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 19);
            this.button1.TabIndex = 22;
            this.button1.Text = "MyException";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(220, 402);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Suma (0), Resta (1), Multiplicacion (2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(220, 377);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Introduzca un numero para saber si esta la Operacion";
            // 
            // textBoxOperationMyException
            // 
            this.textBoxOperationMyException.Location = new System.Drawing.Point(222, 427);
            this.textBoxOperationMyException.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOperationMyException.Name = "textBoxOperationMyException";
            this.textBoxOperationMyException.Size = new System.Drawing.Size(213, 20);
            this.textBoxOperationMyException.TabIndex = 24;
            // 
            // labelMyExceptionOperation
            // 
            this.labelMyExceptionOperation.AutoSize = true;
            this.labelMyExceptionOperation.Location = new System.Drawing.Point(220, 451);
            this.labelMyExceptionOperation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyExceptionOperation.Name = "labelMyExceptionOperation";
            this.labelMyExceptionOperation.Size = new System.Drawing.Size(11, 13);
            this.labelMyExceptionOperation.TabIndex = 23;
            this.labelMyExceptionOperation.Text = "*";
            // 
            // textBoxExceptionMessage
            // 
            this.textBoxExceptionMessage.Location = new System.Drawing.Point(531, 427);
            this.textBoxExceptionMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxExceptionMessage.Name = "textBoxExceptionMessage";
            this.textBoxExceptionMessage.Size = new System.Drawing.Size(213, 20);
            this.textBoxExceptionMessage.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(529, 402);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Toda Excepcione requiere un mensaje";
            // 
            // label5ExcptionMessage
            // 
            this.label5ExcptionMessage.AutoSize = true;
            this.label5ExcptionMessage.Location = new System.Drawing.Point(529, 448);
            this.label5ExcptionMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5ExcptionMessage.Name = "label5ExcptionMessage";
            this.label5ExcptionMessage.Size = new System.Drawing.Size(11, 13);
            this.label5ExcptionMessage.TabIndex = 29;
            this.label5ExcptionMessage.Text = "*";
            // 
            // label_divide_divider
            // 
            this.label_divide_divider.AutoSize = true;
            this.label_divide_divider.Location = new System.Drawing.Point(220, 157);
            this.label_divide_divider.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_divide_divider.Name = "label_divide_divider";
            this.label_divide_divider.Size = new System.Drawing.Size(11, 13);
            this.label_divide_divider.TabIndex = 30;
            this.label_divide_divider.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 491);
            this.Controls.Add(this.label_divide_divider);
            this.Controls.Add(this.label5ExcptionMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxExceptionMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOperationMyException);
            this.Controls.Add(this.labelMyExceptionOperation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tipoOperacion);
            this.Controls.Add(this.textBoxOperations);
            this.Controls.Add(this.labelTipoOperacion);
            this.Controls.Add(this.labelDividendo2);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label labelDividendo2;
        private System.Windows.Forms.Label labelTipoOperacion;
        private System.Windows.Forms.TextBox textBoxOperations;
        private System.Windows.Forms.Label tipoOperacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOperationMyException;
        private System.Windows.Forms.Label labelMyExceptionOperation;
        private System.Windows.Forms.TextBox textBoxExceptionMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5ExcptionMessage;
        private System.Windows.Forms.Label label_divide_divider;
    }
}

