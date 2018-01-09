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
            Thread something = new Thread(new ThreadStart(ThreadMethod));
            something.IsBackground = true;
            something.Start();
            //Console.ReadKey();

        }

   

        public static void ThreadMethod()
        {
            for (int i=0; i < 10; i++)
            {
                Console.WriteLine("Thread Proc \t {0}", i);
                Thread.Sleep(1000);
            }
        }
      
    }
}
