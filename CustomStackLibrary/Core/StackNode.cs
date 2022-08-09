using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackLibrary.Core
{
	public class StackNode
	{
		public object data;
		public StackNode next;
		public StackNode(object data, StackNode top)
		{
			this.data = data;
			this.next = top;
		}
	}
}
