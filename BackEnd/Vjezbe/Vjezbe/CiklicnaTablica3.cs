using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe
{
    internal class CiklicnaTablica3
    {
        public static void Izvedi()
        {
            Console.WriteLine("CiklicnaTablica");

            Console.Write("Broj redaka: ");
            int redak = int.Parse(Console.ReadLine());

            Console.Write("Broj stupaca: ");
            int stupac = int.Parse(Console.ReadLine());

            int[,] brojevi = new int[redak, stupac];

            int broj = 1;

            int redakMax = redak - 1;
            int donjiRed = redakMax;
            int redakMin = 0;
            int gornjiRed = 0;
            int stupacMin = 0;
            int lijeviRed = 0;
            int stupacMax = stupac - 1;
            int desniRed = stupacMax;

            int maxBroj = redak * stupac;


            while (broj <= maxBroj)
            {
                while (gornjiRed <= donjiRed && lijeviRed <= desniRed)
                {
                    while (donjiRed == redakMax)
                    {
                        if (broj > maxBroj)
                        {
                            break;
                        }
                        for (int i = stupacMax; i >= stupacMin; i--)
                        {
                            brojevi[redakMax, i] = broj;
                            broj++;
                        }
                        redakMax--;
                    }
                    while (lijeviRed == stupacMin)
                    {
                        if (broj > maxBroj)
                        {
                            break;
                        }
                        for (int i = redakMax; i >= redakMin; i--)
                        {
                            brojevi[i, stupacMin] = broj;
                            broj++;
                        }
                        stupacMin++;
                    }
                    while (gornjiRed == redakMin)
                    {
                        if (broj > maxBroj)
                        {
                            break;
                        }
                        for (int i = stupacMin; i <= stupacMax; i++)
                        {
                            brojevi[redakMin, i] = broj;
                            broj++;
                        }
                        redakMin++;
                    }
                    while (desniRed == stupacMax)
                    {
                        if (broj > maxBroj)
                        {
                            break;
                        }
                        for (int i = redakMin; i <= redakMax; i++)
                        {
                            brojevi[i, stupacMax] = broj;
                            broj++;
                        }
                        stupacMax--;
                    }

                    donjiRed--;
                    lijeviRed++;
                    gornjiRed++;
                    desniRed--;

                }
            }

            for (int i = 0; i < redak; i++)
            {
                for (int j = 0; j < stupac; j++)
                {
                    Console.Write("{0}.", brojevi[i, j]);
                }
                Console.WriteLine();
            }








            Console.WriteLine("**************************************");
            Console.WriteLine("Indexi tablice");
            int[,] indexi = new int[redak, stupac];
            for (int i = 0; i < redak; i++)
            {

                indexi[i, 0] = i;

                for (int j = 0; j < stupac; j++)
                {
                    indexi[0, j] = j;
                    Console.Write("{0}{1}.", i, j);

                }
                Console.WriteLine();
            }
            Console.WriteLine("**************************************");
        }
    }
}
