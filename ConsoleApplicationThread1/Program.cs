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
            Thread something = new Thread(new ParameterizedThreadStart(ThreadMethod));
            //something.IsBackground = true;
            something.Start(5);
            //Console.ReadKey();

        }

   

        public static void ThreadMethod(object o)
        {
            //int param = (int)o;

            for (int i=0; i < (int)o; i++)
            {
                Console.WriteLine("Thread Proc \t {0} from {1}", i,(int)o);
                Thread.Sleep(1000);
            }
        }
      
    }
}
