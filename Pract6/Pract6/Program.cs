using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    class Program
    {

        static void RekursChl(ref double[] mas,int i,int counter)
        {
            if (counter == 0)
                mas[i] = 7 / 3;
            else
                if (counter == 1)
                mas[i] = mas[i] * mas[i - counter];
            else
                if (counter == 2) mas[i] = mas[i] + mas[i - counter];
            else
                if (counter == 3) mas[i] = mas[i] / 2 * mas[i - counter];
            counter++;

            if (counter <= 3) RekursChl(ref mas, i, counter);
        }

        static void Main(string[] args)
        {

            int M = 0, N = 0, L = 0, i = 0, j = 0,counter=0 ;
                bool ok=false;
            double[] a = new double[3];

            {
                for (i = 0; i < 3; i++)

                    do
                    {
                    Console.WriteLine("Введите число a"+(i+1));
                    try
                    {
                        a[i] = Convert.ToDouble(Console.ReadLine());
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
                    Console.WriteLine("Введите число N, оно должно быть больше 3");
                    try
                    {
                        N = Convert.ToInt32(Console.ReadLine());
                        ok = true;
                        if (N<=3)
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
                do
                {
                    Console.WriteLine("Введите число M");
                    try
                    {
                        M = Convert.ToInt32(Console.ReadLine());
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
                    Console.WriteLine("Введите число L");
                    try
                    {
                        L = Convert.ToInt32(Console.ReadLine());
                        ok = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка, повторите ввод");
                        ok = false;
                    }
                } while (!ok);


            }
            Array.Resize(ref a, N);

            i = 3;
            do
            {
                counter = 0;
                RekursChl(ref a, i, counter);
               
                if (a[i] > L) j++;
                i++;
            } while (i < N && j < M);

            if (i==N)
            {
                Console.WriteLine("Причина остановки - построены N="+N+" элементов последовательности");
                for (j = 0; j < N; j++)
                    Console.Write(a[j] + " ");
            }
            else
            {
                Console.WriteLine("Причина остановки - найдено M="+M+" элементов последовательности(не считая первые 3) больших чем L="+ L);
                for (j = 0; j < i; j++)
                    Console.Write(a[j] + " ");

            }
            Console.ReadLine();

        }
    }
}
