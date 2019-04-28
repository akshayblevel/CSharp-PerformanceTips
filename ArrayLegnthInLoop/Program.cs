using System;
using System.Diagnostics;

namespace ArrayLegnthInLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();
            string[] names = { "Akshay", "Patel", "Panth" };

            for (int i = 0; i < names.Length; i++)
            {
            }

            Console.WriteLine("Name.Length Direct-{0}", watch.Elapsed);


            watch.Restart();
            string[] names1 = { "Akshay", "Patel", "Panth" };
            int k = names1.Length;
            for (int j = 0; j < k; j++)
            {
            }
            Console.WriteLine("Name.Length Parameter-{0}", watch.Elapsed);

            Console.ReadLine();
        }
    }
}
