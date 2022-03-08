using System;

namespace BufferCircular
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue(5);

            Console.WriteLine(q.QueueFront());
            Console.WriteLine();

            q.UnQueue();
            Console.WriteLine();

            q.QueueValue(5);
            q.QueueValue(10);
            q.QueueValue(15);
            q.ListQueue();
            Console.WriteLine();
            q.UnQueue();
            q.ListQueue();

            Console.WriteLine();
            q.UnQueue();
            q.ListQueue();

            Console.WriteLine();
            q.QueueValue(20);
            q.QueueValue(25);
            q.QueueValue(30);
            Console.WriteLine(q.QueueFront());

            Console.WriteLine();
            q.ListQueue();

            q.QueueValue(35);
            q.QueueValue(40);

            Console.WriteLine();
            q.ListQueue();

        }
    }
}
