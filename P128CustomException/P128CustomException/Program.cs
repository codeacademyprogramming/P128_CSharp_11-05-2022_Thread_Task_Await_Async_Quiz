using System;

namespace P128CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("a");
        }

        static string Test(string a)
        {
            if (true)
            {
                throw new CustomLengthException("Duzgun Daxil Et");
            }

            //try
            //{
            //    var b = a[99];
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Index");
            //}
            //catch(NullReferenceException)
            //{
            //    Console.WriteLine("Ele Bele");
            //    throw;
            //}

            return a + " Code";
        }
    }
}
