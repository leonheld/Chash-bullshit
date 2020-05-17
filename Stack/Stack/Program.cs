using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            //for (int i = 16; i < 654; i++)
            //{
            //    stack.Push(i);
            //}

            for (int i = 16; i < 654; i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
