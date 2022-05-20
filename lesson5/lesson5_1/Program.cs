/*
 * Архангельская Полина
 * 1. Создать программу, которая будет проверять корректность ввода логина.
 * Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5_1
{
    internal class Program
    {
     
        static bool CheckLog(string login)
        {
            int l = login.Length;
            if (l >= 2 && l <= 10)                 //Check length
            {
                bool check = true;
                char letter = login[0];
                if ((Char.IsDigit(letter)))       //Check first symbol    
                    return false;
                for (int i = 1; i < l; i++)
                {
                    letter = login[i];
                    if (!(Char.IsDigit(letter) || (login[i] >= 'A' && login[i] <= 'Z') || (login[i] >= 'a' && login[i] <= 'z'))) //|| CheckLatinLetter(letter)))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter login: ");

            string log = Console.ReadLine();

            if (CheckLog(log))
            {
                Console.WriteLine("Login is correct!");
                Console.ReadKey();
            }
            else
            {
               
                Console.WriteLine("Invalid login!");
                Console.ReadKey();
            }
            

        }
    }
}
