using System;

namespace CircularBuffer
{
    public class CBuffer
    {
        private int[] Ele;
        private int First;
        private int Last;
        private int Max;

        public CBuffer(int size)
        {
            Ele = new int[size];
            First = -1;
            Last = -1;
            Max = size;
        }

        public void Queue(int item)
        {
            if (QtdElem() >= Max)
            {
                throw new InvalidOperationException("Queue overflow.");
            }
            else
            {
                if (First == -1)
                {
                    First = Last = 0;
                }                
                else
                {
                    Last = (Last + 1) % Max;                                        
                }
                Ele[Last] = item;
            }
        }

        public int DeQueue()
        {
            int q = QtdElem();
            if (q == 0)
            {
                throw new InvalidOperationException("Empty queue.");
            }

            int temp = Ele[First];

            if (q == 1)
            {
                First = Last = -1;
            }
            else
            {
                First = (First + 1) % Max;
            }

            return temp;
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
                for (int i = 0; i < Max; i++)
                {
                    Console.WriteLine($"Item[{i}]: {Ele[i]}");
                }
            }
        }

        public int QtdElem()
        {
            if (First == -1)
            {
                return 0;
            }
            if (Last >= First)
            {
                return Last - First + 1;
            }
            else
            {
                return (Max - First) + Last + 1;
            }
        }

        public int FirsEle()
        {
            return Ele[First];
        }
    }
}
