using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class2
    {
        public static int MinNumber(int a, int b, int c)
        {
            int min;
            if (a < b && a < c) { min = a; }
            else
            {
                if (b < c) { min = b; }
                else { min = c; }
            }
            return min;
        }

        public static int CountNumber(int a)
        {
            int count = 0;
            if (a == 0) count = 1;
            while (a != 0) 
                {
                    a = a / 10;
                    count++;
                }
            return count;
        }

        public static int SumOddNumber()
        {
            int sum = 0;
            while (true)
            {
                Console.Write("Если хотите выйти из программы, введите 0\nВведите положительное число = "); int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0) break;
                if (a > 0 && a % 2 == 1) sum += a;
            }
            return sum;
        }

        public static bool CheckUser(string Login, string Password)
        {
            return (Login == "root" && Password == "GeekBrains");
        }

        public static void RecursiveNumber(int a, int b)
        {
            Console.Write($"{a} ");
            if (a < b) RecursiveNumber(a + 1, b);
        }

        public static int RecursiveSumNumber(int a, int b)
        {
            return a < b ? a + RecursiveSumNumber(a + 1, b) : a;
        }

        public static double Ask_user(string ask)
        {
            Console.WriteLine($"{ask}");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
