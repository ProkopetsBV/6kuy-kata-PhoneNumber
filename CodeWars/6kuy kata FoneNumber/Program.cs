//
// Task Phone Number 6 lvl kata
//
// Write a function that accepts an array of 10 integers (between 0 and 9),
// that returns a string of those numbers in the form of a phone number.
//

using System;

namespace _6kuy_kata_PhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Any 10 element array (values - between 0 and 9)
            int[] nums = new int[10]{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //CreatePhoneNumber(nums);
            Console.WriteLine(CreatePhoneNumber2(nums));

            Console.Read();
        }

        /// <summary>
        /// solution 1 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        static string CreatePhoneNumber(int[] numbers)
        {
           
            // phone style : "(096) 123-4567"
            string phone_num = "(";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 3) { phone_num += ") "; }
                if (i == 6) { phone_num += "-"; }
                phone_num += numbers[i];
            }
            Console.WriteLine(phone_num);
            return phone_num;
        }

        /// <summary>
        /// solution 2 (beter) 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        static string CreatePhoneNumber2 (int[] numbers)
        {
            // phone style : "(096) 123-4567"
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }
        
    }
}
