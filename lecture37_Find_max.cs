using System;

namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Take 1st integer");
            int firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Take 2nd integer");
            int secondInt = int.Parse(Console.ReadLine());

            if (firstInt != secondInt)
            {
                Console.WriteLine(firstInt > secondInt ? firstInt : secondInt);
            }
            else
            {
                Console.WriteLine("Numbers are equal");
            }

        }
    }
}
