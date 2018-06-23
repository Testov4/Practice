using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract10
{
    class MyGraph
    {
        private int size;
        public int S
        {
            get { return size; }
            set { size = value; }
        }
        public int[] Nodes;
        public int[,] LinesTo;//матрица смежности
        public MyGraph()
        {
            S = 0;
            Nodes = new int[0];
            LinesTo = new int[0,0];
        }
        public MyGraph(int s,int[] p,int[,] Matr)
        {
            S = s;
            Nodes = new int[s];
            Nodes = p;
            LinesTo = Matr;
        }
        public void DeleteWithData(ref MyGraph Gr ,int d)
        {
            int i=0, j=0,l=0,m=0,size=Gr.S;
            bool ok = false;
            int[] Copy = new int[Gr.S];
            int[,] CopyMas = null;
            for (i = 0; i < Gr.S; i++)
                Copy[i] = Gr.Nodes[i];

                for (i=0;i<Gr.S;i++)
            {
                if (Gr.Nodes[i]==d)
                {
                    ok = true;
                    m = 0;
                    Array.Resize(ref Gr.Nodes, --Gr.S);
                    CopyMas = new int[Gr.S, Gr.S];
                    for (l = 0; l < Gr.S; l++)
                    {
                        if (m == i) m++;
                        for (j = 0; j < Gr.S; j++)
                                CopyMas[l, j] = Gr.LinesTo[m, j];
                        m++;      
                    }
                    l = 0;
                    for (j = 0; j < Gr.S; j++)
                    {
                        if (l != i)
                            Gr.Nodes[j] = Copy[l];
                        else
                        {
                            l++;
                            Gr.Nodes[j] = Copy[l];
                        }
                        l++;
                    }


                    Array.Resize(ref Copy, Gr.S);
                    for (i = 0; i < Gr.S; i++)
                        Copy[i] = Gr.Nodes[i];
                }
                if (ok) Gr.LinesTo = CopyMas;

            }
        }
    }
}
