using System;

namespace TestProj
{
    class Stack
    {
        public Node Top { get; set; }
        public int Length { get; set; }

        public Stack()
        {
            Top = null;
            Length = 0;
        }

        public void Push(string data)
        {
            if(Length == 0)
            {
                Top = new Node(data);
                Length++;
            }
            else
            {
                Node temp = Top;
                Top = new Node(data);
                Top.Next = temp;
                Length++;
            }
        }

        public Node Peek()
        {
            return Top;
        }

        public Node Pop()
        {
            if(Top == null)
            {
                return null;
            }
            else
            {
                Node temp = Top.Next;
                Top = temp;
                Length--;
                return Peek();                
            }
        }

        public void ListStack(Node top)
        {
            if(top.Next == null)
            {
                Console.WriteLine(top.Data);
            }
            else
            {
                ListStack(top.Next);
                Console.WriteLine(top.Data);
            }
        }
    }
}
