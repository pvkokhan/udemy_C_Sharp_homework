using System;

namespace Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, friend! Huw many numbers Fibonacci you whant to see?");
            int numbers = int.Parse(Console.ReadLine());

            int[] fibNumbers = new int[numbers];

            for (int a = 0; a < numbers; a++) {
                fibNumbers[a] = 1; 
            }
            for (int i = 2; i < numbers; i++)
                {
                fibNumbers[i] = fibNumbers[i - 1] + fibNumbers[i - 2];
                }
            foreach (int num in fibNumbers)
            {
                Console.Write($"{num} ");
                
            }


        }

    }
}
