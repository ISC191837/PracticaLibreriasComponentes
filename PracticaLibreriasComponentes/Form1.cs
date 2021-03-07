using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryCalc;
using Receipt;

namespace PracticaLibreriasComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputName.ResetText();
            inputHoursWorked.ResetText();
            inputPaymentPerHour.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, tax;
            float paymentPerHour, subtotal, taxValue, total;
            int hoursWorked, extraHours;
            hoursWorked = (int)inputHoursWorked.Value;
            paymentPerHour = (float)inputPaymentPerHour.Value;
            Calculator currentCalculator = new Calculator();

            name = inputName.Text;
            subtotal = currentCalculator.getSalaryByHours(hoursWorked: hoursWorked, paymentPerHour);
            extraHours = currentCalculator.getExtraHours(hoursWorked);
            tax = currentCalculator.getTaxString(subtotal);
            taxValue = currentCalculator.getTax(subtotal);

            total = subtotal - taxValue;

            ReceiptForm receiptForm = new ReceiptForm(name, hoursWorked, paymentPerHour, extraHours, subtotal, tax, taxValue, total);
            receiptForm.Show();
        }
    }
}
