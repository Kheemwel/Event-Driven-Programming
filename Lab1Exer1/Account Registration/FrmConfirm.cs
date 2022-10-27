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
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        private void submitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            txtStudentNo.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            txtProgram.Text = DelProgram(StudentInfoClass.Program);
            txtLastName.Text = DelLastName(StudentInfoClass.LastName);
            txtFirstName.Text = DelFirstName(StudentInfoClass.FirstName);
            txtMiddleName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            txtNumAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            txtNumContactNo.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            txtAddress.Text = DelAddress(StudentInfoClass.Address);
        }

        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }
    }
}
