namespace FileReader
{
    partial class FrmRegistration
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbl10 = new System.Windows.Forms.Label();
            this.cbPrograms = new System.Windows.Forms.ComboBox();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.datePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnRecords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(15, 64);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(67, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Student No.:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(21, 97);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(61, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Last Name:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(53, 134);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(29, 13);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Age:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(34, 178);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(48, 13);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Birthday:";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(347, 65);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(49, 13);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "Program:";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(336, 98);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(60, 13);
            this.lbl7.TabIndex = 6;
            this.lbl7.Text = "First Name:";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(611, 102);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(28, 13);
            this.lbl8.TabIndex = 7;
            this.lbl8.Text = "M.I.:";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(351, 135);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(45, 13);
            this.lbl9.TabIndex = 8;
            this.lbl9.Text = "Gender:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(264, 237);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(329, 179);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(67, 13);
            this.lbl10.TabIndex = 10;
            this.lbl10.Text = "Contact No.:";
            // 
            // cbPrograms
            // 
            this.cbPrograms.FormattingEnabled = true;
            this.cbPrograms.Items.AddRange(new object[] {
            "BS Information Technology",
            "BS Computer Engineering",
            "BS Computer Science"});
            this.cbPrograms.Location = new System.Drawing.Point(401, 61);
            this.cbPrograms.Name = "cbPrograms";
            this.cbPrograms.Size = new System.Drawing.Size(291, 21);
            this.cbPrograms.TabIndex = 11;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(89, 61);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(140, 20);
            this.txtStudentNo.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(89, 94);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(140, 20);
            this.txtLastName.TabIndex = 13;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(401, 95);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(179, 20);
            this.txtFirstName.TabIndex = 14;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(89, 127);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(140, 20);
            this.txtAge.TabIndex = 15;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(402, 173);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(178, 20);
            this.txtContactNo.TabIndex = 16;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Location = new System.Drawing.Point(645, 95);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(47, 20);
            this.txtMiddleInitial.TabIndex = 17;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(402, 135);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(178, 21);
            this.cbGender.TabIndex = 18;
            // 
            // datePickerBirthday
            // 
            this.datePickerBirthday.Location = new System.Drawing.Point(89, 172);
            this.datePickerBirthday.Name = "datePickerBirthday";
            this.datePickerBirthday.Size = new System.Drawing.Size(200, 20);
            this.datePickerBirthday.TabIndex = 19;
            // 
            // btnRecords
            // 
            this.btnRecords.Location = new System.Drawing.Point(617, 237);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(75, 23);
            this.btnRecords.TabIndex = 20;
            this.btnRecords.Text = "Records";
            this.btnRecords.UseVisualStyleBackColor = true;
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 278);
            this.Controls.Add(this.btnRecords);
            this.Controls.Add(this.datePickerBirthday);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.cbPrograms);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmRegistration";
            this.Text = "FrmRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.ComboBox cbPrograms;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DateTimePicker datePickerBirthday;
        private System.Windows.Forms.Button btnRecords;
    }
}

