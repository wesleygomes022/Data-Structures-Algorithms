using System;

namespace BufferCircular
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularQueue Q = new CircularQueue(5);

            Q.insert(10);
            Q.insert(20);
            Q.insert(30);
            Q.insert(40);
            Q.insert(50);

            Q.printQueue();

            Console.WriteLine();
            Q.delete();
            Q.delete();

            Console.WriteLine();
            Q.printQueue();

            Q.insert(60);

            Console.WriteLine();
            Q.printQueue();

            Console.WriteLine();
            Q.insert(70);           

            Console.WriteLine();
            Q.printQueue();
            Console.WriteLine();
            Q.insert(80);

        }
    }
}
