using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackLibrary.interfaces
{
   public  interface ICustomStackUsingArray
    {
        int Size();
        bool IsEmpty();
        bool Push(object data);
        object Pop();
        object Peek();
        void Clear();
        void PrintStack();
    }
}
