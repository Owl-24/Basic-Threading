using System;
using System.Threading;

namespace Basic_Threading
{
    public class MyThreadClass
    {
        public static class Thread1
        {
            public static void threading()
            {
                Thread currentThread = Thread.CurrentThread;
                string threadName = currentThread.Name;
                int attemptCount = 0;
                while (attemptCount < 6)
                {
                    Console.WriteLine("Name of Thread: Thread " + threadName + " Process = " + attemptCount);
                    Thread.Sleep(1500); 
                    attemptCount++;
                }
            }
        }
    }
}