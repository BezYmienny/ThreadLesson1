using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplicationThread1
{

    // Thius app is my excercises with Thread Class

    class Program
    {
        static void Main(string[] args)
        {
            Thread something = new Thread(new ThreadStart(Encounting));
            something.Start();

            Thread something2 = new Thread(new ThreadStart(Encounting2));
            something2.Start();

            Thread something3 = new Thread(new ThreadStart(Encounting3));
            something3.Start();


            for (int y = 10; y < 100; y++)
            {
                Console.WriteLine("Main loop {0}", y);

                if (IsOdd(y / 10))
                    something.Join();
                else
                    something2.Join();
                // test branch
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

        public static void Encounting()
        {
            for (int i=0; i < 100; i++)
            {
                Console.WriteLine("Thread result \tE{0}", i);
                Thread.Sleep(2);
            }
        }
        public static void Encounting2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread result \t\tE2{0}", i);
                Thread.Sleep(3);
            }
        }

        public static void Encounting3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread result \t\t\tE3{0}", i);
                Thread.Sleep(3);
            }
        }
    }
}
