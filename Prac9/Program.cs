using System;
using System.IO;

namespace Prac9
{
    class Program
    {
        static void Main(string[] args)
        {
//            Console.WriteLine("Hello World!");
//            string text = System.IO.File.ReadAllText(@"/Users/benjamin/Desktop/Alphabet.txt");
//            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

            string[] lines = System.IO.File.ReadAllLines(@"/Users/benjamin/Desktop/Alphabet.txt");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine(line.ToLower());
            }
            
//            string str = "Some number of characters";
//            char[] b = new char[str.Length];
//
//            using (StringReader sr = new StringReader(str))
//            {
//                // Read 13 characters from the string into the array.
//                sr.Read(b, 0, 13);
//                Console.WriteLine(b);
//
//                // Read the rest of the string starting at the current string position.
//                // Put in the array starting at the 6th array member.
//                sr.Read(b, 5, str.Length - 13);
//                Console.WriteLine(b);
//            }


        }
    }
}