using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract11
{
    class Program
    {

        
        static void Main(string[] args)
        {
            bool ok;
            int k=0,i=0,vibor=0,j=0;
            
            Console.WriteLine("Введите число К");
            do
            {
                try
                {
                    k = Convert.ToInt32(Console.ReadLine());
                    ok = true;
                    if (k < 1)
                    {
                        ok = false;
                        Console.WriteLine("Ошибка, повторите ввод");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка, повторите ввод");
                    ok = false;
                }
            } while (!ok);

            int[] S = new int[k];

            for (i = 0; i < k; i++)
            {
                Console.WriteLine("Введите {0} член последовательности S",i+1);
                do
                {
                    try
                    {
                        S[i] =Convert.ToInt32(Console.ReadLine()) ;
                        ok = true;
                        
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка, повторите ввод");
                        ok = false;
                    }
                } while (!ok);

            }

            bool cycle = false;
            while (!cycle)
            {
                Console.WriteLine("1.Зашифровать строку");
                Console.WriteLine("2.Расшифровать строку");
                Console.WriteLine("3.Выход");
                do
                {
                    try
                    {
                        vibor = Convert.ToInt32(Console.ReadLine());
                        ok = true;
                        if (vibor < 1 || vibor > 3)
                        {
                            ok = false;
                            Console.WriteLine("Ошибка, повторите ввод");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка, повторите ввод");
                        ok = false;
                    }
                } while (!ok);
                switch (vibor)
                {
                    case 1:
                        {

                            int Leng = 0;

                            Console.WriteLine("Введите длину строки");
                            do
                            {
                                try
                                {
                                    Leng = Convert.ToInt32(Console.ReadLine());
                                    ok = true;
                                    if (Leng < 1)
                                    {
                                        ok = false;
                                        Console.WriteLine("Ошибка, повторите ввод");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Ошибка, повторите ввод");
                                    ok = false;
                                }
                            } while (!ok);

                            int[] Shifr = new int[Leng];

                            for (i = 0; i < Leng; i++)
                            {

                                Console.WriteLine("Введите {0} член строки", i + 1);
                                do
                                {
                                    try
                                    {
                                        Shifr[i] = Convert.ToInt32(Console.ReadLine());
                                        ok = true;
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Ошибка, повторите ввод");
                                        ok = false;
                                    }
                                } while (!ok);
                            }
                            for (i = 0; i < Leng; i++)
                            {
                                Shifr[i] = S[Shifr[i] - 1];
                            }
                            Console.WriteLine();
                            for (i = 0; i < Leng; i++) Console.Write(Shifr[i] + " ");
                            break;
                        }
                    case 2:
                        {
                            int Leng = 0;

                            Console.WriteLine("Введите длину строки");
                            do
                            {
                                try
                                {
                                    Leng = Convert.ToInt32(Console.ReadLine());
                                    ok = true;
                                    if (Leng < 1)
                                    {
                                        ok = false;
                                        Console.WriteLine("Ошибка, повторите ввод");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Ошибка, повторите ввод");
                                    ok = false;
                                }
                            } while (!ok);

                            int[] Shifr = new int[Leng];

                            for (i = 0; i < Leng; i++)
                            {

                                Console.WriteLine("Введите {0} член строки", i + 1);
                                do
                                {
                                    try
                                    {
                                        Shifr[i] = Convert.ToInt32(Console.ReadLine());
                                        ok = true;
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Ошибка, повторите ввод");
                                        ok = false;
                                    }
                                } while (!ok);
                            }
                            for (i = 0; i < Leng; i++)
                            {
                                for (j = 0; j < S.Length; j++)
                                {
                                    if (S[j] == Shifr[i])
                                    {
                                        Shifr[i] = j + 1;
                                        j = S.Length;
                                    }
                                }

                            }
                            Console.WriteLine();
                            for (i = 0; i < Leng; i++) Console.Write(Shifr[i] + " ");
                            
                            break;
                        }
                    case 3:
                        {
                            cycle = true;
                            break;
                        }
                }

            }
        }
    }
}
