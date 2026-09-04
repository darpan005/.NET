// using System;
// using System.Collections.Generic;
// using System.Collections.Specialized;

// public class Dictionary
// {
//     public static void Main(string[] args)
//     {
//         Dictionary<string, int> students = new Dictionary<string, int>();

//         students.Add("darpan",22);
//         students.Add("parth",19);
//         students.Add("vishal",18);

//         Console.WriteLine(students["darpan"]);
//         Console.WriteLine(students["vishal"]);
//         Console.WriteLine(students["parth"]);

//         Console.WriteLine();
//         Console.WriteLine("-------------------------------------------------");
//         Console.WriteLine();

//         Console.WriteLine("Update value");
//         students["parth"]=20;
//         Console.WriteLine(students["parth"]);

//         Console.WriteLine();
//         Console.WriteLine("-------------------------------------------------");
//         Console.WriteLine();

//         Console.WriteLine("Check if key exist or not");
//         if (students.ContainsKey("darpan"))
//         {
//             Console.WriteLine("Student exist");
//         }

//         Console.WriteLine();
//         Console.WriteLine("-------------------------------------------------");
//         Console.WriteLine();

//         Console.WriteLine("Throw Exception");

//         if(students.TryGetValue("darpan",out int age))
//         {
//             Console.WriteLine(age);
//         }
//         else
//         {
//             Console.WriteLine("darpan does not exist!!!");
//         }

//         Console.WriteLine();
//         Console.WriteLine("-------------------------------------------------");
//         Console.WriteLine();

//         Console.WriteLine("Loop");

//         foreach(var student in students)
//         {
//             Console.WriteLine(student.Key + " : " + student.Value);
//         }


//       }
// }