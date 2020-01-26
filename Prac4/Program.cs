using System;
using System.Runtime.Serialization.Formatters;

namespace Prac4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Pythagorian(2, 3);
            Console.WriteLine(IsLeap(2008));
        }

        static void Pythagorian(int m, int n)
        {
            double a = Math.Abs(Math.Pow(m, 2) - Math.Pow(n, 2));
            double b = 2 * m * n;
            double c = Math.Pow(m, 2) + Math.Pow(n, 2);
            Console.WriteLine("{0} {1} {2}", a, b, c );
        }

        static bool IsLeap(int year)
        {
            bool isLeap = year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
            return isLeap;
        }
    }
}