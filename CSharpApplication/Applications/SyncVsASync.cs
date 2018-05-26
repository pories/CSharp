using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Applications
{
    public class SyncVsASync
    {
        public static void Execute()
        {
            Console.Clear();
            Console.WriteLine("Synchronous vs Asynchronous.");
            Console.WriteLine("In a synchronous exchange it is real time, requester waits for an answer.");
            Console.WriteLine("In asynchronous the processes are working independently, they are not waiting for each other. AKA fire and forget.");
            Console.WriteLine("Here you will async in action, but remember there is a cost.");
            Console.WriteLine("The cost is that it creates a state machine, and uses it.");
            Console.WriteLine("Starting");
            var worker = new Worker();
            worker.DoWork();

            while (!worker.IsComplete)
            {
                Console.WriteLine(".");
                Thread.Sleep(100);

            }
            Console.WriteLine("Done, hit any key to exit.");
            Console.ReadLine();
        }
        public class Worker
        {
            public bool IsComplete { get; private set; }
            public async void DoWork() //if we change this to public async void dowork
                                       //Async would add 
            {
                this.IsComplete = false;
                Console.WriteLine("Doing work.");
                await LongOperation(); //because you can't await a void method you need longOperation to return a task.
                Console.WriteLine("Work completed.");
                IsComplete = true;
            }
            private Task LongOperation()//private void LongOperation()
            {
                return Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Working!");
                    //Pretends to do something interesting. 
                    Thread.Sleep(2000);
                });
            }
        }
    }
}
