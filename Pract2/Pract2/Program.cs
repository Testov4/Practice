using System;
using System.IO;

namespace Pract2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0, n = 0, g = 0, FiveCounter = 0;
            int x = 15;
            int size = 0, bestsize = 0, bestcode = -1;
            bool Good = true;
            string line, owo = "";
            StreamReader sr = new System.IO.StreamReader("input.txt");
            StreamWriter sw = new System.IO.StreamWriter("output.txt");
            line = sr.ReadLine();
            while (j != line.Length)
            {
                owo = owo + line[j];
                j++;
            }
            n = Convert.ToInt32(owo);
            owo = "";
            bool[,] CanGroup = new bool[n, n];
            int[,] Matrix = new int[n, n];
            while ((line = sr.ReadLine()) != null)
            {
                g = 0;
                for (j = 0; j < line.Length; j++)
                {
                    if (line[j] != Convert.ToChar(" "))
                    {
                        Matrix[i, g] = Convert.ToInt32(Convert.ToString(line[j]));
                        g++;
                    }
                }
                i++;
            }



            bestcode = -1;
            bestsize = 0;

            bool check = true;


            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (Matrix[i, j] == 0) CanGroup[i, j] = false;
                    else CanGroup[i, j] = true;
                }
            }


            for (int GroupCode = 1; GroupCode < (1 << n); GroupCode++)
            {
                size = 0;
                for (i = 0; i < n; i++)
                {
                    if (((GroupCode >> i) & 1) != 0)
                    {
                        size++;
                    }
                }
                if (size > 5) continue;
                if (bestsize >= size) continue;

                bool good = true;
                for (i = 0; i < n && good; i++)
                {
                    for (j = 0; j < n && good; j++)
                    {
                        if ((((GroupCode >> i) & 1) != 0) && (((GroupCode >> j) & 1) != 0) && (!CanGroup[i, j]))
                        {
                            good = false;
                        }
                    }
                }
                if (good)
                {
                    bestcode = GroupCode;
                    bestsize = size;
                }
            }

            int color = 2;

            sw.WriteLine(n - bestsize + 1);
            for (i = 0; i < n; i++)
            {
                if (i > 0) sw.Write(" ");
                if ((((bestcode >> i) & 1) != 0)) sw.Write("1");
                else
                {
                    sw.Write(color);
                    color++;
                }
            }
            sw.WriteLine();
            //Console.ReadLine();
            sw.Close();
            sr.Close();
        }
    }
}