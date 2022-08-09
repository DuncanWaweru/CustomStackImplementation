using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackLibrary.interfaces
{
   public  interface ICustomStackUsingLinkedList
    {
        int Size();
        bool IsEmpty();
        void Push(object data);
        object Pop();
        object Peek();
        void Clear();
        void PrintStack();
    }
}
