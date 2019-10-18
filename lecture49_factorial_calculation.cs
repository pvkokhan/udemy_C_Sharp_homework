using System;

namespace factorial_calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number to find the factorial");
            int number = int.Parse(Console.ReadLine());

            int answer = 1;
            while (number > 0)
            {
                answer = answer * number;
                number--;
            }

            Console.WriteLine($"Factorial = {answer}");
        }
    }
}
