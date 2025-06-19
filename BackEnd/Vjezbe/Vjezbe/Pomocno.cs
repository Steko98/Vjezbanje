using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe
{
    internal class Pomocno
    {
        /// <summary>
        /// Učitava i vraća string koji korisnik unese putem konzole.
        /// Ponovno traži unos dok korisnik ne unese ne-prazan string.
        /// </summary>
        /// <param name="poruka">Poruka koja se prikazuje korisniku prije unosa.</param>
        /// <returns>Uneseni string.</returns>
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

        /// <summary>
        /// Učitava cijeli broj koji korisnik unese putem konzole.
        /// Ponovno traži unos dok korisnik ne unese ispravan cijeli broj.
        /// </summary>
        /// <param name="poruka">Poruka koja se prikazuje korisniku prije unosa.</param>
        /// <returns>Uneseni cijeli broj.</returns>
        public static int UcitajCijeliBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka + ": ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Pokusajte ponovo");
                }
            }
        }

        //***********************************************************************************

        public static int[] TestLjubavi(int[] brojevi)
        {
            int minIndex = 0;
            int maxIndex = brojevi.Length - 1;
            int[] noviNiz;
            int noviNizIndex = 0;
            int suma = 0;

            if (brojevi.Length % 2 == 0)
            {
                noviNiz = new int[brojevi.Length / 2];
            }
            else
            {
                noviNiz = new int[(brojevi.Length / 2) + 1];
            }


            if (noviNiz.Length > 2)
            {
                while (minIndex < maxIndex)
                {
                    suma = brojevi[minIndex] + brojevi[maxIndex];
                    noviNiz[noviNizIndex] = suma;
                    minIndex++;
                    maxIndex--;
                    noviNizIndex++;
                }
                if (minIndex == maxIndex)
                {
                    noviNiz[noviNizIndex] = brojevi[minIndex];
                }

                return TestLjubavi(noviNiz);
            }
            string rezultat = string.Join("", noviNiz);
            Console.WriteLine("Volite se {0}%", rezultat);
            return noviNiz;

        }

        //**************************************************************************
    }
}
