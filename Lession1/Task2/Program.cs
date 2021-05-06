using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Алексей Сазонов
            //2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.

            int h = Class1.Ask_int_user("Введите ваш рост: ");
            double m = Class1.Ask_int_user("Введите ваш вес: ");

            Console.WriteLine("Индекс массы тела = ", m / (h * h));
        }
    }
}
