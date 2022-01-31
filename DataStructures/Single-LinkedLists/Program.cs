using System;
using System.IO;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LinkedList list = new LinkedList();
                list.Append(list, 10);
                list.Append(list, 20);
                list.Append(list, 30);

                list.List(list);

                //list.RemoveNode(list, 5);
                list.Reverse(list);
                Console.WriteLine("--------------------------------");
                list.List(list);

                //Node temp = list.SearchNode(list, 25);
                //Console.WriteLine(temp.Data);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }
    }
}
