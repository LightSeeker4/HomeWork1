using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static string Ask_user(string ask)
        {
            Console.WriteLine($"{ask}");
            return Console.ReadLine(); ;
        }


        public static int Ask_int_user(string ask)
        {
            Console.WriteLine($"{ask}");
            return Convert.ToInt32(Console.ReadLine());
        }


        public static void Print(string msg)
        {
            int centerX = (Console.WindowWidth / 2) - (msg.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write(msg);
        }

        public static double Distance(double x1, double y1, double x2, double y2)
        {
          return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

    }
}
