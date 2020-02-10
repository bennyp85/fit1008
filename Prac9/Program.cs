using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace Prac9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
//            using (StreamReader sr = new StreamReader(@"/Users/benjamin/Desktop/Alphabet.txt")) 
//            {
//                //This is an arbitrary size for this example.
//                char[] c = null;
//
//                while (sr.Peek() >= 0) 
//                {
//                    c = new char[27];
//                    sr.Read(c, 0, c.Length);
//                    
//                    //The output will look odd, because
//                    //only five characters are read at a time.
//                    
//                    Console.WriteLine(c);
//                }
//            }

//            using (StreamWriter writer = new StreamWriter(@"/Users/benjamin/Desktop/Alphabet.txt")) ;
//            string line;
//            using (StreamReader reader = new StreamReader(@"/Users/benjamin/Desktop/Alphabet.txt"))
//            {
//                line = reader.ReadLine();
//            }
//            Console.WriteLine(line);

//            // read in text file
            string text = File.ReadAllText(@"/Users/benjamin/Desktop/Alphabet.txt");

            // count number of letters 
            int count = 0;
            
            // List to add lowercase letters to
            List<char> letters = new List<char>();
            
            foreach (var VARIABLE in text)
            {
                // add to list if var is a letter
                if (Char.IsLetter(VARIABLE))
                {
                    letters.Add(char.ToLower(VARIABLE));
                
                    count += 1;
                }
            }
            
            

            Console.WriteLine(count);
            
            // create text file
            TextWriter tw = new StreamWriter(@"/Users/benjamin/Desktop/AlphabetLower.txt");

            // write to text file
            foreach (char s in letters)
                // Using Write compared to WriteLine?
                tw.Write(s);

            tw.Close();

//            StreamWriter sw = File.CreateText(@"/Users/benjamin/Desktop/AlphabetLower.txt");
//            foreach (char VARIABLE in letters)
//            {
//                sw.WriteLine(VARIABLE);
//            }
                
            
            
//            using (StreamReader sr = File.OpenText(@"/Users/benjamin/Desktop/AlphabetLower.txt")) 
//            {
//                string s = "";
//                while ((s = sr.ReadLine()) != null) 
//                {
//                    Console.WriteLine(s);
//                }
//            }


//            foreach (var VARIABLE in letters)
//            {
//                Console.WriteLine(VARIABLE);
//            }
            
//            string[] readText = File.ReadAllLines(@"/Users/benjamin/Desktop/AlphabetLower.txt", Encoding.UTF8);
//            foreach (string s in readText)
//            {
//                Console.WriteLine(s);
//            }
//            
//            Console.WriteLine(count);
//            
//            //write to file
//            foreach (char VARIABLE in letters)
//            {
//                File.WriteAllText($@"/Users/benjamin/Desktop/AlphabetLower.txt", VARIABLE);    
//            }
//            

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
            
            List<int> unsorted = new List<int>();
            List<int> sorted;
            
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                unsorted.Add(random.Next(0, 100));
            }

            sorted = MergeSort(unsorted);

            foreach (var VARIABLE in sorted)
            {
                Console.WriteLine(VARIABLE + " ");
            }

        }
        
            
        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }
            
            List<int> right = new List<int>();
            List<int> left = new List<int>();

            int middle = unsorted.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }
                
            
            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> right, List<int> left)
        {
            List<int> result = new List<int>();
            // compare elements in left and right List<int>
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() >= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                    
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}