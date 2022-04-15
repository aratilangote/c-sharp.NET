using System;
using System.Collections;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] ar)
        {
            var arr = new ArrayList();
            Console.WriteLine("Additing names is arraylist: ");
            arr.Add("1");
            arr.Add("America");
            arr.Add("Berline");
            arr.Add(" ");
            arr.Add("true");
            arr.Add("France");
            arr.Add("Germany");
            arr.Add("Japan");
            arr.Add("Hongkong");
            arr.Add("Singapore");

            Console.WriteLine("Capacity: {0} ", arr.Capacity);
            Console.WriteLine("Count: {0}", arr.Count);

            Console.WriteLine();
            // adding elements using object initializer syntax
            var arlist2 = new ArrayList()
                        {
                            2, "Steve", true, 4.5, null
                        };
            Console.WriteLine("ArrayList 1 Elements");

            for (int i = 0; i < arr.Count; i++)
                Console.WriteLine(arr[i]);

            Console.WriteLine("ArrayList 2 Elements");

            for (int i = 0; i < arlist2.Count; i++)
                Console.WriteLine(arlist2[i]);
    }
    }

