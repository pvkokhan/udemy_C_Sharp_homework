using System;

namespace three_attempts_to_login
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfAttempt = 3;
            string login = "johnsilver";
            string password = "qwerty";

            while (numberOfAttempt > 0) {
                Console.WriteLine("input login:");
                string inputedLigon = Console.ReadLine();

                Console.WriteLine("input password:");
                string inputedPassword = Console.ReadLine();

                if (inputedLigon == login && inputedPassword == password)
                {
                    Console.WriteLine("Enter the System");
                    break;
                }else
                {
                    numberOfAttempt--;
                    Console.WriteLine($"Incorrect login/password! you have {numberOfAttempt} input attempt");
                }
                if (numberOfAttempt == 0)
                {
                    Console.WriteLine("The number of available tries have been exceeded");
                }
            }

        }
    }
}
