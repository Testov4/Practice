using System;
using System.IO;


class Program
{

    static void Main()
    {

        StreamReader sr = new StreamReader("input.txt");
        StreamWriter sw = new StreamWriter("output.txt");

        string[] line = sr.ReadLine().Split(' ');
        int N = int.Parse(line[0]);     
        int M = int.Parse(line[1]);     
        int P = int.Parse(line[2]);


        int[,] arr = new int[N, M];    
        int[,] sum = new int[N, M]; 
        sum.Initialize();
        int counter = 0;      
        for (int i = 0; i < P; i++)
        {
            line = sr.ReadLine().Split(' ');
            arr[int.Parse(line[0]) - 1, int.Parse(line[1]) - 1] = 1;
        }
        
        for (int i = 0; i < N - 1; i++)
            for (int j = 1; j < M; j++)
            {
                int C = 0;                
                for (int k = i + 1; k < N; k++)   
                    C =C+arr[k, j-1];
                if (j - 1 > 0)                    
                    sum[i, j] = sum[i, j - 1] + C;
                else sum[i, j] = C;
                if (arr[i, j] != 0)               
                    counter =counter + sum[i, j];        
            }


        sw.WriteLine(counter);

        sw.Close();
        sr.Close();
    }
}

