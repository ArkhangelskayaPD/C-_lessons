/*
 * Архангельская Полина
 * 2. Написать метод подсчета количества цифр числа.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2_2
{
    internal class Program
    {
        static long CountNumbers (long a)
        {
            long c = 0;
           
                while (a > 0)
                {
                    c++;
                    a = a / 10;
                }
            
                return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            long a = long.Parse(Console.ReadLine());
            Console.WriteLine("Number of digits in a number: " + CountNumbers(a));
            Console.ReadLine();
        }
    }
}
