using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe
{
    internal class CiklicnaTablica
    {
        public static void Izvedi()
        {
            Console.WriteLine("CiklicnaTablica");

            Console.Write("Broj redaka: ");
            int redak = int.Parse(Console.ReadLine());
            Console.Write("Broj stupaca: ");
            int stupac = int.Parse(Console.ReadLine());

            //int brojeviUkupno = redak * stupac;
            int brojeviUkupno = 1;
            int najveciBroj = redak * stupac;
            int[,] brojevi = new int[redak, stupac];
            int redakMin = 0;
            int redakMax = redak - 1;
            int stupacMin = 0;
            int stupacMax = stupac - 1;

            while (redakMax == redakMax)
            {
                for (int i = stupacMax; i >= 0; i--)
                {
                    brojevi[redakMax, i] = brojeviUkupno++;
                }
                redakMax--; //sad je 3
            }
            while (stupacMin == 0)
            {
                for (int j = redakMax; j >= 0; j--)
                {
                    brojevi[j, stupacMin] = brojeviUkupno++;
                }
                stupacMin++;
            }
            while (redakMin == 0)
            {
                for (int k = stupacMin; k <= stupacMax; k++)
                {
                    brojevi[redakMin, k] = brojeviUkupno++;
                }
                redakMin++;
            }
            while (stupacMax == stupacMax)
            {
                for (int l = redakMin; l <= redakMax; l++)
                {
                    brojevi[l, stupacMax] = brojeviUkupno++;
                }
                stupacMax--;
            }


            //int redakMin = 1;
            //int redakMax = redak - 2; (3)
            //int stupacMin = 1;
            //int stupacMax = stupac - 2; (3)



            //***************************************************

            //int m = redak-1; //4
            //while (m == redak-1)
            //{
            //    for (int k = stupac - 1; k >= 0; k--)
            //    {
            //        brojevi[m, k] = brojeviUkupno++;
            //    }
            //}
            //int a = 0;
            //while (a==0)
            //{
            //    for (int b = redak-2; b >= 0; b--)
            //    {
            //        brojevi[b, a] = brojeviUkupno++;
            //    }
            //    a++; // a je sada 1
            //}
            //int c = 0;
            //while (c == 0)
            //{
            //    for (int d = 0; d <= stupac-1 ; d++)
            //    {
            //        brojevi[c, d] = brojeviUkupno++;
            //    }
            //    c++; // c je sada 1
            //    m--; // m je sada 3
            //}
            //int e = redak - 1;//4
            //while (e== redak-1)
            //{
            //    for (int f = a; f <= m ; f++)
            //    {
            //        brojevi[f, m] = brojeviUkupno++;
            //    }
            //    e--; //3
            //}
            //while (m==3)
            //{

            //}

            //************************************************

            //int[,] indexi = new int[redak, stupac];

            //for (int i = 0; i < redak; i++)
            //{

            //    indexi[i,0] = i;

            //    for (int j = 0; j < stupac; j++)
            //    {
            //        indexi[0, j] = j;
            //        Console.Write("{0}{1}.",i,j);

            //    }
            //    Console.WriteLine();
            //}



            //***********************************************************
        }


    }
}

