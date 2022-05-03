/*
 * Архангельская Полина
 * а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
 * Требуется подсчитать сумму всех нечетных положительных чисел. 
 * Сами числа и сумму вывести на экран, используя tryParse;
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3_2
{
    internal class Program
    {
     
            static void Main(string[] args)
        {
 

          int n = 0;
          int sum = 0;


            do
            {
                Console.Write("Enter one number: ");
                int.TryParse(Console.ReadLine(), out n);
                    if (n > 0 && n % 2 == 1)
                        sum += n;
                    else if (n == 0)
                        break;
            } while (n != 0) ;


          Console.WriteLine("Sum of odd numbers : " + sum);
          Console.ReadLine();
       
    }
}
}
