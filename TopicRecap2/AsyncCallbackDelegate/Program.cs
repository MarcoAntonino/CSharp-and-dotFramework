using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace AsyncCallbackDelegate
{
    public delegate int BinaryOp(int x, int y);

    class Program
    {
        private static bool isDone = false;
        
        static void Main(string[] args)
        {
            Console.WriteLine("***AsyncCallbackDelegate example");
            Console.WriteLine("Main() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);

            BinaryOp b = new BinaryOp(Add);

            IAsyncResult iftAR = b.BeginInvoke(10, 10, new AsyncCallback(AddComplete), null); //l'ultimo argomento aggiunge dati aggiuntivi

            while (!isDone)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Working...");
            }

            Console.ReadLine();
                    

        }

       
        private static int Add(int x, int y)
        {
            Console.WriteLine("Add() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return x + y;
        }

        private static void AddComplete(IAsyncResult itfAR)
        {
            Console.WriteLine("AddComplete() invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Your addition is complete");

            AsyncResult ar = (AsyncResult)itfAR;
            BinaryOp b = (BinaryOp)ar.AsyncDelegate;
            Console.WriteLine("10 + 10 is {0}", b.EndInvoke(itfAR));           

            isDone = true;

        }
    }
}
