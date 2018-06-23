using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract10
{
    class Program
    {

        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int size = 0, i = 0, j = 0, k = 0, m = 0, counter = 0;
            bool ok = false;
            do
            {
                Console.WriteLine("Введите размерность матрицы смежности");
                try
                {
                    size = Convert.ToInt32(Console.ReadLine());
                    ok = true;
                    if (size < 1)
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

            int[] P = new int[size];
            int[,] Matr = new int[size, size];
            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    Matr[i, j] = rnd.Next(2);
                    Console.Write(Matr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (j = 0; j < size; j++)
            {
                P[j] = rnd.Next(10);
                Console.Write(P[j] + " ");
            }

            MyGraph GR = new MyGraph(size, P, Matr);

            do
            {
                Console.WriteLine("Введите элемент для удаления");
                try
                {
                    k = Convert.ToInt32(Console.ReadLine());
                    ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка, повторите ввод");
                    ok = false;
                }
            } while (!ok);


            GR.DeleteWithData(ref GR, k);


            for (i = 0; i < GR.S; i++)
            {
                for (j = 0; j < GR.S; j++)
                {
                    Console.Write(GR.LinesTo[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (j = 0; j < GR.S; j++)
            {
                Console.Write(GR.Nodes[j] + " ");
            }

            Console.ReadLine();
        }
    }
}
