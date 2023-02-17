//
// Task Armstrong Num 6 lvl kata
//
// A Narcissistic Number (or Armstrong Number) is a positive number which is the sum of its own digits,
// each raised to the power of the number of digits in a given base.
// In this Kata, we will restrict ourselves to decimal (base 10).
//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6kyu_kata_Armstrong_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 153 :    1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
            int number = 407;
            //int number = 153;
            //int number = 2053;
            Console.WriteLine(Narcissistic(number));

            Console.ReadKey();

        }
        static bool Narcissistic(int value)
        {

            int length = Convert.ToString(value).Length;
            double sum = value;
            for (int i = 0; i < length; i++)
            {
                sum -= Math.Pow(value % 10, length);
                value /= 10;
            }
            if(sum == 0) { return true; }
            else { return false; }

        }

    }
}
