using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe
{
    internal class TestLjubavi
    {
        public static void Izvedi()
        {
            Console.WriteLine("Test Ljubavi");

            string prvaOsoba = Pomocno.UcitajString("Unesi ime prve osobe");
            string drugaOsoba = Pomocno.UcitajString("Unesi ime druge osobe");

            Console.WriteLine("{0} i {1}", prvaOsoba, drugaOsoba);

            prvaOsoba = prvaOsoba.ToLower();
            drugaOsoba = drugaOsoba.ToLower();

            string nizZnakova = prvaOsoba + drugaOsoba;
            int[] kolicinaZnakova = new int[nizZnakova.Length];

            for (int i = 0; i < nizZnakova.Length; i++)
            {
                for (int j = 0; j < nizZnakova.Length; j++)
                {
                    if (nizZnakova[i] == nizZnakova[j])
                    {
                        kolicinaZnakova[i] += 1;
                    }
                }
            }

            //Console.WriteLine("*************");
            //for (int i = 0; i < kolicinaZnakova.Length; i++)
            //{
            //    Console.Write("{0}", kolicinaZnakova[i]);
            //}

            int minIndex = 0;
            int maxIndex = kolicinaZnakova.Length - 1;
            int[] drugaKolicinaZnakova = new int[(kolicinaZnakova.Length / 2) + 1];


            for (int i = 0; i < kolicinaZnakova.Length; i++)
            {
                drugaKolicinaZnakova[i] = kolicinaZnakova[minIndex] + kolicinaZnakova[maxIndex];
                minIndex++;
                maxIndex--;
                if (minIndex == maxIndex)
                {
                    drugaKolicinaZnakova[minIndex] = kolicinaZnakova[minIndex];
                    break;
                }
                else if (minIndex > maxIndex)
                {
                    break;
                }
            }


            Console.WriteLine("*************");
            for (int i = 0; i < drugaKolicinaZnakova.Length; i++)
            {
                Console.Write("{0}", drugaKolicinaZnakova[i]);
            }

            int[] trecaKolicinaZnakova = new int[drugaKolicinaZnakova.Length / 2];
            int minIndex2 = 0;
            int maxIndex2 = drugaKolicinaZnakova.Length - 1;

            for (int i = 0; i < drugaKolicinaZnakova.Length; i++)
            {
                trecaKolicinaZnakova[i] = drugaKolicinaZnakova[minIndex2] + drugaKolicinaZnakova[maxIndex2];
                minIndex2++;
                maxIndex2--;
                if (minIndex2 == maxIndex2)
                {
                    trecaKolicinaZnakova[minIndex2] = drugaKolicinaZnakova[minIndex2];
                    break;
                }
                else if (minIndex2 > maxIndex2)
                {
                    break;
                }
            }

            Console.WriteLine("*************");
            for (int i = 0; i < trecaKolicinaZnakova.Length; i++)
            {
                Console.Write("{0}", trecaKolicinaZnakova[i]);
            }

            int[] zadnjaKolicinaZnakova = new int[trecaKolicinaZnakova.Length / 2];
            int minIndex3 = 0;
            int maxIndex3 = trecaKolicinaZnakova.Length - 1;

            for (int i = 0; i < trecaKolicinaZnakova.Length; i++)
            {
                zadnjaKolicinaZnakova[i] = trecaKolicinaZnakova[minIndex3] + trecaKolicinaZnakova[maxIndex3];
                minIndex3++;
                maxIndex3--;
                if (minIndex3 == maxIndex3)
                {
                    zadnjaKolicinaZnakova[minIndex3] = trecaKolicinaZnakova[minIndex3];
                    break;
                }
                else if (minIndex3 > maxIndex3)
                {
                    break;
                }
            }

            Console.WriteLine("*************");
            for (int i = 0; i < zadnjaKolicinaZnakova.Length; i++)
            {
                Console.Write("Volite se {0}{1}%", zadnjaKolicinaZnakova[0], zadnjaKolicinaZnakova[1]);
            }



        }
    }
}
