/*
 * Архангельская Полина
 * 3. Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
Например: badc являются перестановкой abcd.
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5_2
{
    internal class Program
    {
         static bool CheckPermutation(string str1, string str2)
        {
            return str1.Select(Char.ToLower).OrderBy(x => x).SequenceEqual(str2.Select(Char.ToLower).OrderBy(x => x));
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Please, enter the first string:");
                string string1 = Console.ReadLine();
            Console.WriteLine("Please, enter the second string:");
            string string2 = Console.ReadLine();
                if (CheckPermutation(string1, string2) == true)
                    Console.WriteLine("strings are permutations of each other");
                else
                    Console.WriteLine("strings are not permutations of each other");

                Console.ReadKey();
            }
    }
}
