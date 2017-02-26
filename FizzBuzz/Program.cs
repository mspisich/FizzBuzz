using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Track number of fizzes, buzzes, and fizzbuzzes
            int fizz = 0;
            int buzz = 0;
            int fizzBuzz = 0;

            // Cycle numbers from 1-20. If divisible by 3 and 5 print FizzBuzz, only 3 print Fizz, only 5 print Buzz. Otherwise just print the number.
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0  &&  i % 5 == 0)
                {
                    fizzBuzz++;
                    Console.WriteLine("FizzBuzz!");
                }
                else if (i % 3 == 0)
                {
                    fizz++;
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    buzz++;
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // Display total fizzes, buzzes, and fizzbuzzes.
            Console.WriteLine("There are " + fizz + " fizzes, " + buzz + " buzzes, and " + fizzBuzz + " FizzBuzzes.");
            Console.ReadLine();
        }
    }
}
