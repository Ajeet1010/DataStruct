using DataStructue;
using System.Collections.Generic;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Linkedlist<string> list = new Linkedlist<string>();
            Console.WriteLine("In below para type any word to search\n");
            Console.WriteLine("As a man was passing the elephants, he suddenly stopped, " +
                "confused by the fact that these huge creatures were being held by only " +
                "a small rope tied to their front leg. No chains, no cages.\n");
            string text = Console.ReadLine();
            Console.WriteLine("Searching word is: " + text);
            string[] textlist = text.Split(" ");

            foreach (var data in textlist)
            {
                list.Add(data);
            }

            list.Display();
            list.Search(text);
        }
    }
}