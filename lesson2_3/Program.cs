/*
 * Архангельская Полина
 * 
 * 3. С клавиатуры вводятся числа, пока не будет введен 0. 
 * Подсчитать сумму всех нечетных положительных чисел
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2_3
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            int n = 0;
            int sum = 0;
            
                do
                {
                    Console.Write("Enter number: ");
                     n = int.Parse(Console.ReadLine());
                    if (n > 0 && n % 2 == 1)
                        sum += n;

                } while (n != 0);

                Console.WriteLine("Sum of odd numbers : " + sum);     


            Console.ReadKey();
        }
    }
}
