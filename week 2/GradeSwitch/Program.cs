using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a grade percentage (this must be a number from 0 to 100): ");
            int grade = int.Parse(Console.ReadLine());

            //string output = Grade(grade);
            string output = GradeSwitch(grade);
            Console.WriteLine("The grade percentage " + grade + " gives a grade of " + output);
            Console.ReadKey();
        }

        static string GradeSwitch(int grade)
        {
            int gradeswitch = grade / 10; 
            // no input checking in caller means grade > 100 || grade < 0 could be passed 

            switch (gradeswitch)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return "F";
                case 4:
                    return "D";
                case 5:
                    return "C";
                case 6:
                    return "B";
                case 7:
                case 8:
                case 9:
                case 10:
                    return "A";
                default:
                    Console.WriteLine("Invalid input in switch method has reached default case");
                    return "";
            }
        }

        static string Grade(int grade)
        {
            if (grade >= 0 && grade <= 39)
            {
                return "F";
            }
            if (grade >= 40 && grade <= 49)
            {
                return "D";
            }
            if (grade >= 50 && grade <= 59)
            {
                return "C";
            }
            if (grade >= 60 && grade <= 69)
            {
                return "B";
            }
            if (grade >= 70 && grade <= 100)
            {
                return "A";
            }
            else
            {
                return "invalid input";// can this ever be called?
            }
        }
    }
}
