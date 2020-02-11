using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            var root = new TreeNode();
            BinarySearchTree bst = new BinarySearchTree(root);
            
            // adding '0' ? root value?
            bst.Insert(10);
            bst.Insert(2);
            // not printing '15'
            bst.Insert(15);
            bst.Insert(4);
            bst.Insert(25);
            bst.Inorder(root);
            
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
            
//            List<int> unsorted = new List<int>();


//            Random random = new Random();
//
//            for (int i = 0; i < 10; i++)
//            {
//                unsorted.Add(random.Next(0, 100));
//            }
            List<int> unsorted = new List<int> { 21, 46, 46, 55, 17, 21, 55, 55 };

            var sorted = MergeSort(unsorted);
            var frequency = sorted.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            foreach (var VARIABLE in frequency)
            {
                Console.WriteLine(VARIABLE);
            }

//            foreach (var VARIABLE in sorted)
//            {
//                Console.WriteLine(VARIABLE + " ");
//            }

//            IEnumerable<int> distinctAges = sorted.Distinct();
//
//            Console.WriteLine("Distinct Values:");
//
//            foreach (int age in distinctAges)
//            {
//                Console.WriteLine(age);
//            }
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

    public class TreeNode
    {
        public int Data;
        public TreeNode Left;
        public TreeNode Right;
        public void PrintNode()
        {
            Console.WriteLine(Data + " ");
        }
    }
    
    class BinarySearchTree
    {
        public TreeNode TNode { get; set; }

        public BinarySearchTree(TreeNode treeNode)
        {
            TNode = treeNode;
            treeNode = null;
        }

        // is Insert placing values in the correct position
        public void Insert(int i)
        {
            TreeNode newNode = new TreeNode();
            newNode.Data = i;
            if (TNode == null)
            {
                TNode = newNode;
            }
            else
            {
                TreeNode current = TNode;
                TreeNode parent;
                //if i is less than parent add to left, else add tor ight
                while (true)
                {
                    parent = current;
                    if (i < current.Data)
                    {
                        // add to left node
                        current = current.Left;
                        if (current == null)
                        {
                            //new node
                            parent.Left = newNode;
                            break;
                        }
                    }

                    if (i > current.Data)
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }

                }
            }
        }
//        public void InOrder()
//        {
//            Stack<TreeNode> s = new Stack<TreeNode>();
//            TreeNode curr = root;
//            while (curr != null || s.Count > 0)
//            {
//
//                /* Reach the left most Node of the  
//                curr Node */
//                while (curr != null)
//                {
//                    /* place pointer to a tree node on  
//                       the stack before traversing  
//                      the node's left subtree */
//                    s.Push(curr);
//                    curr = curr.Left;
//                }
//
//                /* Current must be NULL at this point */
//                curr = s.Pop();
//
//                Console.Write(curr.Data + " ");
//
//                /* we have visited the node and its  
//                   left subtree.  Now, it's right  
//                   subtree's turn */
//                curr = curr.Right;
//            }
//        }
        public void Inorder(TreeNode node) 
        { 
            if (node == null) 
                return; 
  
            /* first recur on left child */
            Inorder(node.Left); 
  
            /* then print the data of node */
            Console.Write(node.Data + " "); 
  
            /* now recur on right child */
            Inorder(node.Right); 
        }

    }
}
    