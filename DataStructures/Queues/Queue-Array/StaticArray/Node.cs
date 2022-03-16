using System;

namespace TestProj
{
    class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }

        public Node(string data)
        {
            Data = data;
            Next = null;
        }
    }
}
