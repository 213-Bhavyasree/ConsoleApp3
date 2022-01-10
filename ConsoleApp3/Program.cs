using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Anil", "Sharma", "Abdullah",
                       "Imran", "Siva", "Naresh",
                       "Suresh", "Suman" };

            //Using LINQ Queries
            UsingLINQExtensions(names);
        }

        private static void UsingLINQExtensions(string[] names)
        {
            IEnumerable<string> query = names
                                        .Where(Anil => Anil.Length == 5)
                                        .OrderBy(Anil=> Anil)
                                        .Select(Anil => Anil.ToUpper());

            //select * from
            foreach (string item in query)
                Console.WriteLine(item);

            Console.Read();
        }
    }
}

