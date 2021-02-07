using System;
using System.Globalization;
namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            DateTime d2 = DateTime.Parse("2021-11-30");
            Console.WriteLine(d2);

            Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(d1);
            }
        }
    }
}