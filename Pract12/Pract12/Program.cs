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
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++) Console.Write(mas[i] + " ");
        }

        public static void InsertionSort(int[] array,ref int count)
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
                }
                array[j] = cur;
                count++;
            }
            int[] p = array;
            ShowMas(array);
        }

        static void ViborSort(int[] mas,ref int count)
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
                    }
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
            int size = 0,i=0,j=0,Count1=0,Count2=0;
            
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

            ShowMas(mas);
            ShowMas(masSorted1);
            ShowMas(masSorted2);
            Console.WriteLine();
            InsertionSort(mas, ref Count1);
            Console.WriteLine();
            Console.WriteLine("Количество пересылок при сортировке неупорядоченного массива способом простых вставок:  " + Count1);
            ViborSort(mas, ref Count2);
            Console.WriteLine();
            Console.WriteLine("Количество пересылок при сортировке неупорядоченного массива способом простого выбора:  " + Count2);
            Console.WriteLine();

            Count1 = 0; Count2 = 0;
            InsertionSort(masSorted1, ref Count1);
            Console.WriteLine();
            Console.WriteLine("Количество пересылок при сортировке упорядоченного по возрастанию массива способом простых вставок:  " + Count1);
            ViborSort(masSorted1, ref Count2);
            Console.WriteLine();
            Console.WriteLine("Количество пересылок при сортировке упорядоченного по возрастанию массива способом простого выбора:  " + Count2);

            Count1 = 0; Count2 = 0;
            InsertionSort(masSorted2, ref Count1);
            Console.WriteLine();
            Console.WriteLine("Количество пересылок при сортировке упорядоченного по убыванию массива способом простых вставок:  " + Count1);
            ViborSort(masSorted2, ref Count2);
            Console.WriteLine();
            Console.WriteLine("Количество пересылок при сортировке упорядоченного по убыванию массива способом простого выбора:  " + Count2);
            Console.ReadLine();

        }
    }
}
