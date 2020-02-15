using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;

namespace Prac9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
//            NumOfChars(@"/Users/benjamin/Desktop/Alphabet.txt");
//            WriteToLower(@"/Users/benjamin/Desktop/Alphabet.txt", @"/Users/benjamin/Desktop/AlphabetLower.txt");
//            FreqCountDict(@"/Users/benjamin/Desktop/Alphabet.txt");
//            FreqCountList(@"/Users/benjamin/Desktop/Alphabet.txt");
            MatchValues(@"/Users/benjamin/Desktop/Alphabet.txt");
        }

        public static void  NumOfChars(string file)
        {
            string text = File.ReadAllText(file);

            // count number of letters 
            int characters = 0;
            
            // List to add lowercase letters to
            List<char> letters = new List<char>();
            
            foreach (var VARIABLE in text)
            {
                // add to list if var is a letter
                if (Char.IsLetter(VARIABLE))
                {
                    letters.Add(char.ToLower(VARIABLE));
                
                    characters += 1;
                }
            }
            Console.WriteLine(characters);
        }

        public static void WriteToLower(string infile, string outfile)
        {
            List<char> lowerList = new List<char>();
            string text = File.ReadAllText(infile);

            foreach (var VARIABLE in text)
            {
                // add to list if var is a letter
                if (Char.IsLetter(VARIABLE))
                {
                    lowerList.Add(char.ToLower(VARIABLE));
                }
            }
            TextWriter tw = new StreamWriter(outfile);

            // write to text file
            foreach (char s in lowerList)
                // Using Write compared to WriteLine?
                tw.Write(s);

            tw.Close();
        }

        public static Dictionary<char, int> FreqCountDict(string file)
        {
            string text = File.ReadAllText(file);
            List<char> valueList = new List<char>();
            foreach (var VARIABLE in text)
            {
                if (Char.IsLetter(VARIABLE))
                {
                    valueList.Add(VARIABLE);
                }
            }
            var frequency = valueList.GroupBy(p => p).OrderByDescending(r=>r.Count()).ToDictionary(q => q.Key, q => q.Count());

//            var frequency = sorted.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            foreach (var VARIABLE in frequency)
            {
                Console.WriteLine("{0}, {1}", VARIABLE.Key, VARIABLE.Value);
            }
            return frequency;
        }
        
        public static List<char> FreqCountList(string file)
        {
            string text = File.ReadAllText(file);
            List<char> valueList = new List<char>();
            foreach (var VARIABLE in text)
            {
                if (Char.IsLetter(VARIABLE))
                {
                    valueList.Add(VARIABLE);
                }
            }
//            foreach (var VARIABLE in valueList)
//            {
//                Console.WriteLine(VARIABLE);
//            }
            return valueList;
        }

        public static List<char> MergeSort(List<char> arr)
        {
            if (arr.Count > 1)
            {
                int mid = arr.Count / 2;
                List<char> L = new List<char>(arr.Take(mid).ToArray());
                List<char> R = new List<char>(arr.Skip(mid).Take(arr.Count).ToArray());

                MergeSort(L);
                MergeSort(R);


                int i = 0;
                int j = 0;
                int k = 0;
                while (i < L.Count && j < R.Count)
                {
                    if (L[i] > R[j])
                    {
                        arr[k] = L[i];
                        i += 1;
                    }
                    else
                    {
                        arr[k] = R[j];
                        j += 1;
                    }

                    k += 1;

                }

                while (i < L.Count)
                {
                    arr[k] = L[i];
                    i += 1;
                    k += 1;
                }

                while (j < R.Count)
                {
                    arr[k] = R[j];
                    j += 1;
                    k += 1;
                }
            }
            return arr;
        }

        public static void MatchValues(string file)
        {
            var valueList = MergeSort(FreqCountList(file));
            var mydict = FreqCountDict(file);
            List<char> uniqueList = new List<char>();
            foreach (var VARIABLE in valueList)
            {
                if (uniqueList.Contains(VARIABLE) == false)
                {
                    uniqueList.Add(VARIABLE);
                }
            }
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Right { get; set; }
        public Node Left { set; get; }

        public Node() { }

        public Node(int data)
        {
            this.Data = data;
        }
    }

    public class BinaryTree
    {
        private Node _root;

        public BinaryTree()
        {
            _root = null;
        }

        public void Insert(int data)
        {
            if (_root == null)
            {
                _root = new Node(data);
                return;
            }

            InsertRec(_root, new Node(data));
        }

        public void InsertRec(Node root, Node newNode)
        {
            if (root == null)
            {
                root = newNode;
            }

            if (newNode.Data < root.Data)
            {
                if (root.Left == null)
                {
                    root.Left = newNode;
                }
                else InsertRec(root.Left, newNode);
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = newNode;
                }
                else InsertRec(root.Right, newNode);
            }
        }

        private void DisplayTree(Node root)
        {
            if (root == null) return;
            
            DisplayTree(root.Left);
            Console.WriteLine(root.Data + " ");
            DisplayTree(root.Right);
        
        }

        public void DisplayTree()
        {
            DisplayTree(_root);
        }
    }
}