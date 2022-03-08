using System;

namespace BufferCircular
{
    class Queue
    {
        public int Front { get; private set; } = 0;
        public int Last { get; private set; } = 0;
        public int Capacity { get; private set; } = 0;
        public int[] Head;

        public Queue(int c)
        {
            Capacity = c;
            Head = new int[c];
        }

        public void QueueValue(int value)
        {
            if (Last < Capacity)
            {
                Head[Last] = value;
                Last++;
            }
            else
            {
                Console.WriteLine("Queue already full.");
            }
        }

        public void UnQueue()
        {
            if (Last > 0)
            {
                for (int i = 0; i < Last - 1; i++)
                {
                    Head[Front + i] = Head[i + 1];
                }
                Head[Last - 1] = 0;
                Last--;
            }
            else
            {
                Console.WriteLine("Queue is empty.");
            }

        }

        public int QueueFront()
        {
            if (Front == Last)
            {
                Console.WriteLine("Queue is empty.");
                return 0;
            }
            else
            {
                return Head[Front];
            }
        }

        public void ListQueue()
        {
            for(int i = 0; i < Last; i++)
            {
                Console.WriteLine($"{i} --> {Head[i]}");
            }
        }
    }
}
