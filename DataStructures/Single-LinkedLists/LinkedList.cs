using System;

namespace TestProj
{
    class LinkedList
    {
        public Node Head { get; set; }

        public void Append(LinkedList list, int data)
        {
            Node new_node = new Node(data);
            if(Head == null)
            {
                Head = new_node;
            }
            else 
            {
                Node lastNode = GetLastNode(list);
                lastNode.Next = new_node;
            }
        }

        public Node GetLastNode(LinkedList list)
        {
            Node temp = list.Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }

        public Node SearchNode(LinkedList list, int data)
        {
            Node temp = list.Head;
            while(temp.Next != null)
            {
                if (temp.Data == data)
                    return temp;

                temp = temp.Next;
            }

            throw new Exception("Your item does not exist in the list.");
        }

        public void RemoveNode(LinkedList list, int data)
        {
            Node node = list.Head;
            Node prev = null;
            if(node != null && node.Data == data)
            {
                list.Head = node.Next;
            }
            else
            {
                while(node.Next != null && node.Data != data)
                {
                    prev = node;
                    node = node.Next;
                }
                if(node.Data == data)
                {
                    prev.Next = node.Next;
                }
                else
                {
                    throw new Exception("Error: value does not exists in the list.");
                }
            }
        }

        public void List(LinkedList list)
        {
            Node temp = list.Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }

        public void Reverse(LinkedList list)
        {
            Node prev = null;
            Node current = list.Head;
            Node temp = null;

            while(current != null)
            {
                temp = current.Next;
                current.Next = prev;
                prev = current;
                current = temp;
            }

            list.Head = prev;
        }
    }
}
