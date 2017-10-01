using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConv
{
    class TempConv
    {
        static void Main(string[] args)
        {
            double fahrTemp, celTemp;
            string input;
            Console.WriteLine("Enter a tempereature in degrees C");
            input = Console.ReadLine();
            celTemp = double.Parse(input);
            fahrTemp = (celTemp * 9.0 / 5.0) + 32.0;
            Console.WriteLine("The temperature in Fahrenheit is: " + fahrTemp);
        }
    }
}
