// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Student
// {
//     public string name {get; set;}
//     public int mark {get; set;}
// }

// public class First
// {
//     public static void Main(string[] args)
//     {
//         List<Student> students = new List<Student>
//         {
//             new Student {name="darpan", mark=99},
//             new Student {name="parth", mark=85},
//             new Student {name="vishal", mark=78},
//             new Student {name="jay", mark=60}
//         };

//         Student student = students.First(s => s.mark > 80);

//         Console.WriteLine(student.name);
//     }
// }