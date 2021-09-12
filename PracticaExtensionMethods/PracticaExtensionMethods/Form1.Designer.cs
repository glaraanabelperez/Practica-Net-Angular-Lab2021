
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
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelDivisor = new System.Windows.Forms.Label();
            this.textBoxDivisor = new System.Windows.Forms.TextBox();
            this.CalculateDivision = new System.Windows.Forms.Button();
            this.DivisionX0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDividendo
            // 
            this.labelDividendo.AutoSize = true;
            this.labelDividendo.Location = new System.Drawing.Point(507, 121);
            this.labelDividendo.Name = "labelDividendo";
            this.labelDividendo.Size = new System.Drawing.Size(71, 17);
            this.labelDividendo.TabIndex = 0;
            this.labelDividendo.Text = "Dividendo";
            this.labelDividendo.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDividendo
            // 
            this.textBoxDividendo.Location = new System.Drawing.Point(510, 141);
            this.textBoxDividendo.Name = "textBoxDividendo";
            this.textBoxDividendo.Size = new System.Drawing.Size(125, 22);
            this.textBoxDividendo.TabIndex = 2;
            this.textBoxDividendo.TextChanged += new System.EventHandler(this.textBoxDividendo_TextChanged);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(507, 225);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(46, 17);
            this.labelMessage.TabIndex = 3;
            this.labelMessage.Text = "label1";
            // 
            // labelDivisor
            // 
            this.labelDivisor.AutoSize = true;
            this.labelDivisor.Location = new System.Drawing.Point(666, 121);
            this.labelDivisor.Name = "labelDivisor";
            this.labelDivisor.Size = new System.Drawing.Size(51, 17);
            this.labelDivisor.TabIndex = 4;
            this.labelDivisor.Text = "Divisor";
            this.labelDivisor.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxDivisor
            // 
            this.textBoxDivisor.Location = new System.Drawing.Point(669, 141);
            this.textBoxDivisor.Name = "textBoxDivisor";
            this.textBoxDivisor.Size = new System.Drawing.Size(104, 22);
            this.textBoxDivisor.TabIndex = 5;
            this.textBoxDivisor.TextChanged += new System.EventHandler(this.textBoxDivisor_TextChanged);
            // 
            // CalculateDivision
            // 
            this.CalculateDivision.Location = new System.Drawing.Point(622, 182);
            this.CalculateDivision.Name = "CalculateDivision";
            this.CalculateDivision.Size = new System.Drawing.Size(91, 23);
            this.CalculateDivision.TabIndex = 6;
            this.CalculateDivision.Text = "Dividir";
            this.CalculateDivision.UseVisualStyleBackColor = true;
            this.CalculateDivision.Click += new System.EventHandler(this.CalculateDivision_Click);
            // 
            // DivisionX0
            // 
            this.DivisionX0.Location = new System.Drawing.Point(510, 182);
            this.DivisionX0.Name = "DivisionX0";
            this.DivisionX0.Size = new System.Drawing.Size(93, 23);
            this.DivisionX0.TabIndex = 7;
            this.DivisionX0.Text = "Divide/0";
            this.DivisionX0.UseVisualStyleBackColor = true;
            this.DivisionX0.Click += new System.EventHandler(this.DivisionX0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 450);
            this.Controls.Add(this.DivisionX0);
            this.Controls.Add(this.CalculateDivision);
            this.Controls.Add(this.textBoxDivisor);
            this.Controls.Add(this.labelDivisor);
            this.Controls.Add(this.labelMessage);
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
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelDivisor;
        private System.Windows.Forms.TextBox textBoxDivisor;
        private System.Windows.Forms.Button CalculateDivision;
        private System.Windows.Forms.Button DivisionX0;
    }
}

