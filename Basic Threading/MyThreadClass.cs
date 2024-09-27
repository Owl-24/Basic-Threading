using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basic_Threading
{
    public class MyThreadClass
    {
        public static class Thread1
        {
            public static void threading()
            {
                int attemptCount = 0;
                while (attemptCount < 6)
                {
                    Thread Thread1 = Thread.CurrentThread;
                    Console.WriteLine("Name of Thread: " + Thread1 + " = " + attemptCount);
                    Thread.Sleep(1500);
                    attemptCount++;
                               
                }

            } 
        }
    }
}