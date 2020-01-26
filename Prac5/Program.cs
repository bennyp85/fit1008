using System;
using System.Collections.Generic;

namespace Prac5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Power(2, 3));
            
        }

        static List<int> Reverse(List<int> list)
        {
            int size = list.Count;
            List<int> items = new List<int>();
            for (int i = 0; i < size; i++)
            {
                items.Add(list[i]);
            }

            items.Reverse();
            return items;

        }

        static List<int> Binary(int n)
        {
            var binary = Convert.ToString(n, 2);
            List<int> revBinary = new List<int>();
            for (int i = binary.Length-1; i >= 0; i--)
            {
                int item = 0;
                if (binary[i] == 48) item = 0;
                else item = 1;
                revBinary.Add(item);
            }
            return Reverse(revBinary);
        }

        static int Power(int b, int e)
        {
            List<int> revBinStr = Binary(e);
            List<int> revList = new List<int>();

            for (int i = 0; i < revBinStr.Count; i++)
            {
                revList.Add(revBinStr[i]);
            }

            int result = 1;
            int idx = revList.Count - 1;

            while (idx >= 0)
            {
                result *= result;
                if (revList[idx] == 1)
                {
                    result *= b;
                }

                idx -= 1;
            }

            return result;
        }
    }
}