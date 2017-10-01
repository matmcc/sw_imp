using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCircle
{
    class SimpleCircle
    {
        static void Main(string[] args)
        {
            float PI = 3.14149f;
            string input;
            float radius;
            Console.WriteLine("Please enter the radius of the circle: ");
            input = Console.ReadLine();
            radius = float.Parse(input);

            float diameter = radius * 2.0f;
            float area = 2.0f * PI * radius;
            Console.WriteLine("The diameter of the cirle is: " + diameter);
            Console.WriteLine("The area of the cirlce is: " + area);
            Console.ReadKey();
        }
    }
}
