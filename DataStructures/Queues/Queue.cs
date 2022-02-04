using System;

namespace TestProj
{
    class Queue
    {
        public Node First { get; set; }
        public Node Last { get; set; }
        public int Length { get; set; }

        public Node Peek()
        {
            return First;
        }

        public void Enqueue(string data)
        {
            Node newNode = new Node(data);

            if (Length == 0)
            {
                First = newNode;
                Last = newNode;
                Length++;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
                Length++;
            }
        }

        public void Dequeue()
        {
            First = First.Next;
            Length--;
        }

        public void ListQueue()
        {
            Node temp = First;
            while(temp.Next != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
            Console.WriteLine(temp.Data);
        }
    }
}
