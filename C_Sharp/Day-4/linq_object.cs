using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string name{get; set;}
    public int age{get; set;}
}

public class Single
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student {name = "darpan", age=22},
            new Student {name = "parth", age=19},
            new Student {name = "vishal", age=21},
            new Student {name = "jay", age=18},
            new Student {name = "jignesh", age=25}
        };

        //LINQ
        var result = students
            .Where(s => s.age > 20)
            .OrderBy(s => s.name)
            .Select(s => s.name);

            foreach(string name in result)
        {
            Console.WriteLine(name);            
        }

            
        
    }
}