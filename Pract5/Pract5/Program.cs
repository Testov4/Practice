using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract5
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            bool ok=false;
            int size=0, i = 0, j = 0, Sum = 0,x1=0,x2=0;
            do
            {
                Console.WriteLine("Введите размерность матрицы");
                try
                {
                    size = Convert.ToInt32(Console.ReadLine());
                    ok = true;
                    if (size<1)
                    {
                        Console.WriteLine("Ошибка, повторите ввод");
                        ok = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка, повторите ввод");
                    ok = false;
                }
            } while (!ok);
            int[,] Matr = new int[size, size];
            
            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    Matr[i, j] = rnd.Next(10);
                    Console.Write(Matr[i,j]+" ");
                        }
                Console.WriteLine();
            }

            int[] CopyMas = new int[size];

            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    CopyMas[j] = Matr[i, j];
                }
                Array.Sort(CopyMas);
                x1 = CopyMas[size - 1];
                for (j = 0; j < size; j++)
                {
                    CopyMas[j] = Matr[size-1-i, j];
                }
                Array.Sort(CopyMas);
                x2 = CopyMas[size - i];
                Sum = Sum + x1 * x2;
            }
            Console.WriteLine("Сумма ряда = " +Sum);
            Console.ReadLine();
        }
    }
}
