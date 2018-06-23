using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract9
{
    class Program
    {
        class Point

        {
            public string data;
            public Point next, //адрес следующего элемента 
                         pred;//адрес предыдущего элемента 
            public Point()

            {
                data = "";
                next = null;
                pred = null;
            }

            public Point(string d)

            {
                data = d;
                next = null;
                pred = null;
            }

            public override string ToString()

            {
                return data + " ";
            }

        }

        static Point MakePoint(string d)
        {
            Point p = new Point(d);
            return p;
        }


        static void DeletePoint(ref Point beg)
        {
            if (beg == null)//пустой список 

            {

                Console.WriteLine("Error! The List is empty");


            }
            else
            {
                if (beg.next != null)
                {
                    beg = beg.next;
                    Console.WriteLine("Элемент " + beg.pred.data + " удален");
                    beg.pred = null;
                }
                else
                {
                    Console.WriteLine("Элемент " + beg.data + " удален");
                    beg = null;
                }
            }
        }
        static void FindPoint(Point beg, string find, int i)
        {
            if (beg!= null)
            {
                
                if (beg.data != null)
                    if (beg.data == find) Console.WriteLine("Элемент " + find + " найден за " + i + " шагов");
                    else FindPoint( beg.next, find, i + 1);
            }
            else Console.WriteLine("Элемент не найден");
        }

        static Point MakeList(int size) //добавление в начало 

        {
            Point beg = MakePoint("");
            int g = 0, number = 0;
            bool ok = true;
            string Variant, info = "";
            Random rnd = new Random();
            g = rnd.Next(100);
            Console.WriteLine("1.Заполнение в ручную");
            Console.WriteLine("2.Заполнение с помощью ДСЧ");

            do
            {
                try
                {
                    Variant = Console.ReadLine();
                    number = int.Parse(Variant);
                    ok = true;
                    if (number < 1 || number > 2)
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

            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("Введите элемент");
                        info = Console.ReadLine();
                        Console.WriteLine("The element {0} is adding...", info);
                        beg = MakePoint(info);
                        for (int i = 1; i < size; i++)
                        {
                            Console.WriteLine("Введите элемент");
                            info = Console.ReadLine();
                            Console.WriteLine("The element {0} is adding...", info);
                            Point p = MakePoint(info);
                            p.next = beg;
                            beg.pred = p;
                            beg = p;
                        }
                        return beg;
                    }
                case 2:
                    {
                        info = Convert.ToString(rnd.Next(10));
                        Console.WriteLine("The element {0} is adding...", info);
                        beg = MakePoint(info);
                        for (int i = 1; i < size; i++)
                        {
                            info = Convert.ToString(rnd.Next(100));
                            Console.WriteLine("The element {0} is adding...", info);
                            Point p = MakePoint(info);
                            p.next = beg;
                            beg.pred = p;
                            beg = p;
                        }
                        return beg;
                    }
            }
            return beg;
        }
        static void ShowList(Point beg)
        {
            //проверка наличия элементов в списке 
            if (beg == null)
            {
                Console.WriteLine("The List is empty");
                return;
            }
            Point p = beg;
            while (p != null)
            {
                Console.Write(p);
                p = p.next;//переход к следующему элементу 
            }
            Console.WriteLine();
        }
        static Point DelList(ref Point beg, int number)

        {
            Console.WriteLine("Удаление списка...");
            if (beg == null)//пустой список 

            {

                Console.WriteLine("Error! The List is empty");

                return null;

            }
            beg = null;
            return beg;
        }


        static Point AddPoint(Point beg, int count)
        {

            bool ok = true;
            Random rnd = new Random();
            int r = rnd.Next(10, 100), j = 0, W = 0;
            string Var;
            string info = "";
            if (beg == null)//пустой список 

            {

                Console.WriteLine("Error! The List is empty");

                return null;

            }
            Console.WriteLine("Введите элемент, после которого будет добавлен новый элемент");
            string number = Console.ReadLine();

            Console.WriteLine("1.Добавление элемнета введенного в ручную");
            Console.WriteLine("2.Добавление рандомного числа");
            do
            {
                try
                {
                    Var = Console.ReadLine();
                    W = int.Parse(Var);
                    ok = true;
                    if (W < 1 || W > 2)
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


            switch (W)
            {
                case 1:
                    Console.WriteLine("Введите новый элемент");
                    info = Console.ReadLine();
                    break;
                case 2:
                    info = Convert.ToString(r);
                    break;
            }
            Console.WriteLine("The element {0} is adding...", info);
            //создаем новый элемент 
            Point NewPoint = MakePoint(info);
            if (beg == null)//список пустой 
            {
                r = rnd.Next(10, 100);
                beg = MakePoint(Convert.ToString(r));
                return beg;
            }
            //вспом. переменная для прохода по списку 
            Point p = beg;

            //идем по списку до нужного элемента
            while (p.data != number && j < count - 1)
            {
                j++;
                p = p.next;
            }
            if (j == count - 1 && p.data != number)//элемент не найден 
            {
                Console.WriteLine("Ошибка, заданного элемента не найдено");
                return beg;
            }
            //добавляем новый элемент 
            NewPoint.next = p.next;
            p.next = NewPoint;
            return beg;
        }

        static void Main(string[] args)
        {
            int i = 0, number = 10, variantInt = 0;
            string FindE = "", Variant, num = "10";
            bool ok, cycle = false;
            Point List;
            Console.WriteLine("1.Ввести кол-во элементов");
            Console.WriteLine("2.Рандомное кол-во элементов");
            do
            {
                try
                {
                    Variant = Console.ReadLine();
                    variantInt = int.Parse(Variant);
                    ok = true;
                    if (variantInt > 2 || variantInt < 1)
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
            switch (variantInt)
            {
                case 1:
                    Console.WriteLine("Введите кол-во элементов");
                    do
                    {
                        try
                        {
                            Variant = Console.ReadLine();
                            number = int.Parse(Variant);
                            ok = true;
                            if (number < 1)
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
                    break;
                case 2:
                    Random rnd = new Random();
                    number = rnd.Next(10);
                    break;
            }
            MakePoint(num);
            List = MakeList(number);

            do
            {
                Console.WriteLine("1.Вывести список на экран");
                Console.WriteLine("2.Добавить элемент в список");
                Console.WriteLine("3.Удалить первый элемент");
                Console.WriteLine("4.Найти элемент");
                Console.WriteLine("5.Выход");
                do
                {
                    try
                    {
                        Variant = Console.ReadLine();
                        variantInt = int.Parse(Variant);
                        ok = true;
                        if (variantInt > 5 || variantInt < 1)
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

                switch (variantInt)
                {
                    case 1:
                        ShowList(List);
                        break;
                    case 2:
                        AddPoint(List, number);
                        break;
                    case 3:
                        DeletePoint(ref List);
                        break;
                    case 4:
                        string Vvod;
                        if (List != null)
                        {
                            do
                            {
                                Console.WriteLine("Введите искомый элемент");
                                Vvod = Console.ReadLine();
                                ok = true;
                                if (Vvod == null)
                                {
                                    Console.WriteLine("Ошибка, повторите ввод");
                                    ok = false;
                                }
                            } while (!ok);
                            FindPoint(List, Vvod, 1);
                        }
                        else Console.WriteLine("Error! The List is empty");
                        break;
                    case 5:
                        cycle = true;
                        break;
                }
            } while (!cycle);


        }
    }
}
