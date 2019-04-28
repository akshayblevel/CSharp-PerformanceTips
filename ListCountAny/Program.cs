using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ListCountAny
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();

            List<string> strs = new List<string>() { "Akshay", "Patel", "Panth", "Patel"};
            watch.Start();
            if (strs.Count() > 0)
            { }

            Console.WriteLine("List.Count()-{0}", watch.Elapsed);

            watch.Restart();
            if (strs.Any())
            { }

            Console.WriteLine("List.Any() - {0}", watch.Elapsed);

            Console.ReadLine();
        }
    }
}
