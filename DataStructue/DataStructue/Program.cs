using DataStructue;
using System.Collections.Generic;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> List = new LinkedList<int>();
            Console.WriteLine("Search any of no given below\n");
            int[] number = { 1, 2, 3, 4, 5, 56, 58, 47, 54, 95, 62, 34, 547, 215, 21 };
            int[] list = number;
            Array.Sort(list);
            Array.Sort(list);
            int count = 0;

            while (count < list.Length)
            {
                List.Add(list[count++]);
            }

            List.Display();
            List.Search(47);
        }
    }
}