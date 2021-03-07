
namespace PracticaLibreriasComponentes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputHoursWorked = new System.Windows.Forms.NumericUpDown();
            this.inputPaymentPerHour = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputHoursWorked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPaymentPerHour)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del empleado:";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(15, 26);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(185, 20);
            this.inputName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horas trabajadas:";
            // 
            // inputHoursWorked
            // 
            this.inputHoursWorked.Location = new System.Drawing.Point(220, 26);
            this.inputHoursWorked.Name = "inputHoursWorked";
            this.inputHoursWorked.Size = new System.Drawing.Size(120, 20);
            this.inputHoursWorked.TabIndex = 3;
            // 
            // inputPaymentPerHour
            // 
            this.inputPaymentPerHour.DecimalPlaces = 2;
            this.inputPaymentPerHour.Location = new System.Drawing.Point(362, 26);
            this.inputPaymentPerHour.Name = "inputPaymentPerHour";
            this.inputPaymentPerHour.Size = new System.Drawing.Size(120, 20);
            this.inputPaymentPerHour.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pago por hora:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular y mostrar recibo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Resetear formulario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 122);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputPaymentPerHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputHoursWorked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora de salario";
            ((System.ComponentModel.ISupportInitialize)(this.inputHoursWorked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPaymentPerHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inputHoursWorked;
        private System.Windows.Forms.NumericUpDown inputPaymentPerHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

