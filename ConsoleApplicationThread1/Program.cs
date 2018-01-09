using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplicationThread1
{

    // This app is my excercises with Thread Class
    // In my opinion threads are much unpredictable - I can't force to jump from thread to thread

    class Program
    {
        static void Main(string[] args)
        {
            Thread something = new Thread(new ThreadStart(Encounting));
            
            Thread something2 = new Thread(new ThreadStart(Encounting2));
            
            Thread something3 = new Thread(new ThreadStart(Encounting3));

            something.Start();
            something2.Start();
            something3.Start();
            //Thread.Sleep(0);

            for (int y = 1; y < 10; y++)
            {
                Console.WriteLine("Main loop {0}", y);

                if (IsThird(y))
                {
                    something3.Join();
                    Thread.Sleep(0);
                }
                else if (IsOdd(y))
                {
                    something2.Join();
                    Thread.Sleep(0);
                }
                else
                {
                    something.Join();
                    Thread.Sleep(0);
                }

               // Thread.Sleep(0);
            }
            Console.ReadKey();

        }

    public static bool IsOdd(int NumberForTest)
    {
            bool result = false;
            if (NumberForTest % 2 == 0)
                result =true;
            return result;
    }

        public static bool IsThird(int NumberForTest)
        {
            bool result = false;
            if (NumberForTest % 3 == 0)
                result = true;
            return result;
        }

        public static void Encounting()
        {
            for (int i=0; i < 100; i++)
            {
                Console.WriteLine("Thread result \tE{0}", i);
                Thread.Sleep(0);
            }
        }
        public static void Encounting2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread result \t\tE2{0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Encounting3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread result \t\t\tE3{0}", i);
                Thread.Sleep(0);
            }
        }
    }
}
