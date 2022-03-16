using System;

namespace BufferCircular
{
    class CircularQueue
    {
        private int[] Ele;
        private int Front;
        private int Rear;
        private int Max;
        private int Count;

        public CircularQueue(int size)
        {
            Ele = new int[size];
            Front = 0;
            Rear = -1;
            Max = size;
            Count = 0;
        }

        public void insert(int item)
        {
            if (Count == Max)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                Rear = (Rear + 1) % Max;
                Ele[Rear] = item;

                Count++;
            }
        }

        public void delete()
        {
            if (Count == 0)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("deleted element is: " + Ele[Front]);

                Ele[Front] = 0;
                Front = (Front + 1) % Max;

                Count--;
            }
        }

        public void printQueue()
        {
            if (Count == 0)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for(int i = 0; i < Max; i++)
                {
                    Console.WriteLine($"Item[{i}]: {Ele[i]}");
                }
            }
        }
    }
}
