using System;
using System.Collections.Generic;
using System.Linq;
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
        /// Provjerava je li zadani string moguće pretvoriti u cijeli broj (int).
        /// </summary>
        /// <param name="s">String za provjeru.</param>
        /// <returns>True ako je string cijeli broj, inače false.</returns>
        public static bool IsCijeliBroj(string s)
        {
            try
            {
                int.Parse(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Učitava cijeli broj koji korisnik unese putem konzole.
        /// Ponovno traži unos dok korisnik ne unese ispravan cijeli broj.
        /// </summary>
        /// <param name="poruka">Poruka koja se prikazuje korisniku prije unosa.</param>
        /// <returns>Uneseni cijeli broj.</returns>
        public static int ucitajCijeliBroj(string poruka)
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
    }
}
