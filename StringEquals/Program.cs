using System;

namespace StringEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = null;
                if ("Akshay".Equals(str))
                //if (str.Equals("Akshay"))
                {
                    Console.WriteLine("if");
                }
                else
                {
                    Console.WriteLine("else");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
