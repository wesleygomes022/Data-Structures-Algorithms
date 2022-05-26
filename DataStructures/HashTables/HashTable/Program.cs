using System;
using System.Collections.Generic;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int>[] temp = new LinkedList<int>[10];
            temp[0] = new LinkedList<int>();
            temp[0].AddLast(10);
            temp[0].AddLast(20);
            temp[0].AddLast(30);

            temp[1] = new LinkedList<int>();
            temp[1].AddLast(110);

            temp[2] = new LinkedList<int>();
            temp[2].AddLast(120);

            temp[3] = new LinkedList<int>();
            temp[3].AddLast(130);

            temp[4] = new LinkedList<int>();
            temp[4].AddLast(140);

            int i = 0;
            while (i<temp.Length)
            {
                while(temp[i] != null)
                {
                    foreach (int el in temp[i])
                    {
                        Console.WriteLine($"{i} -> {el}");                        
                    }
                    i++;
                    Console.WriteLine();
                }
                i++;
            }             
        }
    }
}
