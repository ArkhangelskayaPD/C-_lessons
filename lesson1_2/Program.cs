/*
 * Архангельская Полина
 * 2. Ввести вес и рост человека.
 * Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
 * где m — масса тела в килограммах, h — рост в метрах.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter m: ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter h: ");
            double h = double.Parse(Console.ReadLine());
            double I = m / (h * h);
            Console.WriteLine($"BMI (I) = {I}");

            Console.ReadLine();
        }
    }
}
