using System;
using System.IO;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            Console.WriteLine($"Length: {queue.Length}");
            queue.Enqueue("Wesley");
            queue.Enqueue("Luis");
            queue.Enqueue("Vilma");
            queue.Enqueue("Felipe");
            Console.WriteLine($"Length: {queue.Length}");
            Console.WriteLine($"Peek: {queue.Peek().Data}");
            Console.WriteLine("--------------------");
            Console.WriteLine("ListQueue:");
            queue.ListQueue();
            Console.WriteLine("--------------------");
            Console.WriteLine("ListQueue:");
            queue.Dequeue();
            queue.ListQueue();
            Console.WriteLine("--------------------");
            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine("ListQueue:");
            queue.ListQueue();
        }
    }
}

