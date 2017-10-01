using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortEg
{
    class BubbleSortEg
    {
        static void Main(string[] args)
        {
            int[] numbers = {15, 68, 4, 19, 99, 52, 53, 36, 74, 1, 85};

            foreach (int i in numbers)
            {
                Console.Write("{0,2}  ", i);
            }

            //Bubblesort...
            for (int i = 0; i < numbers.Length; i++)    // iterate thru array
            {
                for (int j = 0; j < numbers.Length - 1; j++)    // for each element...
                {
                    if (numbers[j] > numbers[j + 1])    // compare each element with neighbour, if greater...
                    {
                        int tempval = numbers[j];
                        numbers[j] = numbers[j + 1];    // ... swap elements
                        numbers[j + 1] = tempval;
                    }
                }
            }

            Console.WriteLine("");
            foreach (int i in numbers)
            {
                Console.Write("{0,2}  ", i);
            }

        }
    }
}
