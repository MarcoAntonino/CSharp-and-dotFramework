using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncDelegate
{
    class Program
    {
        public delegate int BinaryOp(int x, int y);

        static void Main(string[] args)
        {
            Console.WriteLine("***Synch Delegate Review");

            Console.WriteLine("main() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);

            BinaryOp b = new BinaryOp(Add);
            IAsyncResult iftAr = b.BeginInvoke(10, 10, null, null);

            int counter = 0;

            //while (!iftAr.IsCompleted) //finchè sarà falso, l'altro thread non sarà finito
            //{
            //    Console.WriteLine("Doing more work in Main(), counter = {0}", counter);
            //    Thread.Sleep(1000);
            //    counter++;
            //}

            while (!iftAr.AsyncWaitHandle.WaitOne(1000, true)) //più raffinato
            {
                Console.WriteLine("Doing more work in Main(), counter = {0}", counter);
                counter++;
            }

            int answer = b.EndInvoke(iftAr);
            Console.WriteLine("10 + 10 is {0}", answer);
            Console.ReadLine();
        }

        private static int Add(int x, int y)
        {
            Console.WriteLine("Add() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return x + y;
        }
    }
}
