using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        private readonly List<object> stackList = new List<object>();
        private int _head;

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
                    _head++;
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Cannot push a null object into the stack");
            }
        }

        public object Pop()
        {
            try
            {
                if(_head == 0)
                {
                    throw new InvalidOperationException();
                }

                else
                {
                    object tmp = stackList[_head - 1];
                    stackList.RemoveAt(_head - 1);
                    _head--;

                    return tmp;

                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Cannot Pop() a empty Stack, method returns null");
                return null;
            }
        }

        public void Clear()
        {
            for (int i = 0; i < stackList.Count; i++)
            {
                stackList.RemoveAt(i);
            }
            _head = 0;
        }
    }
}
