using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace Task2
{
    class Program
    {
        //Алексей Сазонов
        //2. Написать метод подсчета количества цифр числа.

        static void Main(string[] args)
        {
            Console.Write("Введите любое натуральное число = "); int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количества цифр числа = {Class2.CountNumber(a)}");
        }
    }
}
