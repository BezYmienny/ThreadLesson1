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

        [ThreadStatic]
        public static int _field;
        static void Main(string[] args)
        {
            Thread something = new Thread(new ParameterizedThreadStart(ThreadMethod));
            //something.IsBackground = true;
            something.Start(5);
            (new Thread(new ParameterizedThreadStart(ThreadMethod))).Start(6);
            (new Thread(new ParameterizedThreadStart(ThreadMethod))).Start(7);
            Console.ReadKey();

        }

   

        public static void ThreadMethod(object o)
        {
            //int param = (int)o;
            Console.WriteLine("not assigned _field \t {0}",_field);
            if (_field == 0)
            {
                _field=(int)o;
            }

            for (int i=1; i < (int)o; i++)
            {
                Console.WriteLine("Thread Proc \t {0} from {1} and _field {2}", i,(int)o,_field);
                Thread.Sleep(1000);
            }

        }
      
    }
}
