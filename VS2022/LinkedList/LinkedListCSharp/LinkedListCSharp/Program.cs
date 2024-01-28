using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Ok so C# has a builtin linked list class.
            // We just need to creat a new linked list 
            // object instance.
            //
            LinkedList<string> linked = new LinkedList<string>();
            //
            // AddLast method will add elements at the end.
            // AddFirst method will add element at the start.
            //
            linked.AddLast("bird");
            linked.AddLast("fish");
            linked.AddFirst("amphibians");
            linked.AddLast("mammals");
            linked.AddLast("reptile");
            //
            // Loop through the linked list with the foreach-loop.
            //
            foreach (var group in linked)
            {
                Console.WriteLine(group);
            }

            Console.ReadLine();

        }
    }
}
