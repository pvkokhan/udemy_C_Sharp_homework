using System;

namespace homeworks
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("Tell length of first side of treangle.");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Tell length of second side of treangle.");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Tell length of third side of treangle.");
            double c = double.Parse(Console.ReadLine());

            double p = 0.5 * (a + b + c);
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            string res = string.Format("{0:f}", s);
            

            Console.WriteLine($"Area of treangle is {res}");

        }
       
}
