using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace HomeWork1
{
    class Program
    {


 
        static void Main(string[] args)
        {
            // Алексей Сазонов
            //1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.

            string name = CLass1.Ask_user("Введите ваше имя: ");
            string surname = CLass1.Ask_user("введите вашу фамилию: ");
            int age = CLass1.Ask_int_user("введите ваш возраст: ");
            int height = CLass1.Ask_int_user("введите ваш рост: ");
            int weight = CLass1.Ask_int_user("введите ваш вес: ");

            //a
            Console.WriteLine("Данные анкеты:\nИмя:" + name + ", Фамилия:" + surname + ", Возраст:" + age + ", Рост:" + height + ", Вес:" + weight);
            //б
            Console.WriteLine(String.Format("Данные анкеты:\nИмя:{0} Фамилия:{1} Возраст:{2} Рост:{3} Вес:{4}", name, surname, age, height, weight));
            //в
            Console.WriteLine($"Данные анкеты:\nИмя:{name}, Фамилия:{surname}, Возраст:{age}, Рос:{height}, Вес:{weight}");
        }

    }
}
