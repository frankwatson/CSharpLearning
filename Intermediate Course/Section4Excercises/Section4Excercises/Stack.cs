using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Section4Excercises
{
    public class Stack
    {
        private List<object> _stackList = new List<object>();
        private object popObj;

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Null is not a valid object.");
            }
            else
            {
                _stackList.Add(obj);
            }
        }

        public object Pop()
        {
            if (_stackList.Count == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                popObj = _stackList[_stackList.Count - 1];
                _stackList.RemoveAt(_stackList.Count - 1);
                return popObj;
            }
        }

        public void Clear()
        {
            _stackList.Clear();
        }
    }
}