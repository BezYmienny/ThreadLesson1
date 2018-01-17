using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplicationThread1
{

    // This app is my excercises with Thread Class
   

    class Program
    {

        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Threadproc);
            Console.WriteLine("Main thread does some work, then sleeps.");
            Thread.Sleep(1000);

            Console.WriteLine("Main thread exits.");
            Console.ReadKey();

            
        }

        static void Threadproc(object o)
             
            {
            Console.WriteLine("Working on thread from threadpool .....start ");
            Thread.Sleep(3000);
            Console.WriteLine("Working on thread from threadpool .....finish");
                
                
            }

   
    }
}
