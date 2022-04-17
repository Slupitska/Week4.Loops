using System;

namespace LoopSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //программа генерирует 10 случайных чисел (от 1 до 10), выводит их значение на экран
            //программа подсчитывает сумму этих чисел и выводит сумму на экран

                       
            Random rnd = new Random();
            int myRandom = 0;
            int sum = 0;
            
            for (int n = 1; n < 11; n++)
            {
                myRandom = rnd.Next(1, 11);
                Console.WriteLine($"{n}. Random number: {myRandom}");
                sum += myRandom;                
            }

            Console.WriteLine($"Total: {sum}");

            //sum += rnd.Next(); sum = sum + rnd.Next(); то же самое
        }



    }
}
