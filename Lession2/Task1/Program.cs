using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace Task1
{
    class Program
    {
        //Алексей Сазонов
        //1. Написать метод, возвращающий минимальное из трёх чисел.

        static void Main(string[] args)
        {
            Console.Write("Введите первое любое положительное натуральное число = "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе любое положительное натуральное число = "); int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье положительное натуральное число = "); int c = Convert.ToInt32(Console.ReadLine());

            int min = Class2.MinNumber(a, b, c);

            Console.WriteLine($"Минимальное из трёх чисел: {min}"); 
        }
    }
}
