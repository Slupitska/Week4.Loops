using System;

namespace RandomValut
{
    class Program
    {
        static void Main(string[] args)
        {
            //сгенерировать 5 разных рандомных значений
            
            Random rnd = new Random();

            int myRandom = 0; //декларация значения
            
            for(int i = 0; i < 5; i++)
            {
                myRandom = rnd.Next(1, 11); 
                Console.WriteLine($"My random number: {myRandom}");
            }

            Console.WriteLine(myRandom); //покажет последнее сгенерированное значение
        }
    }
}
