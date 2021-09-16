
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
            this.txtBoxDividendo = new System.Windows.Forms.TextBox();
            this.lblDividend = new System.Windows.Forms.Label();
            this.labelDivisor = new System.Windows.Forms.Label();
            this.txtBoxDivisor = new System.Windows.Forms.TextBox();
            this.btnCalculateDivision = new System.Windows.Forms.Button();
            this.btnDivisionForZero = new System.Windows.Forms.Button();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.lblResultCalculo = new System.Windows.Forms.Label();
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.txtBoxDividend2 = new System.Windows.Forms.TextBox();
            this.labelDividendo2 = new System.Windows.Forms.Label();
            this.lblTipoOperacion = new System.Windows.Forms.Label();
            this.txtBoxOperations = new System.Windows.Forms.TextBox();
            this.tipoOperacion = new System.Windows.Forms.Label();
            this.btnMyException = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxOperationMyException = new System.Windows.Forms.TextBox();
            this.lblMyExceptionOperation = new System.Windows.Forms.Label();
            this.txtBoxExceptionMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExcptionMessage = new System.Windows.Forms.Label();
            this.lblDivendTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDividendo
            // 
            this.labelDividendo.AutoSize = true;
            this.labelDividendo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDividendo.Location = new System.Drawing.Point(290, 56);
            this.labelDividendo.Name = "labelDividendo";
            this.labelDividendo.Size = new System.Drawing.Size(63, 17);
            this.labelDividendo.TabIndex = 0;
            this.labelDividendo.Text = "Dividend";
            // 
            // txtBoxDividendo
            // 
            this.txtBoxDividendo.Location = new System.Drawing.Point(293, 76);
            this.txtBoxDividendo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxDividendo.Name = "txtBoxDividendo";
            this.txtBoxDividendo.Size = new System.Drawing.Size(286, 22);
            this.txtBoxDividendo.TabIndex = 2;
            // 
            // lblDividend
            // 
            this.lblDividend.AutoSize = true;
            this.lblDividend.Location = new System.Drawing.Point(290, 108);
            this.lblDividend.Name = "lblDividend";
            this.lblDividend.Size = new System.Drawing.Size(13, 17);
            this.lblDividend.TabIndex = 3;
            this.lblDividend.Text = "*";
            // 
            // labelDivisor
            // 
            this.labelDivisor.AutoSize = true;
            this.labelDivisor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDivisor.Location = new System.Drawing.Point(467, 192);
            this.labelDivisor.Name = "labelDivisor";
            this.labelDivisor.Size = new System.Drawing.Size(52, 17);
            this.labelDivisor.TabIndex = 4;
            this.labelDivisor.Text = "Divider";
            // 
            // txtBoxDivisor
            // 
            this.txtBoxDivisor.Location = new System.Drawing.Point(470, 211);
            this.txtBoxDivisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxDivisor.Name = "txtBoxDivisor";
            this.txtBoxDivisor.Size = new System.Drawing.Size(108, 22);
            this.txtBoxDivisor.TabIndex = 5;
            // 
            // btnCalculateDivision
            // 
            this.btnCalculateDivision.Location = new System.Drawing.Point(42, 210);
            this.btnCalculateDivision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculateDivision.Name = "btnCalculateDivision";
            this.btnCalculateDivision.Size = new System.Drawing.Size(97, 25);
            this.btnCalculateDivision.TabIndex = 6;
            this.btnCalculateDivision.Text = "Divide";
            this.btnCalculateDivision.UseVisualStyleBackColor = true;
            this.btnCalculateDivision.Click += new System.EventHandler(this.CalculateDivision_Click);
            // 
            // btnDivisionForZero
            // 
            this.btnDivisionForZero.Location = new System.Drawing.Point(38, 74);
            this.btnDivisionForZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDivisionForZero.Name = "btnDivisionForZero";
            this.btnDivisionForZero.Size = new System.Drawing.Size(99, 25);
            this.btnDivisionForZero.TabIndex = 7;
            this.btnDivisionForZero.Text = "Divide/0";
            this.btnDivisionForZero.UseVisualStyleBackColor = true;
            this.btnDivisionForZero.Click += new System.EventHandler(this.DivisionX0_Click);
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(836, 211);
            this.txtBoxResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(283, 22);
            this.txtBoxResult.TabIndex = 9;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(833, 192);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(48, 17);
            this.Result.TabIndex = 10;
            this.Result.Text = "Result";
            // 
            // lblResultCalculo
            // 
            this.lblResultCalculo.AutoSize = true;
            this.lblResultCalculo.Location = new System.Drawing.Point(833, 237);
            this.lblResultCalculo.Name = "lblResultCalculo";
            this.lblResultCalculo.Size = new System.Drawing.Size(13, 17);
            this.lblResultCalculo.TabIndex = 11;
            this.lblResultCalculo.Text = "*";
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.Location = new System.Drawing.Point(41, 348);
            this.btnOperaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Size = new System.Drawing.Size(99, 23);
            this.btnOperaciones.TabIndex = 12;
            this.btnOperaciones.Text = "Consultar";
            this.btnOperaciones.UseVisualStyleBackColor = true;
            this.btnOperaciones.Click += new System.EventHandler(this.buttonOperaciones_Click);
            // 
            // txtBoxDividend2
            // 
            this.txtBoxDividend2.Location = new System.Drawing.Point(294, 211);
            this.txtBoxDividend2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxDividend2.Name = "txtBoxDividend2";
            this.txtBoxDividend2.Size = new System.Drawing.Size(124, 22);
            this.txtBoxDividend2.TabIndex = 13;
            // 
            // labelDividendo2
            // 
            this.labelDividendo2.AutoSize = true;
            this.labelDividendo2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDividendo2.Location = new System.Drawing.Point(292, 192);
            this.labelDividendo2.Name = "labelDividendo2";
            this.labelDividendo2.Size = new System.Drawing.Size(63, 17);
            this.labelDividendo2.TabIndex = 16;
            this.labelDividendo2.Text = "Dividend";
            // 
            // lblTipoOperacion
            // 
            this.lblTipoOperacion.AutoSize = true;
            this.lblTipoOperacion.Location = new System.Drawing.Point(292, 374);
            this.lblTipoOperacion.Name = "lblTipoOperacion";
            this.lblTipoOperacion.Size = new System.Drawing.Size(13, 17);
            this.lblTipoOperacion.TabIndex = 18;
            this.lblTipoOperacion.Text = "*";
            // 
            // txtBoxOperations
            // 
            this.txtBoxOperations.Location = new System.Drawing.Point(295, 349);
            this.txtBoxOperations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxOperations.Name = "txtBoxOperations";
            this.txtBoxOperations.Size = new System.Drawing.Size(283, 22);
            this.txtBoxOperations.TabIndex = 19;
            // 
            // tipoOperacion
            // 
            this.tipoOperacion.AutoSize = true;
            this.tipoOperacion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tipoOperacion.Location = new System.Drawing.Point(291, 317);
            this.tipoOperacion.Name = "tipoOperacion";
            this.tipoOperacion.Size = new System.Drawing.Size(349, 17);
            this.tipoOperacion.TabIndex = 20;
            this.tipoOperacion.Text = "Introduzca un numero para saber si esta la Operacion";
            // 
            // btnMyException
            // 
            this.btnMyException.Location = new System.Drawing.Point(43, 526);
            this.btnMyException.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMyException.Name = "btnMyException";
            this.btnMyException.Size = new System.Drawing.Size(99, 23);
            this.btnMyException.TabIndex = 22;
            this.btnMyException.Text = "MyException";
            this.btnMyException.UseVisualStyleBackColor = true;
            this.btnMyException.Click += new System.EventHandler(this.btnMyOwnException);
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
            this.label3.Location = new System.Drawing.Point(293, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Introduzca un numero para saber si esta la Operacion";
            // 
            // txtBoxOperationMyException
            // 
            this.txtBoxOperationMyException.Location = new System.Drawing.Point(296, 526);
            this.txtBoxOperationMyException.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxOperationMyException.Name = "txtBoxOperationMyException";
            this.txtBoxOperationMyException.Size = new System.Drawing.Size(283, 22);
            this.txtBoxOperationMyException.TabIndex = 24;
            // 
            // lblMyExceptionOperation
            // 
            this.lblMyExceptionOperation.AutoSize = true;
            this.lblMyExceptionOperation.Location = new System.Drawing.Point(293, 555);
            this.lblMyExceptionOperation.Name = "lblMyExceptionOperation";
            this.lblMyExceptionOperation.Size = new System.Drawing.Size(13, 17);
            this.lblMyExceptionOperation.TabIndex = 23;
            this.lblMyExceptionOperation.Text = "*";
            // 
            // txtBoxExceptionMessage
            // 
            this.txtBoxExceptionMessage.Location = new System.Drawing.Point(836, 526);
            this.txtBoxExceptionMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxExceptionMessage.Name = "txtBoxExceptionMessage";
            this.txtBoxExceptionMessage.Size = new System.Drawing.Size(283, 22);
            this.txtBoxExceptionMessage.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(833, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Toda Excepcione requiere un mensaje";
            // 
            // lblExcptionMessage
            // 
            this.lblExcptionMessage.AutoSize = true;
            this.lblExcptionMessage.Location = new System.Drawing.Point(833, 551);
            this.lblExcptionMessage.Name = "lblExcptionMessage";
            this.lblExcptionMessage.Size = new System.Drawing.Size(13, 17);
            this.lblExcptionMessage.TabIndex = 29;
            this.lblExcptionMessage.Text = "*";
            // 
            // lblDivendTwo
            // 
            this.lblDivendTwo.AutoSize = true;
            this.lblDivendTwo.Location = new System.Drawing.Point(292, 237);
            this.lblDivendTwo.Name = "lblDivendTwo";
            this.lblDivendTwo.Size = new System.Drawing.Size(13, 17);
            this.lblDivendTwo.TabIndex = 30;
            this.lblDivendTwo.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 604);
            this.Controls.Add(this.lblDivendTwo);
            this.Controls.Add(this.lblExcptionMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxExceptionMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxOperationMyException);
            this.Controls.Add(this.lblMyExceptionOperation);
            this.Controls.Add(this.btnMyException);
            this.Controls.Add(this.tipoOperacion);
            this.Controls.Add(this.txtBoxOperations);
            this.Controls.Add(this.lblTipoOperacion);
            this.Controls.Add(this.labelDividendo2);
            this.Controls.Add(this.txtBoxDividend2);
            this.Controls.Add(this.btnOperaciones);
            this.Controls.Add(this.lblResultCalculo);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.btnDivisionForZero);
            this.Controls.Add(this.btnCalculateDivision);
            this.Controls.Add(this.txtBoxDivisor);
            this.Controls.Add(this.labelDivisor);
            this.Controls.Add(this.lblDividend);
            this.Controls.Add(this.txtBoxDividendo);
            this.Controls.Add(this.labelDividendo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDividendo;
        private System.Windows.Forms.TextBox txtBoxDividendo;
        private System.Windows.Forms.Label lblDividend;
        private System.Windows.Forms.Label labelDivisor;
        private System.Windows.Forms.TextBox txtBoxDivisor;
        private System.Windows.Forms.Button btnCalculateDivision;
        private System.Windows.Forms.Button btnDivisionForZero;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label lblResultCalculo;
        private System.Windows.Forms.Button btnOperaciones;
        private System.Windows.Forms.TextBox txtBoxDividend2;
        private System.Windows.Forms.Label labelDividendo2;
        private System.Windows.Forms.Label lblTipoOperacion;
        private System.Windows.Forms.TextBox txtBoxOperations;
        private System.Windows.Forms.Label tipoOperacion;
        private System.Windows.Forms.Button btnMyException;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxOperationMyException;
        private System.Windows.Forms.Label lblMyExceptionOperation;
        private System.Windows.Forms.TextBox txtBoxExceptionMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExcptionMessage;
        private System.Windows.Forms.Label lblDivendTwo;
    }
}

