namespace Account_Registration
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.studentNoTxtBox = new System.Windows.Forms.TextBox();
            this.lnameTxtBox = new System.Windows.Forms.TextBox();
            this.ageTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.contactNoTxtBox = new System.Windows.Forms.TextBox();
            this.fnameTxtBox = new System.Windows.Forms.TextBox();
            this.mnameTxtBox = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Program:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Middle Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Contact No.:";
            // 
            // studentNoTxtBox
            // 
            this.studentNoTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.studentNoTxtBox.Location = new System.Drawing.Point(29, 40);
            this.studentNoTxtBox.Name = "studentNoTxtBox";
            this.studentNoTxtBox.Size = new System.Drawing.Size(139, 20);
            this.studentNoTxtBox.TabIndex = 8;
            this.studentNoTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studentNoTxtBox_KeyPress);
            // 
            // lnameTxtBox
            // 
            this.lnameTxtBox.Location = new System.Drawing.Point(29, 105);
            this.lnameTxtBox.Name = "lnameTxtBox";
            this.lnameTxtBox.Size = new System.Drawing.Size(139, 20);
            this.lnameTxtBox.TabIndex = 9;
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.Location = new System.Drawing.Point(29, 176);
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Size = new System.Drawing.Size(139, 20);
            this.ageTxtBox.TabIndex = 12;
            this.ageTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTxtBox_KeyPress);
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(29, 249);
            this.addressTxtBox.MaximumSize = new System.Drawing.Size(100, 80);
            this.addressTxtBox.MinimumSize = new System.Drawing.Size(450, 80);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(450, 80);
            this.addressTxtBox.TabIndex = 14;
            // 
            // contactNoTxtBox
            // 
            this.contactNoTxtBox.Location = new System.Drawing.Point(190, 176);
            this.contactNoTxtBox.Name = "contactNoTxtBox";
            this.contactNoTxtBox.Size = new System.Drawing.Size(139, 20);
            this.contactNoTxtBox.TabIndex = 15;
            this.contactNoTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactNoTxtBox_KeyPress);
            // 
            // fnameTxtBox
            // 
            this.fnameTxtBox.Location = new System.Drawing.Point(190, 105);
            this.fnameTxtBox.Name = "fnameTxtBox";
            this.fnameTxtBox.Size = new System.Drawing.Size(139, 20);
            this.fnameTxtBox.TabIndex = 16;
            // 
            // mnameTxtBox
            // 
            this.mnameTxtBox.Location = new System.Drawing.Point(357, 105);
            this.mnameTxtBox.Name = "mnameTxtBox";
            this.mnameTxtBox.Size = new System.Drawing.Size(139, 20);
            this.mnameTxtBox.TabIndex = 17;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(190, 335);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 18;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // cbProgram
            // 
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Items.AddRange(new object[] {
            "BSIT",
            "BSCS",
            "BSCP",
            "BMMA"});
            this.cbProgram.Location = new System.Drawing.Point(190, 40);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(139, 21);
            this.cbProgram.TabIndex = 19;
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 364);
            this.Controls.Add(this.cbProgram);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.mnameTxtBox);
            this.Controls.Add(this.fnameTxtBox);
            this.Controls.Add(this.contactNoTxtBox);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.ageTxtBox);
            this.Controls.Add(this.lnameTxtBox);
            this.Controls.Add(this.studentNoTxtBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmRegistration";
            this.Text = "FrmRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox studentNoTxtBox;
        private System.Windows.Forms.TextBox lnameTxtBox;
        private System.Windows.Forms.TextBox ageTxtBox;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.TextBox contactNoTxtBox;
        private System.Windows.Forms.TextBox fnameTxtBox;
        private System.Windows.Forms.TextBox mnameTxtBox;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.ComboBox cbProgram;
    }
}