using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab_4multi
{
    class Program
    {
        static void test1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("test1 " + i);
            }
            Console.WriteLine("First Thread exit");
        }
        static void test2()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    Thread.Sleep(5000);
                    Console.WriteLine("thread is sleeping");
                }
                Console.WriteLine("test2 " + i);
            }
            Console.WriteLine("Second thread exit");
        }
        static void test3()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("test3 " + i);
            }
            Console.WriteLine("Third thread exit");
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(test1);
            Thread t2 = new Thread(test2);
            Thread t3 = new Thread(test3);
            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join();
            t2.Join();
            t3.Join();
            Console.WriteLine("Main Thread Exit");
            Console.ReadLine();
        }
    }
}

