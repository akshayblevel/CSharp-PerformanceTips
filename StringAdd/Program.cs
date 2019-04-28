using System;
using System.Diagnostics;
using System.Text;

namespace StringAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Akshay";
            string str1 = " Patel";
            string result = string.Empty;
            Stopwatch s1 = new Stopwatch();
            s1.Start();

            result = $"{str} {str1} is an author.";

            Console.WriteLine("String Interpolation " + s1.ElapsedTicks.ToString());

            s1.Restart();
            result = string.Format("{0},{1} is an author.", str, str1);
            Console.WriteLine("String.Format " + s1.ElapsedTicks.ToString());

            s1.Restart();
            result = string.Concat(str, str1, " is an auther");
            Console.WriteLine("String.Concat " + s1.ElapsedTicks.ToString());

            s1.Restart();
            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            sb.Append(str1);
            sb.Append(" is an auther");
            result = sb.ToString();
            Console.WriteLine("String Builder " + s1.ElapsedTicks.ToString());

            Console.ReadLine();

        }
    }
}
