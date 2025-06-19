using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe
{
    internal class TestLjubavi2
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

            Console.WriteLine("{0}", string.Join(",", kolicinaZnakova));

            Pomocno.TestLjubavi(kolicinaZnakova);

        }
    }
}
