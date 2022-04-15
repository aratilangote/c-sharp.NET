using System;
using System.Collections;


class Program
{
        static void Main(string[] args)
        {
           ArrayList arlist = new ArrayList()
                                {
                                    1,
                                    "Bill",
                                    300,
                                    4.5F
                                };

                    Console.WriteLine("foreach loop");
                    foreach (var item in arlist)
                        Console.Write(item + ", "); //output: 1, Bill, 300, 4.5, 

                    Console.WriteLine("");
                    Console.WriteLine("for loop");

                    for (int i = 0; i < arlist.Count; i++)
                        Console.Write(arlist[i] + ", "); //output: 1, Bill, 300, 4.5
        }
    

}


