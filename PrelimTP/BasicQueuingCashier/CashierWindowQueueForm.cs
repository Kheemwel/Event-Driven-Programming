using System;
using System.Collections;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        public void timer1_tick(Object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            if (CashierList != null )
            {
                foreach (Object obj in CashierList)
                {
                    listCashierQueue.Items.Add(obj.ToString());
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedWindow("CustomerView"))
            {
                new CustomerView().Show();
            } else
            {
                if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count != 0)
                {
                    CashierClass.CashierQueue.Dequeue();
                }
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

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 100); // 1 decisecond
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }
    }
}
