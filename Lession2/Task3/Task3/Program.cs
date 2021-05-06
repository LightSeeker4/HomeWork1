using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace Task3
{
    class Program
    {
        //Алексей Сазонов
        //3. С клавиатуры вводятся числа, пока не будет введен 0.
        //Подсчитать сумму всех нечетных положительных чисел.
        
        static void Main(string[] args)
        {
            Console.WriteLine($"Cумма всех нечетных положительных чисел = {Class2.SumOddNumber()}");
        }


    }
}
