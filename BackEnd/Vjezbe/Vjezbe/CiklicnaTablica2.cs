using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe
{
    internal class CiklicnaTablica2
    {
        public static void Izvedi()
        {
            Console.WriteLine("CiklicnaTablica");

            Console.Write("Broj redaka: ");
            int redak = int.Parse(Console.ReadLine());
            Console.Write("Broj stupaca: ");
            int stupac = int.Parse(Console.ReadLine());

            int[,] brojevi = new int[redak, stupac];

            int suma = 1;

            int redakMax = redak - 1;
            int bottom = redakMax;
            int redakMin = 0;
            int top = 0;
            int stupacMin = 0;
            int left = 0;
            int stupacMax = stupac - 1;
            int right = stupacMax;

            while (top <= bottom && left <= right)
            {
                while (bottom == redakMax)
                {
                    for (int i = stupacMax; i >= stupacMin; i--)
                    {
                        brojevi[redakMax, i] = suma;
                        suma++;
                    }
                    redakMax--;
                }
                while (left == stupacMin)
                {
                    for (int i = redakMax; i >= redakMin; i--)
                    {
                        brojevi[i, stupacMin] = suma;
                        suma++;
                    }
                    stupacMin++;
                }
                while (top == redakMin)
                {
                    for (int i = stupacMin; i <= stupacMax; i++)
                    {
                        brojevi[redakMin, i] = suma;
                        suma++;
                    }
                    redakMin++;
                }
                while (right == stupacMax)
                {
                    for (int i = redakMin; i <= redakMax; i++)
                    {
                        brojevi[i, stupacMax] = suma;
                        suma++;
                    }
                    stupacMax--;
                }
                bottom--;
                left++;
                top++;
                right--;

            }

            for (int i = 0; i < redak; i++)
            {
                for (int j = 0; j < stupac; j++)
                {
                    Console.Write("{0}.", brojevi[i, j]);
                }
                Console.WriteLine();
            }

            //int[,] indexi = new int[redak, stupac];
            //for (int i = 0; i < redak; i++)
            //{

            //    indexi[i, 0] = i;

            //    for (int j = 0; j < stupac; j++)
            //    {
            //        indexi[0, j] = j;
            //        Console.Write("{0}{1}.", i, j);

            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
