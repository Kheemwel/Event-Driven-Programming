namespace BasicQueuingCashier
{
    partial class QueuingForm
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
            this.btnCashier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCashier
            // 
            this.btnCashier.Location = new System.Drawing.Point(30, 28);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(76, 68);
            this.btnCashier.TabIndex = 0;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(167, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Position in Queue";
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblQueue.Location = new System.Drawing.Point(152, 57);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(165, 39);
            this.lblQueue.TabIndex = 2;
            this.lblQueue.Text = "P - 00000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(27, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "* CLick to get a number";
            // 
            // QueuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 147);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCashier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QueuingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueuingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label label2;
    }
}

