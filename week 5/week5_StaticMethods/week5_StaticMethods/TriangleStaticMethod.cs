using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_StaticMethods
{
    class TriangleStaticMethod
    {
        // why use static class methods? Is this less clear than all grouped together in Main()
        static double angleinradians(double degrees) => degrees / 57.3;
        static double tangentAngle(double angle) => Math.Tan(angle);
        static double hypotenuseLength(double adjacentLength, double oppositeLength) => 
            Math.Sqrt(Math.Pow(adjacentLength, 2) + Math.Pow(oppositeLength, 2));

        static void Main()
        {
            Console.WriteLine("This program calculates the properties of a right-angled triangle");
            Console.WriteLine("Please enter one of the acute angles in degrees (0 > angle < 90)");
            // TODO: check for errors here
            double inputAngle = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the length of the adjacent side in cm's");
            double inputLength = double.Parse(Console.ReadLine());

            double oppositeLength = tangentAngle(angleinradians(inputAngle)) * inputLength;
            double hypLen = hypotenuseLength(inputLength, oppositeLength);

            Console.WriteLine($"Right-angle triangle with angle {inputAngle} degrees" +
                $"\nadjacent side: {inputLength:0.00}\nopposite side: {oppositeLength:0.00}\nhypotenuse side: {hypLen:0.00}");

        }
    }
}
