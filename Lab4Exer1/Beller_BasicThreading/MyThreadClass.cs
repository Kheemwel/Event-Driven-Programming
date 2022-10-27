using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Beller_BasicThreading
{
    class MyThreadClass
    {
        public static void Thread1()
        {
            //this loop will terminate after fifth attempt
            for (int loopCount = 0; loopCount <= 5; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(1500); //Suspend the current thread for 1.5 seconds.
            }
        }
    }
}
