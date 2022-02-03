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
            Console.WriteLine("Length: " + stack.Length);
            stack.Push("Google");
            stack.Push("Udemy");
            stack.Push("Discord");
            Console.WriteLine("Length: " + stack.Length);
            Console.WriteLine("Peek: " + stack.Pop().Data);
            Console.WriteLine("Length: " + stack.Length);

        }
    }
}

