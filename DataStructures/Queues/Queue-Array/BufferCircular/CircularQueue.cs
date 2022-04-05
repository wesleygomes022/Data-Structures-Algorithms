using System;

namespace BufferCircular
{
    class CircularQueue
    {
        private int[] Ele;
        private int Front;
        private int Rear;
        private int Max;

        public CircularQueue(int size)
        {
            Ele = new int[size];
            Front = 0;
            Rear = -1;
            Max = size;
        }

        public void insert(int item)
        {
            if (QtdElem() >= Max)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                Rear = (Rear + 1) % Max;
                Ele[Rear] = item;
            }
        }

        public void delete()
        {
            if (QtdElem() == 0)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("deleted element is: " + Ele[Front]);

                Ele[Front] = 0;
                Front = (Front + 1) % Max;
            }
        }

        public void printQueue()
        {
            if (QtdElem() == 0)
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

        public int QtdElem()
        {
            if (Rear >= Front || Rear == -1)
            {
                return Rear - Front + 1;
            }
            else
            {
                return (Max - Front) + Rear + 1; 
            }
        }
    }
}
