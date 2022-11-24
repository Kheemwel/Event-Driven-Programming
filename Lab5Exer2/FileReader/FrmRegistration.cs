using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReader
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentNo = txtStudentNo.Text;
            string fullname = txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMiddleInitial.Text + ".";
            string program = cbPrograms.Text;
            string gender = cbGender.Text;
            string age = txtAge.Text;
            string birthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
            string contactNo = txtContactNo.Text;

            string filename = studentNo + ".txt";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, filename)))
            {
                outputFile.WriteLine(
                    $"Student No.: {studentNo}\n" +
                    $"Full Name: {fullname}\n" +
                    $"Program: {program}\n" +
                    $"Gender: {gender}\n" +
                    $"Age: {age}\n" +
                    $"Birthday: {birthday}\n" +
                    $"Contact No.: {contactNo}"
                    );
            }
        }
    }
}
