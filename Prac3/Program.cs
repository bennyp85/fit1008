using System;
using System.Diagnostics;
using System.Resources;

namespace Prac3
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            watch.Start();
            int counter = 1;
            while(counter <= 1024)
            {
                Console.WriteLine("Counter {0}", counter);
                TestSumItem(counter);
                counter *= 2;
                watch.Stop();
                Console.WriteLine(watch.ElapsedMilliseconds);
            }
            
            
        }

        static void TestSumItem(int n)
        {
            var sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("{0}", sum);
        }
    }
}