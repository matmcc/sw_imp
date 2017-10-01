using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 A carpenter installs window units and wants a program which will calculate
the amounts of wood and glass that needs to be purchased. He/she wants
to just enter the dimensions of the window (in meters) and then get a
display of the amount of wood and glass required. Whilst glass is sold by
the square meter, the wood supplier sells by the foot, so the amount of
wood required must be given in feet and inches. Furthermore, the width of
the window must be between 0.5 and 3.5m inclusive and the height
constrained between 0.5 and 2.0 meters inclusive. Note that 1 meter =
3.25 feet and there are 12 inches in a foot
*/

//Pseudocode:
//      Set up constant variables for bounds and conversion factor
// Input window dimension in metres
//      Check dimensions against bounds
// Calculate window area and circumference
// Convert circumference from metres to feet and inches
// ... note above step will require conversion and rounding up for inches
// Output area/glass in metres and circumference/wood in feet and inches

// More ideas...
// simple class methods could be refactored as expression bodied functions
// using double.Parse(Console.Readline()) risks exceptions from non-double input e.g. strings like "two-and-a-half"
// no tests included to demonstrate working, errors or edge cases

namespace WindowMaker
{
    class WindowMaker
    {
        // Set up variables for bounds and conversion factor
        private static double WIDTH_LOW = 0.5;
        private static double WIDTH_HIGH = 3.5;
        private static double HEIGHT_LOW = 0.5;
        private static double HEIGHT_HIGH = 2.0;
        private static double CONVERSION_FACTOR = 3.25;
        
        // Calculate window area and circumference
        private static double Area(double width, double height)
        {
            double area;
            area = width * height;
            return area;
        }

        // Convert circumference from metres to feet
        private static double ConvertMetresFeet(double metresToConvert)
        {
            double feet = metresToConvert * CONVERSION_FACTOR;
            return feet;
        }

        static void Main(string[] args)
        {
            // Input window dimension in metres
            Console.WriteLine("Please enter the window width in metres");
            Console.WriteLine($"(Width must be between {WIDTH_LOW} and {WIDTH_HIGH}) ...");
            // Check dimensions against bounds
            double width = double.Parse(Console.ReadLine());
            while (width < WIDTH_LOW || width > WIDTH_HIGH)
            {
                Console.WriteLine("Please try again...");
                Console.WriteLine($"(Width must be between {WIDTH_LOW} and {WIDTH_HIGH}) ...");
                width = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please enter the window height in metres");
            Console.WriteLine($"(Height must be between {HEIGHT_LOW} and {HEIGHT_HIGH}) ...");
            double height = double.Parse(Console.ReadLine());
            while (height < HEIGHT_LOW || height > HEIGHT_HIGH)
            {
                Console.WriteLine("Please try again...");
                Console.WriteLine($"(Height must be between {HEIGHT_LOW} and {HEIGHT_HIGH} >");
                height = double.Parse(Console.ReadLine());
            }

            // Output area/glass in metres and circumference/wood in feet
            Console.WriteLine($"Area of glass needed: {Area(width, height)} metres squared");
            double tempFeet = ConvertMetresFeet(2 * (width + height));
            int feet = (int)tempFeet;
            double tempInches = (tempFeet - feet) * 12;
            int inches = (int)Math.Ceiling(tempInches);
            Console.WriteLine($"Length of wood needed, rounded up to nearest inch: {feet}\' {inches}\"");
        }
    }
}
