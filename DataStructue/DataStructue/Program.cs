using DataStructue;
using System.Collections.Generic;

namespace DataStructure
{
    internal class Program
    {
        public static string ParaenthesisTextPath = (@"E:\Visual Studio\.Net\DataStruct\DataStructue\DataStructue\Paraenthesis.txt");
        static void Main(string[] args)
        {
            Stack stack= new Stack();
            stack.ReadTextFile(ParaenthesisTextPath);
        }
    }
}