using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        private readonly List<object> stackList = new List<object>();
        private int head;

        public void Push(object obj)
        {
            try
            {
                if (obj == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    stackList.Add(obj);
                    head++;
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Cannot push a null object into the stack");
            }
        }

        public object Pop()
        {
            object tmp = stackList[head - 1];
            stackList.RemoveAt(head - 1);
            head--;

            return tmp;
        }

        public void Clear()
        {
            for (int i = 0; i < stackList.Count; i++)
            {
                stackList.RemoveAt(i);
            }
            head = 0;
        }
    }
}
