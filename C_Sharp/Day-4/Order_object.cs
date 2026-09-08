// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Student
// {
//     public string name{get; set;}
//     public int age{get; set;}
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         List<Student> students = new List<Student>
//         {
//             new Student {name="darpan",age=22},
//             new Student {name="parth",age=19},
//             new Student {name="vishal",age=20}
//         };

//         var result = students.OrderBy(s =>s.age);

//         foreach(Student student in result)
//         {
//             Console.WriteLine($"{student.name} : {student.age}");
//         }
        
//     }
// }