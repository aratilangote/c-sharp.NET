using System;
using System.Collections.Generic;
using System.Linq;


class Program
    {
        static void Main(string[] args)
        {
			var cities = new Dictionary<string, string>(){
			{"UK", "London, Manchester, Birmingham"},
			{"USA", "Chicago, New York, Washington"},
			{"India", "Mumbai, New Delhi, Pune"}
		};

			Console.WriteLine(cities["UK"]); //prints value of UK key
			Console.WriteLine(cities["USA"]);//prints value of USA key
											 //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

			//use ContainsKey() to check for an unknown key
			if (cities.ContainsKey("France"))
			{
				Console.WriteLine(cities["France"]);
			}

			//use TryGetValue() to get a value of unknown key
			string result;

			if (cities.TryGetValue("France", out result))
			{
				Console.WriteLine(result);
			}

			Console.WriteLine("\n---access elements using for loop---");
			//use ElementAt() to retrieve key-value pair using index
			for (int i = 0; i < cities.Count; i++)
			{
				Console.WriteLine("Key: {0}, Value: {1}",
					cities.ElementAt(i).Key,
					cities.ElementAt(i).Value);
			}
		}
    }

