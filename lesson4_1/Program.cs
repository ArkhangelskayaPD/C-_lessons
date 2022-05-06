/*
 * Архангельская Полина
 * 1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
 * В данной задаче под парой подразумевается два подряд идущих элемента массива.
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4_1
{ 
    class MyArray
{
    int[] a;


    public override string ToString()
    {
        string s = "";
        foreach (int v in a)
            s = s + v + " ";
        return s;
    }
}

        
    internal class Program
    {
        static int NumberOfPairs(int[] arr, int n)
        {
            int countOfPairs = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] % 3 == 0 || arr[i + 1] % 3 == 0)
                {
                    countOfPairs++;
                }
            }
            return countOfPairs;
        }
        static void Main(string[] args)
        {
            int[] a;
            int n = 20;
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(-10000, 10000);
                Console.Write(a[i] + " ");
            }

            int result = NumberOfPairs(a, n);
            Console.WriteLine("\n Количество пар элементов массива, в которых только одно число делится на 3: " + result);


            Console.ReadLine();
        }
    }
}

