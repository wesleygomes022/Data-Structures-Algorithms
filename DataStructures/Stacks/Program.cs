using System;
using System.IO;
using System.Collections.Generic;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("Google");
            stack.Push("Udemy");
            stack.Push("Discord");
            Console.WriteLine(stack.Length);
            Console.WriteLine("-----------------------------");
            stack.ListStack(stack.Peek());
        }
    }
}

