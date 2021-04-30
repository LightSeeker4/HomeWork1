using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.





            #region Привет мир
            Console.WriteLine("Привет, мир!");

            while (true)
            {
                Console.WriteLine("Нажмите k для выхода");
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.K) break;
                /*либо так
                var key = Console.ReadKey().KeyChar;
                if (key == 'r'
                    || key == 'R'
                    || key == 'K'
                    || key == 'k'
                ) break;
                */
                #endregion



            #region переменные
                Console.WriteLine("Введите ваше имя ");
                var box = Console.ReadLine();
                Console.WriteLine($"Привет, {box}!");
                #endregion



                #region Calc
                Console.WriteLine("Введите первое число:"); // writeline переводит строку для ввода на следующую а write оставляет на текущей
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число:");
                int b = int.Parse(Console.ReadLine());

                int c = a + b;

                Console.WriteLine(c);
                #endregion
            }



            //Console.ReadKey();  // чтобы сразу не закрывалось окно при нажатии f5(запуск с отладкой)



        }
    }
}
