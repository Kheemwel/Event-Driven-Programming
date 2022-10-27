using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            StudentInfoClass.StudentNo = studentNoTxtBox.Text == "" ? 0 : Convert.ToInt64(studentNoTxtBox.Text);
            StudentInfoClass.Program = cbProgram.Text;
            StudentInfoClass.LastName = lnameTxtBox.Text;
            StudentInfoClass.FirstName = fnameTxtBox.Text;
            StudentInfoClass.MiddleName = mnameTxtBox.Text;
            StudentInfoClass.Age = ageTxtBox.Text == "" ? 0 : Convert.ToInt64(ageTxtBox.Text);
            StudentInfoClass.ContactNo = contactNoTxtBox.Text == "" ? 0 : Convert.ToInt64(contactNoTxtBox.Text);
            StudentInfoClass.Address = addressTxtBox.Text;

            FrmConfirm confirmWindow = new FrmConfirm();
            if (confirmWindow.ShowDialog(this) == DialogResult.OK)
            {
                studentNoTxtBox.Clear();
                cbProgram.SelectedIndex = -1;
                lnameTxtBox.Clear();
                fnameTxtBox.Clear();
                mnameTxtBox.Clear();
                ageTxtBox.Clear();
                contactNoTxtBox.Clear();
                addressTxtBox.Clear();
                confirmWindow.Dispose();
            }
        }

        private void studentNoTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ageTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void contactNoTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
