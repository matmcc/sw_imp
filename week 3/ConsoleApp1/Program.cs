using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            int oldvalue = 0;
            int TARGET = -999;
            double average = 0;
            double i = 0;
            while (value != TARGET)
            {
                Console.WriteLine("Please enter a number to guess the secret value >");
                value = int.Parse(Console.ReadLine());

                i += 1;
                average = (average + value) / i;

                Console.WriteLine("That is not the secret value");
                if (Math.Abs(TARGET - value) < Math.Abs(TARGET - oldvalue))
                {
                    Console.WriteLine("Warmer...");
                }
                else
                {
                    Console.WriteLine("Colder...");
                }
                oldvalue = value;
            }
            Console.WriteLine("You have guessed the secret value: " + value);
            Console.WriteLine("The average of your guesses was: " + average);
            Console.WriteLine("At last this thing is over...");
            Console.ReadKey();
        }
    }
}
