using System.Collections.Generic;
using System;
using System.Threading;

namespace MultiThreadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread T = new Thread(Print1);

            T.Start();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(Thread.GetCurrentProcessorId());
            }
            Console.ReadKey();
        }

        static void Print1()
        {
            for (int i=0; i<100; i++)
            {
                Console.WriteLine(Thread.GetCurrentProcessorId());
            }
            
        }
    }
}
