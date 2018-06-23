using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract7
{
    class Program
    {

        

        static void Main(string[] args)
        {
            int i = 0,j=0,a=0;
            bool x, y, z,ok=false;
            string[] BulFunc = new string[256];
            for (i=0;i<256;i++)
            {
                a = i;
                BulFunc[i] = Convert.ToString(i,2);
                for (j=0;j<8;j++)
                {
                    if (BulFunc[i].Length != 8) BulFunc[i] = "0" + BulFunc[i];
                }

                for (j = 0; j < 4; j++)
                {
                    if (BulFunc[i][j] == BulFunc[i][BulFunc[i].Length-1-j]) ok=true;
                    
                }                
                if (ok) Console.WriteLine(BulFunc[i]);
                ok = false;
            }
            Console.ReadLine();
        }
    }
}
