using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal;
        double num1, num2;
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
            num1 = 0;
            num2 = 0;
        }

        private void txtBoxInput1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxInput2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = txtBoxInput1.Text == "" ? 0 : Convert.ToDouble(txtBoxInput1.Text);
            num2 = txtBoxInput2.Text == "" ? 0 : Convert.ToDouble(txtBoxInput2.Text);


            switch (cbOperator.SelectedIndex)
            {
                case 0:
                    cal.CalculateEvent += new Formula<double>(cal.GetSum);
                    lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                    break;
                case 1:
                    cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                    lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
                    break;
                case 2:
                    cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                    lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
                    break;
                case 3:
                    cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                    lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
                    break;
            }

        }

    }
}
