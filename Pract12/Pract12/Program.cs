using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract12
{
    class Program
    {
        public static void ShowMas(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++) Console.Write(mas[i] + " ");
        }

        public static void ComprResults(int[] array,string First,string Second)
        {
            int countSr1 = 0, countSr2 = 0;
            int Count1 = 0, Count2 = 0;
            int[] CP = new int[array.Length];
            Array.Copy(array, CP, array.Length);
            Console.Write("Результаты сортировки "+First);
            InsertionSort(CP, ref Count1, ref countSr1);
            Console.WriteLine();
            Console.WriteLine("Количество пересылок: " + Count1);
            Console.WriteLine("Количество сравнений: " + countSr1);
            Console.WriteLine();
            Array.Copy(array, CP, array.Length);
            Console.Write("Результаты сортировки "+Second);
            ViborSort(CP, ref Count2, ref countSr2);
            Console.WriteLine();
            Console.WriteLine("Количество пересылок: " + Count2);
            Console.WriteLine("Количество сравнений: " + countSr2);
            Console.WriteLine();
        }

        public static void InsertionSort(int[] array,ref int count, ref int countSr)
        {
            
            for (int i = 1; i < array.Length; i++)
            {
                int cur = array[i];
                int j = i;
                while (j > 0 && cur < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                    count++;
                    countSr++;
                }
                if (j>0) countSr++;
                array[j] = cur;
                count++;
            }
            ShowMas(array);
        }

        static void ViborSort(int[] mas,ref int count, ref int countSr)
        {

            for (int i = 0; i < mas.Length - 1; i++)
            {
                //поиск минимального числа
                int min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                        countSr++;
                    }
                    else countSr++;
                }
                //обмен элементов
                int temp = mas[min];
                mas[min] = mas[i];
                count++;
                mas[i] = temp;
                count++;
            }
            ShowMas(mas);
        }

        static Random rnd = new Random();

        static void Main(string[] args)
        {
            bool ok= false;
            int size = 0,i=0,j=0,Count1=0,Count2=0, countSr1 = 0, countSr2 = 0;
            
            Console.WriteLine("Введите длину массива");
            do
            {
                try
                {
                    size = Convert.ToInt32(Console.ReadLine());
                    ok = true;
                    if (size < 1)
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

            int[] mas = new int[size];
            for (i=0;i<size;i++)
            {
                mas[i] = rnd.Next(100);
            }
            int[] masSorted1 = new int[size];
            for (i = 0; i < size; i++)
            {
                masSorted1[i] = mas[i];
            }
            int[] masSorted2 = new int[size];
            for (i = 0; i < size; i++)
            {
                masSorted2[i] = mas[i];
            }

            Array.Sort(masSorted1);
            Array.Sort(masSorted2,(x,y)=>-x.CompareTo(y));
                Console.Write("Неупорядоченный массив: ");
                ShowMas(mas);
                Console.WriteLine();
                Console.Write("Упорядоченный по возрастанию массив: ");
                ShowMas(masSorted1);
                Console.WriteLine();
                Console.Write("Упорядоченный по убыванию массив: ");
                ShowMas(masSorted2);
            Console.WriteLine();
            Console.WriteLine();

            ComprResults(mas, "неупорядоченного массива способом простых вставок: ", "неупорядоченного массива способом простого выбора: ");
            
            ComprResults(masSorted1, "упорядоченного по возрастанию массива способом простых вставок: ", "упорядоченного по возрастанию массива способом простого выбора: ");
            
            ComprResults(masSorted2, "упорядоченного по убыванию массива способом простых вставок: ", "Результаты сортировки упорядоченного по убыванию массива способом простого выбора: ");

            Console.ReadLine();

        }
    }
}
