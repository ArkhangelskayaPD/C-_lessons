/*
 * Архангельская Полина
 * 
 * 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2_4
{
    internal class Program
    {
        static bool CheckLogPass(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            int attempt = 0;

            do
            {
                while (attempt > 3) ;
                Console.Write("Enter login: ");
                string login = Console.ReadLine();
                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (CheckLogPass(login, password))
                {
                    Console.WriteLine();
                    attempt = 0;
                    break;
                }
                else
                {

                    Console.WriteLine("Wrong login or password");
                    ++attempt;

                }
            }
            while (attempt < 3);

            if (attempt < 3)

                Console.WriteLine("Welcome!");


            else
                Console.ReadKey();

            Console.ReadKey();
        }
    }
}
