using CustomStackLibrary.Core;
using CustomStackLibrary.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackLibrary
{
    public class CustomStackUsingLinkedList : ICustomStackUsingLinkedList
	{
		public StackNode top;
		public int count;
		public CustomStackUsingLinkedList()
		{
			this.top = null;
			this.count = 0;
		}
		// Returns the number of element in stack
		public int Size()
		{
			Console.WriteLine($"Stack has {this.count} items.");
			return this.count;
		}
		public bool IsEmpty()
		{
			if (this.Size() > 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		// Add a new element in stack
		public void Push(object data)
		{
			// Make a new stack node
			// And set as top
			this.top = new StackNode(data, this.top);
			// Increase node value
			this.count++;
			Console.WriteLine($"{data} added to the stack.");
		}
		// Add a top element in stack
		public object Pop()
		{
			object temp = null;
			if (!this.IsEmpty() )
			{
				// Get remove top value
				temp = this.top.data;
				this.top = this.top.next;
				// Reduce size
				this.count--;
				Console.WriteLine($"{temp} removed from the stack.");

            }
            else
            {
				Console.WriteLine($"Stack is empty!");

			}
			return temp;
		}
		// Used to get top element of stack
		public object Peek()
		{
			if (!this.IsEmpty())
			{
				Console.WriteLine($"Top elemet in the stack is - {this.top.data}");
				return this.top.data;
			}
			else
			{
				Console.WriteLine($"Stack is empty!");
				return null;
			}
		}
		public void PrintStack()
        {
			Size();
			StackNode currentNode = top;
			while (currentNode != null)
			{
				Console.WriteLine(currentNode.data);
				currentNode = currentNode.next;
			}
			
		}
		public void Clear()
        {
			this.Size(); 
			this.top = null;
			this.count = 0;
			Console.WriteLine("Stack has been cleared");
			PrintStack();

		}
	}
}
