/* 
	This program contains several compile time and run time errors.
	See if you can correct them.
*/
using System;

namespace Problems
{
    class Problems
    {
        static void Main(string[] args)
        {
            double result1; // Result of a division expression
            int result2, input1, answer, divisor; // Some integer variables
            string input; // String variable used for input

            // Divide a floating point number by another
            result1 = 7.0f / 22.0f;
            Console.WriteLine("The number 7 divided by 22 is " + result1);

            Console.WriteLine("Input a number: ");
            input = Console.ReadLine();
            input1 = int.Parse(input);

            // Add two to an input number then double the sum and print to screen
            result2 = (input1 + 2) * 2;
            Console.WriteLine("Two plus " + input1 + ", doubled is " + result2);

            // Two plus two equals ?
            answer = 2 + 2;

            Console.WriteLine("Two plus two equals " + answer);

            // Division
            Console.WriteLine("Enter a number 1 to 9: "); // Changed 0 to 1 to prevent divide by zero error
            input = Console.ReadLine();
            //TODO: Test 1 >= input <= 9
            divisor = int.Parse(input);
            Console.WriteLine("1 / " + divisor + " in decimal is " + (1.0f / divisor));
            //TODO: if dividing by 1, answer written as int not float, is this a problem?
            Console.ReadKey();
        }
    }
}