/*
 * Архангельская Полина
 * 1. Написать метод, возвращающий минимальное из трёх чисел.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    internal class Program
    {
        static int MinNumber (int a, int b, int c)
        {
            int min = a;
            if (b<min)
                min = b;
            if (c < min)
                min = c;
            return min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Min number is: "+ MinNumber(a, b, c));
            Console.ReadLine();
        }
    }
}
