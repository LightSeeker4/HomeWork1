using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace Task5
{
    class Program
    {
        //Алексей Сазонов
        //а) Написать программу, которая запрашивает массу и рост человека,
        // вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

        static void Main(string[] args)
        {
            //a,б
            double h = Class2.Ask_user("Введите ваш рост: ");
            double m = Class2.Ask_user("Введите ваш вес: ");
            double imt = m / (h * h);

            if (imt > 18.5 && imt < 24.9) {Console.WriteLine("Поздравляем! Ваш вес находится в пределах нормы!"); }
            else
            {          
                if (imt < 18.5)
                {
                    string action = "поправиться";
                    double n = 18.5 * ((h * h) - m);
                    Console.WriteLine($"Индекс массы тела = {imt}\n Вам нужно {action} на {n:f2} кг, чтобы привести вес в норму");
                }
                else
                {
                    if (imt > 24.9)
                    {
                        string action = "похудеть";
                        double n = 24.9 * (h * h);
                        Console.WriteLine($"Индекс массы тела = {imt}\n Вам нужно {action} на {n:f2} кг, чтобы привести вес в норму");
                    }

                }

            }
        }
    }
}

