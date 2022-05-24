/*
 * Архангельская Полина
 * 
 * 1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
 * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6_1
{
    // Описываем делегат. В делегате описывается сигнатура методов, на
    // которые он сможет ссылаться в дальнейшем (хранить в себе)
    
    public delegate double DoOperation (double a, double x);

    internal class Program
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(DoOperation F, double a, double x, double b)
        {
            Console.WriteLine("----- A----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a,x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
     

        static double F1 (double a, double b)           // a*x^2
        {
            return a * (b * b);
        }

        static double F2(double a, double b)           // a*sin(x)
        {
            return a * Math.Sin(b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Таблица функции a*x^2:");
            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new DoOperation(F1), -2, -2, 2);
            
            Console.WriteLine("Таблица функции a*sin(x):");
            Table(new DoOperation(F2), 1, -2, 2);


            Console.ReadKey();
        }
    }
}
