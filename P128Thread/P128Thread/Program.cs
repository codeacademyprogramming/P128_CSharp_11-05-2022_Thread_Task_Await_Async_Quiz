using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace P128Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread thread1 = new Thread(Loop1);
            //Thread thread2 = new Thread(Loop2);



            //thread1.Start();
            //thread2.Start();


            ////Loop1();
            ////Loop2();

            //thread1.Join();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Main: {i} ThredId: {Thread.CurrentThread.ManagedThreadId}");
            }

            //Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("tr-TR");

            //Console.WriteLine(DateTime.Now.ToString("dddd"));

            
        }

        //static void Loop1()
        //{
        //    //Thread.Yield();
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Console.WriteLine($"Loop1: {i} ThredId: {Thread.CurrentThread.ManagedThreadId}");
        //    }
        //}

        //static void Loop2()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Console.WriteLine($"Loop2: {i} ThredId: {Thread.CurrentThread.ManagedThreadId}");
        //    }
        //}
    }
}
