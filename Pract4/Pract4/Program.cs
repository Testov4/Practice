using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    class Program
    {

        static double Factorial(double i)
        {
            
            double j = 0,F=1;
            for (j = 1; j <= i; j++)
            {
                F = F * j;
            }
            return F;
        }

        static void Main(string[] args)
        {
            bool ok = false;
            double element, SE,i=1,n=0;
            do
            {
                Console.WriteLine("Введите число точности");
                try
                {
                    n = Convert.ToDouble(Console.ReadLine());
                    ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка, повторите ввод");
                    ok = false;
                }
            } while (!ok);

            element = 1;
            SE = 0;
            do
            {
                element = Math.Pow(-1, i) / Factorial(i);
                SE = SE + element;
                i++;
            } while ((Math.Abs(element) > n) || i == 1 || i == 2 || i == 3);
            Console.WriteLine(SE);
            Console.ReadLine();
        }
    }
}
