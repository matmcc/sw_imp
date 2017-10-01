using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizedSquare
{
    class SizedSquare
    {
        static void Main(string[] args)
        {
            string LINECHAR = "*";
            string WHITESPACE = " ";
            //TODO: Could allow LINECHAR and WHITESPACE customisation

            Console.WriteLine("Please input a number for Square size (numerical characters only please)");
            int SquareSize = int.Parse(Console.ReadLine());

            //TODO: Error checking
            string TopBottomLine = LINECHAR;
            for (int i = 0; i < SquareSize; i++)
            {
                TopBottomLine += LINECHAR;
            };
            string OtherLine = WHITESPACE;
            for (int i = 0; i < (SquareSize - 2); i++)
            {
                OtherLine += WHITESPACE;
            }
            OtherLine = LINECHAR + OtherLine + LINECHAR;

            Console.WriteLine(TopBottomLine);
            for (int i = 2; i < SquareSize; i++)
            {
                Console.WriteLine(OtherLine);
            }
            Console.WriteLine(TopBottomLine);

            Console.ReadKey();
        }
    }
}
