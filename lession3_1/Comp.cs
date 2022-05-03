using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lession3_1
{
    public class Comp
    {
        // По умолчанию элементы приватные, поэтому private можно не писать.
        double im;
       
         double re;
        // Конструктор без параметров.
        public Comp()
        {
            im = 0;
            re = 0;
        }
        // Конструктор, в котором задаем поля.
        // Специально создадим параметр re, совпадающий с именем поля в классе.
        public Comp(double _im, double re)
        {
            // Здесь имена не совпадают, и компилятор легко понимает, что чем является.
            im = _im;
            // Чтобы показать, что к полю нашего класса присваивается параметр,
            // используется ключевое слово this
            // Поле параметр
            this.re = re;
        }
        public Comp Plus(Comp x2)
        {
            Comp x3 = new Comp();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        public Comp Subtraction(Comp x2)
        {
            Comp x3 = new Comp();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        // Свойства - это механизм доступа к данным класса.
        public double Im
        {
            get { return im; }
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) im = value;
            }
        }
        // Специальный метод, который возвращает строковое представление данных.
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}
