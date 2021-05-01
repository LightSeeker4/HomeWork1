using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {  
            //5.
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) Сделать задание, только вывод организовать в центре экрана.
            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).


            //абв
            string name = Class1.Ask_user("Введите ваше имя: ");
            string surname = Class1.Ask_user("Введите вашу фамилию: ");
            string city = Class1.Ask_user("Введите город в котором проживаете сейчас: ");
            Class1.Print($"Меня зовут {name} {surname} и я живу в городе {city}\n");

        }
    }
}