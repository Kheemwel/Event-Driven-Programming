using System;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

            if (!CheckOpenedWindow("CashierWindowQueueForm"))
            {
                new CashierWindowQueueForm().Show();
            }
        }

        private bool CheckOpenedWindow(string windowname)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == windowname)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
