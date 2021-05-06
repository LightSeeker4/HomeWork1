using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace Task7
{
    class Program
    {
        //Алексей Сазонов
        //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        static void Main(string[] args)
        {
            //a
            Console.Write("Программа выводит на экран числа от a до b\nВведите первое натуральное число = "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе натуральное число = "); int b = Convert.ToInt32(Console.ReadLine());
            Class2.RecursiveNumber(a, b);
            
            //б
            //Console.Write("Программа выводит на экран сумму чисел от x до y\nВведите первое натуральное число = "); int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите второе натуральное число = "); int y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Class2.RecursiveSumNumber(x, y));

        }
    }
}
