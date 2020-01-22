using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Resources;

namespace Prac3
{
    static class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            watch.Start();
            int counter = 1;

            while (counter <= 8)
            {
                List<int> arr = new List<int>();
                for (int i = 1; i <= counter; i++)
                {
                    arr.Add(i);
                }

                FindMAxSumInterval(arr);
                watch.Stop();
                Console.WriteLine("{0} taken", watch.ElapsedMilliseconds);
                counter *= 2;
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

        static void BubbleSort(List<int> arr)
        {
            int n = arr.Count;
                int t = 0;
                for (int p = 0; p <= arr.Count - 2; p++)
                {
                    for (int i = 0; i <= arr.Count - 2; i++)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            t = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = t;
                        }
                    }
                }
                Console.WriteLine("{0} items", arr.Count);
                foreach (var VARIABLE in arr)
                {
                    Console.WriteLine("{0}", VARIABLE);
                }
        }

        static void FindMAxSumInterval(List<int> arr)
        {
            int max_sum = arr.Min();
            
            for (int i = 0; i < arr.Count; i++)
            {
                List<int> sumList = new List<int>();
                sumList.Add(arr[i]);
                for (int j = i+1; j < arr.Count; j++)
                {
                    sumList.Add(arr[j]);
                    int sum = sumList.Sum();
                    
                    if (sum > max_sum)
                    {
                        max_sum = sum;
                    }
                }
            }

            Console.WriteLine("{0}", max_sum);
        }
    }
}