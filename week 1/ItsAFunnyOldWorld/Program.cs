using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsAFunnyOldWorld
{
    class Program
    {
        static string[] names = new string[5] {"Aled", "Barbara", "Charlie", "Dana", "Eric"};
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine($"Hello {names[rnd.Next(names.Length)]}");
        }
    }
}
