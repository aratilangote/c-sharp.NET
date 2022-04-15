using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Stack<int> myStack = new Stack<int>();
		myStack.Push(1);
		myStack.Push(2);
		myStack.Push(3);
		myStack.Push(4);

		Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

		if (myStack.Count > 0)
		{
			Console.WriteLine(myStack.Peek());
			Console.WriteLine(myStack.Peek());
		}

		Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);
	}
}