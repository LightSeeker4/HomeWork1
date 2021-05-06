using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace Task4
{
    class Program
    {
        //Алексей Сазонов
        //4. Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль.
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел
        //(Логин: root, Password: GeekBrains).
        //Используя метод проверки логина и пароля, написать программу:
        //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        //С помощью цикла DO WHILE ограничить ввод пароля тремя попытками.
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.Write("Введите логин: "); string login = Console.ReadLine();
                Console.Write("Введите пароль: "); string password = Console.ReadLine();
                n++;
                if (Class2.CheckUser(login, password))
                {
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }
                else { Console.WriteLine("Попробуйте ещё раз!"); }
            }
            while (n != 3);
        }
    }
}
