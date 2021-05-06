using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Алексей Сазонов
            //4.Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.

            //a
            int a = 10;     
            int b = 20;

            Console.WriteLine($"a = {a}\nb = {b}");

            int c = a;       
            a = b;           
            b = c;

            Console.WriteLine($"a = {a}\nb = {b}");

            //б
            int x = 10;
            int y = 20;

            Console.WriteLine($"x = {x}\ny = {y}");

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($"x = {x}\ny = {y}");
        }
    }
}