// using System;
// using System.Collections.Generic;

// public class Queue
// {
//     public static void Main(string[] args)
//     {
//         Queue<string> customers = new Queue<string>();

//         Console.WriteLine("Enqueue is for add ");
//         customers.Enqueue("darpan");
//         customers.Enqueue("parth");
//         customers.Enqueue("vishal");

//         foreach(string name in customers)
//         {
//             Console.WriteLine(name);
//         }

//         Console.WriteLine();

//         Console.WriteLine("Peek for look and forst position");

//         Console.WriteLine(customers.Peek());

//         Console.WriteLine();

//         Console.WriteLine("Dequeue is for look at first postion and remove that");

//         Console.WriteLine(customers.Dequeue());

//         Console.WriteLine("Remaining : " + customers.Count);


//     }
// }