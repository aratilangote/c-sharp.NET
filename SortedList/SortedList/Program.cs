using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		SortedList<int, string> numberNames = new SortedList<int, string>()
									{
										{3, "Three"},
										{5, "Five"},
										{1, "One"}
									};

		Console.WriteLine("---Initial key-values---");

		foreach (KeyValuePair<int, string> kvp in numberNames)
			Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

		numberNames.Add(6, "Six");
		numberNames.Add(2, "Two");
		numberNames.Add(4, "Four");

		Console.WriteLine("\n---After adding new key-values---");

		foreach (var kvp in numberNames)
			Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

		SortedList<string, string> cities = new SortedList<string, string>()
											{
												{"London", "UK"},
												{"New York", "USA"}
											};

		Console.WriteLine("\n---Initial key-values---");

		foreach (var kvp in cities)
			Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

		cities.Add("Mumbai", "India");
		cities.Add("Johannesburg", "South Africa");

		Console.WriteLine("\n---After adding new key-values---");

		foreach (var kvp in cities)
			Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
	}
}