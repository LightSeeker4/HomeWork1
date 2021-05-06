
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Алексей Сазонов
            //3.
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

            //a
            double x1 = Class1.Ask_int_user("Введите координату х1: ");
            double y1 = Class1.Ask_int_user("Введите координату y1: ");
            double x2 = Class1.Ask_int_user("Введите координату х2: ");
            double y2 = Class1.Ask_int_user("Введите координату y2: ");
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));


            Console.WriteLine($"Расстояние между точками = {r:f2}");

            //b
            double a1 = Class1.Ask_int_user("Введите координату х1: ");
            double b1 = Class1.Ask_int_user("Введите координату y1: ");
            double a2 = Class1.Ask_int_user("Введите координату х2: ");
            double b2 = Class1.Ask_int_user("Введите координату y2: ");

            double d = Class1.Distance(a1, b1, a2, b2);
            Console.WriteLine($"Расстояние между точками = {d:f2}");
        }
    }
}