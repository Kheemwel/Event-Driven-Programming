using System;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 100); // 1 decisecond
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count != 0)
            {
                lblQueue.Text = CashierClass.CashierQueue.Peek();
            }
        }
    }
}
