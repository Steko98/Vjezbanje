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

            string prvaOsoba = UcitajString("Unesi ime prve osobe");
            string drugaOsoba = UcitajString("Unesi ime druge osobe");

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

            TestLjubavi(kolicinaZnakova);

        }

        public static int[] TestLjubavi(int[] brojevi)
        {
            int noviNizDuzina = 0;
            int minIndexZaRacunanje = 0;
            int maxIndexZaRacunanje = brojevi.Length - 1;

            while (minIndexZaRacunanje < maxIndexZaRacunanje)
            {
                int sumarum = brojevi[minIndexZaRacunanje] + brojevi[maxIndexZaRacunanje];
                if ( sumarum > 9)
                {
                    noviNizDuzina += 2;
                }
                else
                {
                    noviNizDuzina += 1;
                }
                minIndexZaRacunanje++;
                maxIndexZaRacunanje--;
            }

            if (minIndexZaRacunanje == maxIndexZaRacunanje)
            {
                noviNizDuzina++;
            }

            int[] niz = new int[brojevi.Length];
            int suma = 0;
            int minIndex = 0;
            int maxIndex = niz.Length - 1;
            int noviNizIndex = 0;

            int[] noviNiz = new int[noviNizDuzina];

            while (minIndex < maxIndex)
            {

                suma = brojevi[minIndex] + brojevi[maxIndex];
                if (suma >= 10)
                {
                    string sumaUString = suma.ToString();

                    foreach (char znak in sumaUString)
                    {
                        int uBroj = (int)char.GetNumericValue(znak);
                        noviNiz[noviNizIndex] = uBroj;
                        noviNizIndex++;
                    }
                }
                else
                {
                    noviNiz[noviNizIndex] = suma;
                    noviNizIndex++;
                }

                minIndex++;
                maxIndex--;
            }

            if (minIndex == maxIndex)
            {
                noviNiz[noviNizIndex] = brojevi[minIndex];
            }

            if (noviNiz.Length > 2)
            {
                Console.WriteLine("{0}", string.Join(",", noviNiz));
                return TestLjubavi(noviNiz);
            }

            string rezultat = string.Join("", noviNiz);
            Console.WriteLine("Imate {0}% šanse razviti ljubav", rezultat);
            return noviNiz;
        }

        public static string UcitajString(string poruka)
        {
            string s;
            for (; ; )
            {
                Console.Write(poruka + ": ");
                s = Console.ReadLine().Trim();
                if (s.Length > 0)
                {
                    return s;
                }
                Console.WriteLine("Obavezan unos!");
            }
        }
    }
}
