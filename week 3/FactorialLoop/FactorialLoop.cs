using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialLoop
{
    class FactorialLoop
    {
        static void Main(string[] args)
        {
            int ret = 1;
            Console.WriteLine("Enter a number to return the factorial of that number >");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n+1; i++)
            {
                ret *= i;
            }
            Console.WriteLine("Factorial of " + n + " is " + ret);
        }
    }
}
