using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Prac6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
//            List<string> stack = new List<string>();
//            Stack myStack = new Stack(stack);
//            myStack.Push(stack, "1");
//            myStack.Push(stack, "7");
//            myStack.Push(stack, "-");
//            myStack.Push(stack, "4");
//            myStack.Push(stack, "5");
//            myStack.Push(stack, "+");
//            myStack.Push(stack, "*");
            List<string> stack = new List<string>();
            Stack myStack = new Stack(stack);
            Describe(myStack);

        }

        static string Describe(Stack myStack)
        {
            
            myStack.Push("1");
            myStack.Push( "7");
            myStack.Push("-");
            myStack.Push("4");
            myStack.Push("5");
            myStack.Push("+");
            myStack.Push("*");
            
            int number;
            string myString = "";

            foreach (string VARIABLE in myStack)
            {
                if(VARIABLE == "+")
               {
                   Console.WriteLine(" Operator");
                   var v1 = Convert.ToInt16(myStack.Pop());
                   var v2 = Convert.ToInt16(myStack.Pop());
                   int result = v1 + v2;
                   myString = result.ToString();
                   myStack.Push(myString);
               }

               if (VARIABLE == "-")
               {
                   Console.WriteLine(" Operator");
                   var v1 = Convert.ToInt16(myStack.Pop());
                   var v2 = Convert.ToInt16(myStack.Pop());
                   int result = v1 - v2;
                   myString = result.ToString();
                   myStack.Push(myString);
               }
               
               if (VARIABLE == "*")
               {
                   Console.WriteLine(" Operator");
                   var v1 = Convert.ToInt16(myStack.Pop());
                   var v2 = Convert.ToInt16(myStack.Pop());
                   int result = v1 * v2;
                   myString = result.ToString();
                   myStack.Push(myString);
               }
               
               if (VARIABLE == "/")
               {
                   Console.WriteLine(" Operator");
                   var v1 = Convert.ToInt16(myStack.Pop());
                   var v2 = Convert.ToInt16(myStack.Pop());
                   int result = v1 / v2;
                   myString = result.ToString();
                   myStack.Push(myString);
               }

               bool isParsable = Int32.TryParse((ReadOnlySpan<char>) VARIABLE, out number);
               if (isParsable)
               {
                   Console.WriteLine(" Integer");
                   myStack.Push(VARIABLE);
               }
               
               else
               {
                   Console.WriteLine(" Is Invalid");
               }
            }
            return myString;
        }
    }

    public class Stack
    {
        public Stack(List<string> stack)
        {
            throw new NotImplementedException();
        }

        public int Len(List<string> stack)
        {
            return stack.Count;
        }

        public string Str(List<string> stack)
        {
            string myString = "";
            foreach (var VARIABLE in stack)
            {
                
                int number;
                bool isParsable = Int32.TryParse(VARIABLE, out number);
                if (isParsable)
                {
                    myString += number;
                }
            }
            return myString;
        }
        
        //maybe just use C# push function
//        public void Push(List<string> stack, string item)
//        {
//            stack.Add(item);
//        }

        // must return string
        // assign popped item to variable?
//        public string Pop(List<string> stack)
//        {
//            return stack.Pop();
//
//        }
        
        public void Print(List<string> stack)
        {
            foreach (var VARIABLE in stack)
            {
                int number;
                bool isParsable = Int32.TryParse(VARIABLE, out number);
                if (isParsable) Console.WriteLine(number);
            }
        }

        public int Size(List<string> stack)
        {
            int count = 0;
            foreach (var VARIABLE in stack)
            {
                int number;
                bool isParsable = Int32.TryParse(VARIABLE, out number);
                if (isParsable) count += 1;
            }
            return count;
        }

        public bool Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(string p0)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}