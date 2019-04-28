using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ListCount__Count
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strs = new List<string>() { "Akshay", "Patel", "Panth", "Patel" };

            Stopwatch watch = new Stopwatch();
            watch.Start();
            int count = strs.Count();

            Console.WriteLine("Count()-{0}", watch.Elapsed);
            watch.Restart();
            int count1 = strs.Count;

            Console.WriteLine("Count - {0}", watch.Elapsed);

            Console.ReadLine();
        }
    }
}
