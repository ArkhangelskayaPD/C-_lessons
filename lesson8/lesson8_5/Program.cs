/*
 * Архангельская Полина
 * 
 * Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace lesson8_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            string[] readLines = File.ReadAllLines("..\\..\\students.csv");
            string[] headers = { "Name", "Surname", "University", "Faculty", "Department", "Age", "Course", "Group", "City" };


            var xml = new XElement("Students", readLines.Select(line => new XElement("StudentInfo", line.Split(';')
          .Select((column, index) => new XElement(headers[index], column))))); //подсказку взяла туть: https://stackoverflow.com/questions/3069661/convert-csv-file-to-xml

            xml.Save("..\\..\\students_new.xml");

            Console.WriteLine("Преобразованный из CSV в XML-файл с информацией о студентах находится в файле students_new.xml");

            Console.ReadLine();
        }
    }
}
