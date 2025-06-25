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
        //***********************************************************************************************************************
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
        //***********************************************************************************************************************
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
                    Console.WriteLine("Potrebno je unijeti broj znamenkom. Pokušajte ponovno.");
                }
            }
        }
        /// <summary>
        /// Učitava i vraća bool vrijednost na temelju korisničkog unosa.
        /// Korisniku se prikazuje poruka s opcijama '1 za DA' ili '2 za NE'.
        /// Ponovno traži unos dok korisnik ne unese ispravan broj (1 ili 2).
        /// </summary>
        /// <param name="poruka">Poruka koja se prikazuje korisniku prije unosa.</param>
        /// <returns>True ako korisnik unese 1 (DA), false ako unese 2 (NE).</returns>
        public static bool UcitajBool(string poruka)
        {
            while (true)
            {
                Console.Write(poruka + " (1 za DA ili 2 za NE): ");
                int odabir = 0;

                for (; ; )
                {
                    try
                    {
                        odabir = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Nevažeći unos. Pokušajte ponovno.");
                    }
                }
                if (odabir == 1)
                {
                    return true;
                }
                else if (odabir == 2)
                {
                    return false;
                }
                else
                {
                    Console.Write("Nevažeći unos. Molimo unesite '1' za DA ili '2' za NE. Pokušajte ponovo: ");
                    odabir = int.Parse(Console.ReadLine());
                }
            }
        }
        //***********************************************************************************************************************
    }
}
