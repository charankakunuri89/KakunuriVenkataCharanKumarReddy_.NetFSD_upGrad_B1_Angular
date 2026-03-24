using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAssignment.Level1.Assignment3
{
    internal class StringOperations
    {
        public static void Main(string[] args)
        {
            List<String> names = new List<string> { "Ravi", "Kiran", "Amit", "Raj", "Anil" };
            //tasks
            //1.Get names starting with 'A'
            var startingNamesWith_A = names.Where(s => s.StartsWith('A')).ToList();

            foreach( var name in startingNamesWith_A)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            //2.sort names alphabetically
            var sortNamesAlphabetically = names.OrderBy(s => s).ToList();

            foreach(var name in sortNamesAlphabetically)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            //3.convert all names to uppercase
            var uppercaseNames = names.Select(s => s.ToUpper()).ToList();

            foreach(var s in uppercaseNames)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            //4.names whose length > 4

            var namesLengthGreaterThan4 = names.Where(s => s.Length > 4).ToList();

            foreach(var name in namesLengthGreaterThan4)
            {
                Console.WriteLine(name);
            }
        }
    }
}
