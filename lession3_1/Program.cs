/*
 * Архангельская Полина
 * 1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
    б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
    в) Добавить диалог с использованием switch демонстрирующий работу класса.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lession3_1;

struct Complex
{
    public double im;
    public double re;
    // в C# в структурах могут храниться также действия над данными
    public Complex Plus(Complex x)
    {
        Complex y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }
    // Пример произведения двух комплексных чисел
    public Complex Multi(Complex x)
    {
        Complex y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }
    // Метод вычитания комплексных чисел 
    public Complex Subtraction(Complex x)
    {
        Complex y;
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }

    public string ToString()
    {
        return re + "+" + im + "i";
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Enter 'struct' or 'class' :");
        string name = Console.ReadLine();
        switch (name)
        {
            case "struct":
                Complex complex1;
                complex1.re = 1;
                complex1.im = 1;

                Complex complex2;
                complex2.re = 2;
                complex2.im = 2;


                Complex result = complex1.Plus(complex2);
                Console.WriteLine("Add result: " + result.ToString());
                result = complex1.Multi(complex2);
                Console.WriteLine("Multi result: " + result.ToString());
                result = complex1.Subtraction(complex2);
                Console.WriteLine("Subtraction result: " + result.ToString());

                break;
            case "class":
                             
                // Описали ссылку на объект.
                Comp comp1;
                // Создали объект и сохранили ссылку на него в complex1.
                comp1 = new Comp(1, 1);
                // Описали объект и создали его.
                Comp comp2 = new Comp(2, 2);

                // Создали ссылку на объект.
                Comp res;
                // Так как в методе Plus создается новый объект,
                // в result сохраняем ссылку на вновь созданный объект.
                res = comp1.Plus(comp2);
                Console.WriteLine("Add result: " + res.ToString());
                res = comp1.Subtraction(comp2);
                Console.WriteLine("Subtraction result: " + res.ToString());
                break;
        }   


        Console.ReadLine();
    }
   

}
  
    

