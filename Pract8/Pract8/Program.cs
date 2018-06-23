using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract8
{
    class Program
    {

       
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int size = 0, i = 0, j = 0,k=0,m=0,counter=0 ;
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

            int[,] Matr = new int[size, size];
            int[] Color = new int[size];
            for (i = 0; i < size; i++) Color[i] = 0;
            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    Matr[i, j] = rnd.Next(2);
                    Console.Write(Matr[i, j] + " ");
                }
                Console.WriteLine();
            }
            int c = 0;
            i = 0;
            j = 0;
            while (Array.Exists(Color, element => element == 0))
            {

                Console.WriteLine("XD");
                Color[i] = 1;
                i++;
            }

            Console.WriteLine(counter);


            Console.ReadLine();
        }
    }
}
