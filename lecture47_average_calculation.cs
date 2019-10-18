using System;

namespace average_calculation
{
    class Program
    {


        static void Main(string[] args)
        {
            /*
              ДЗ "Вычисление среднего"
              Запросить у пользователя не более 10 целых положительных чисел, кратных трём. 
              Пользователь может прекратить приём чисел, введя 0.
              После прекращения приёма целых чисел (это происходит в случае если было введено 10 чисел,либо пользователь ввёл 0,
              чтобы не вводить все 10) подсчитать среднее значение введённых целых чисел и вывести на консоль.
             */
            int[] numbers = new int[10];
            
            for (int i=0; i<10; i++)
            {
                int nextNumber = 10;
                do
                {
                    Console.WriteLine($"insert {i} number");
                    nextNumber = int.Parse(Console.ReadLine());
                    
                }

                while (nextNumber % 3 != 0 && nextNumber != 0);
               
                if (nextNumber == 0)
                {
                    break;

                }

                numbers[i] = nextNumber;
                if (nextNumber == 0)
                {
                    break;
                }

            }

            int sum = 0;
            int quantity = 0;
            foreach (int num in numbers)
            {
                sum += num;
                if (num != 0)
                {
                    quantity++;
                }

            }
            Console.WriteLine($"Average - {(double)sum/quantity}");

        }
    }
}
