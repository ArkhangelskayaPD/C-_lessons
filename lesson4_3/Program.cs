/*
 * Архангельская Полина
 * 3. а) Дописать класс для работы с одномерным массивом.
 * Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами
 * от начального значения с заданным шагом.
 * Создать свойство Sum, которое возвращает сумму элементов массива,
 * метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива
 * (старый массив, остается без изменений), 
 * метод Multi, умножающий каждый элемент массива на определённое число,
 * свойство MaxCount, возвращающее количество максимальных элементов.
 * б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4_3
{
    internal class Program
    {



            static void Main(string[] args)
            {
            Console.WriteLine("Please enter number of array elements: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter first element of the array: ");
            int start = int.Parse(Console.ReadLine()); ;

            Console.WriteLine("Please enter step: ");
            int step = int.Parse(Console.ReadLine()); 

             ClassArray a = new ClassArray(n, start, step);

             Console.WriteLine(a.ToString());

            Console.WriteLine("Sum of array elements: " + a.Sum);

            a.Inverse = -1;

            Console.WriteLine("Inverse array: " + a.ToString() + "");

            Console.WriteLine("Please enter multiplier: ");
            a.Inverse = 1;

            a.Multi = int.Parse(Console.ReadLine()); ;

            Console.WriteLine("Multi array: " + a.ToString() + "");

            Console.WriteLine("Max number in array: " + a.MaxNumber + "");



            string FileNameIN = "..\\..\\myArray.txt";
            ClassArray myArray = new ClassArray(FileNameIN);
            Console.WriteLine("Load array from file: " + FileNameIN);
            Console.WriteLine(myArray.ToString());

            


            Console.ReadLine();

        }
        }





    }

