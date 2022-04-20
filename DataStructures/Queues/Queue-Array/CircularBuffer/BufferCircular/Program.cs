using System;

namespace BufferCircular
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularQueue Q = new CircularQueue(5);

            Q.Queue(10);
            Q.Queue(20);
            Q.Queue(30);
            Q.Queue(40);
            Q.Queue(50);

            Q.printQueue();
            
            Console.WriteLine();
            Q.DeQueue();
            Q.DeQueue();
            
            Console.WriteLine();
            Q.printQueue();
            
            Q.Queue(60);
            Console.WriteLine();
            Q.printQueue();
            
            Console.WriteLine();
            Q.Queue(70);           
            
            Console.WriteLine();
            Q.printQueue();
            Console.WriteLine();
            Q.Queue(80);

        }
    }
}
