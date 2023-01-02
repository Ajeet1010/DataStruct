using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructue
{
    public class Stack
    {
        public void ReadTextFile(string filepath)
        {
            string list = File.ReadAllText(filepath);
            string[] words = list.Split(" ");
            Stack<string> stack = new Stack<string>();
            foreach (var data in words)
            {
                if (data.Equals("("))
                    stack.Push(data);
                if (data.Equals(")"))
                    stack.Pop();
            }
            if (stack.Peek())
            {
                Console.WriteLine("Expression is balanced");
            }
            else
                Console.WriteLine("Expression is not balanced");
        }

        internal void ReadTextFile(object ParanthesisTextPath)
        {
            throw new NotImplementedException();
        }
    }
}
