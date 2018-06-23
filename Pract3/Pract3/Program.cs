using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=0, y=0;
            bool YES = false, ok = false;
            
            do
            {
                Console.WriteLine("Введите число x");
                try
                {
                    x = Convert.ToDouble(Console.ReadLine());
                    ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка, повторите ввод");
                    ok = false;
                }
            } while (!ok);

            do
            {
                Console.WriteLine("Введите число y");
                try
                {
                    y = Convert.ToDouble(Console.ReadLine());
                    ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка, повторите ввод");
                    ok = false;
                }
            } while (!ok);
            if (x >= -1 && x <= 1 && y >= -2 && y <= 0)
                YES = true;
            if ((x >= -1 && x <= 1 && y >= 0 && y <= 1) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Sqrt(2)) &&(Math.Abs(x)>=y))
                YES = true;
            if (YES)
                Console.WriteLine("Точка " + x + ";" + y + " принадлежит заданной области");
            else
                Console.WriteLine("Точка " + x + ";" + y + " не принадлежит заданной области");
            Console.ReadLine();
        }
    }
}
