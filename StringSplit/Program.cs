using System;
using System.Diagnostics;

namespace StringSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Akshay|Patel";

            Stopwatch s1 = new Stopwatch();
            s1.Start();
            string[] temp1 = str.Split('|');
            Console.WriteLine(s1.ElapsedTicks.ToString());

            Stopwatch s2 = new Stopwatch();
            s2.Start();
            string[] temp = str.Split(new char[] { '|' });
            Console.WriteLine(s2.ElapsedTicks.ToString());

            Console.ReadLine();
        }
    }
}
