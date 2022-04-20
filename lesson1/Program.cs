/*
 * Архангельская Полина
 * 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Lastname: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Enter your tall (cm): ");
            string tall = Console.ReadLine();
            Console.WriteLine("Enter your weigh (kg): ");
            string weigh = Console.ReadLine();

            /*
             * а) используя склеивание;
             */
            Console.WriteLine("Name: " + name + " Lastname: " + LastName + " Age: " + age + " y.o. Tall: " + tall + "(cm) Weigh:" + weigh + "(kg)");

            /*
             * б) используя форматированный вывод;
             */
            Console.WriteLine("Name: {0} Lastname: {1} Age: {2} Tall: {3} Weigh: {4}", name, LastName, age, tall, weigh);

            /*
            * в) используя вывод со знаком $
            */
            Console.WriteLine($"Name: {name} Lastname: {LastName} Age: {age} y.o. Tall: {tall}(cm) Weigh: {weigh}(kg)");
            Console.ReadLine();
        }
    }
}
