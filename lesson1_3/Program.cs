/*
 * Архангельская Полина
 * 3. а) Написать программу,
 * которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
 * по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
 * Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            string result = string.Format("{0:f2}", r);

            Console.WriteLine($"distance between points (r) : {result}");
            Console.ReadLine();
        }
    }
}
