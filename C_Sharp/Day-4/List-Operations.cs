// using System;
// using System.Collections.Generic;

// public class List
// {
//     public static void Main(string[] args)
//     {
//         List<string> names = new List<string>
//         {
//             "Darpan",
//             "Parth",
//             "Virat"
//         };

//         Console.WriteLine("Name before adding External Names...");
//         foreach(string name in names)
//         {
//             Console.WriteLine(name);
//         }
//         Console.WriteLine($"Total Names are {names.Count}");  
//         Console.WriteLine("------------------------------------------------------");
//         Console.WriteLine();
//         Console.WriteLine("After adding External Names...");
//         names.Add("Vishal");
//         names.Add("Me");

//         foreach(string name in names)
//         {
//             Console.WriteLine(name);
//         }
//         Console.WriteLine($"Total Names are {names.Count}");  
//         Console.WriteLine("------------------------------------------------------");
//         Console.WriteLine();

//         Console.WriteLine("After removing name at 2nd position...");
//         names.RemoveAt(2);
//         foreach(string name in names)
//         {
//             Console.WriteLine(name);
//         }
//         Console.WriteLine($"Total Names are {names.Count}");  

//         Console.WriteLine("------------------------------------------------------");
//         Console.WriteLine();
//         Console.WriteLine($"Total Names are {names.Count}");    


//     }
// }