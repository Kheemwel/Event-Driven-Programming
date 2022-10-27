using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beller_BasicThreading
{
    public partial class FrmBasicThread : Form
    {
        Thread ThreadA, ThreadB;
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            ThreadStart run_this_method = new ThreadStart(MyThreadClass.Thread1);
            ThreadA = new Thread(run_this_method);
            ThreadA.Name = "Thread A Process";
            ThreadB = new Thread(run_this_method);
            ThreadB.Name = "Thread B Process";
            Console.WriteLine(lblText.Text);
            ThreadA.Start();
            ThreadB.Start();
            ThreadA.Join(); //this will stop a calling thread until the thread terminates.
            ThreadB.Join();
            lblText.Text = "-End Of Thread-";
            Console.WriteLine(lblText.Text);
        }
    }
}
