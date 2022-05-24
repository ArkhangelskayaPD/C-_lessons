/*
 * Архангельская Полина
 * 
 * 3. Переделать программу Пример использования коллекций для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;

в) отсортировать список по возрасту студента;
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lesson6_3
{
    public class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        // Создаем конструктор
        public Student(string firstName, string lastName, string university,
        string faculty, string department, int age, int course,  int group, string city)
        {
            
            this.firstName = firstName;
            this.lastName = lastName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.group = group;
            this.city = city;
        }
    }

        internal class Program
    {
        static int MyDelegat(Student str1, Student str2) // Создаем метод для сравнения для экземпляров
        {
            return String.Compare(str1.age.ToString(), str2.age.ToString()); //  Сравниваем две строки

        }
        static void Main(string[] args)
        {
            int bakalavr = 0;
            int magistr = 0;
            int kurs5 = 0;
            int kurs6 = 0;
            List<Student> list = new List<Student>();
            // Создаем список студентов
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new
                    Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7])
                    , s[8]));
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (int.Parse(s[6]) < 5) bakalavr++;
                    else
                        if (int.Parse(s[6]) == 5)               //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;

                    {
                        kurs5++;
                        magistr++;
                    }
                    else
                    if (int.Parse(s[6]) == 6)
                    {
                        kurs6++;
                        magistr++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                // Выход из Main
            if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            list.Sort(new Comparison<Student>(MyDelegat));
            Console.WriteLine("Всего студентов:" + list.Count);

            Console.WriteLine("Студентов 5 курса:{0}", kurs5);
            Console.WriteLine("Студентов 6 курса:{0}", kurs6);

            Console.WriteLine("Магистров:{0}", magistr);           
            Console.WriteLine("Бакалавров:{0}", bakalavr);

            list.Sort(new Comparison<Student>(MyDelegat));                         //в) отсортировать список по возрасту студента;
            Console.WriteLine("Отсортируем студентов по возрасту: ");
            foreach (var v in list) Console.WriteLine($"{v.firstName} {v.age}");

            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();

        }
    }
}
