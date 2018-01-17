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
            ThreadPool.QueueUserWorkItem((s) =>
            {

                Console.WriteLine("Working on thread from threadpool .....");
                //Thread.Sleep(1000);
            });
            
            Console.ReadKey();

            
        }

   
    }
}
