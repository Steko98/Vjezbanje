using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe
{
    internal class GeneratorLozinki
    {
        public static void Izvedi()
        {
            string velikaSlova = "ABCČĆDĐEFGHIJKLMNOPQRSŠTUVWXYZŽ";
            string malaSlova = velikaSlova.ToLower();
            string brojevi = "0123456789";
            string interpunkcijski = "!@#$%^&*()_+-=[]{}|;':\",.<>/?`~";

            int duzinaLozinke = Pomocno.UcitajCijeliBroj("Unesite dužinu lozinke");

            while (duzinaLozinke <8 || duzinaLozinke > 64)
            {
                Console.WriteLine("Lozinka može imati izneđu 8 i 64 znaka");
                duzinaLozinke = Pomocno.UcitajCijeliBroj("Ponovno unesite dužinu lozinke");
            }

            bool velikaSlovaOdabir = Pomocno.UcitajBool("Uključena velika slova u lozinci?");
            bool malaSlovaOdabir = Pomocno.UcitajBool("Uključena mala slova u lozinci?");
            bool brojeviOdabir = Pomocno.UcitajBool("Uključeni brojevi u lozinci?");
            bool interpunkcijskiOdabir = Pomocno.UcitajBool("Uključeni interpunkcijski znakovi?");

            while (!velikaSlovaOdabir && !malaSlovaOdabir && !brojeviOdabir && !interpunkcijskiOdabir)
            {
                Console.WriteLine("Lozinka mora imati barem jedno od navedenog.");
                velikaSlovaOdabir = Pomocno.UcitajBool("Uključena velika slova u lozinci?");
                malaSlovaOdabir = Pomocno.UcitajBool("Uključena mala slova u lozinci?");
                brojeviOdabir = Pomocno.UcitajBool("Uključeni brojevi u lozinci?");
                interpunkcijskiOdabir = Pomocno.UcitajBool("Uključeni interpunkcijski znakovi?");
            }

            string sviZnakovi = "";

            if (velikaSlovaOdabir)
            {
                sviZnakovi += velikaSlova;
            }
            if (malaSlovaOdabir)
            {
                sviZnakovi += malaSlova;
            }
            if (brojeviOdabir)
            {
                sviZnakovi += brojevi;
            }
            if (interpunkcijskiOdabir)
            {
                sviZnakovi += interpunkcijski;
            }

            bool pocetakBroj;
            bool pocetakZnak;

            if (!brojeviOdabir)
            {
                pocetakBroj = false;
            }
            else
            {
            pocetakBroj = Pomocno.UcitajBool("Lozinka počinje brojem?");
            }
            if (!interpunkcijskiOdabir)
            {
                pocetakZnak = false;
            }
            else
            {
                pocetakZnak = Pomocno.UcitajBool("Lozinka počinje interpunkcijskim znakom?");
            }

            while (pocetakBroj && pocetakZnak)
            {
                Console.WriteLine("Prvi znak lozinke ne može istovremeno biti i interpunkcijski znak i broj.");
                pocetakBroj = Pomocno.UcitajBool("Lozinka počinje brojem?");
                if (pocetakBroj)
                {
                    pocetakZnak = false;
                } else if (!pocetakBroj)
                {
                    pocetakZnak = Pomocno.UcitajBool("Lozinka počinje interpunkcijskim znakom?");
                }
            }

            bool krajBroj;
            bool krajZnak;

            if (!brojeviOdabir)
            {
                krajBroj = false;
            }
            else
            {
                krajBroj = Pomocno.UcitajBool("Lozinka završava s brojem?");
            }
            if (!interpunkcijskiOdabir)
            {
                krajZnak = false;
            }
            else
            {
                krajZnak = Pomocno.UcitajBool("Lozinka završava s interpunkcijskim znakom?");
            }

            while (krajBroj && krajZnak)
            {
                Console.WriteLine("Posljednji znak lozinke ne može istovremeno biti i interpunkcijski znak i broj.");
                krajBroj = Pomocno.UcitajBool("Lozinka završava brojem?");
                if (krajBroj)
                {
                    krajZnak = false;
                }
                else if (!krajBroj)
                {
                    krajZnak = Pomocno.UcitajBool("Lozinka završava interpunkcijskim znakom?");
                }
            }
            bool ponavljanje;

            if (duzinaLozinke > sviZnakovi.Length)
            {
                ponavljanje = true;
            } else
            {
                ponavljanje = Pomocno.UcitajBool("Dopustiti ponavljanje znakova u lozinci?");
            }

            int brojLozinki = Pomocno.UcitajCijeliBroj("Unesite broj lozinki koje želite");

            Random broj = new Random();
            int nekiIndex;
            int nekiDrugiIndex;
            
            for (int i = 0; i < brojLozinki; i++)
            {
                char[] lozinka = new char[duzinaLozinke];
                char[] iskoristeniZnakovi = new char[duzinaLozinke];

                List<int> slobodniIndexi = new List<int>();
                for (int j = 0; j < duzinaLozinke; j++)
                {
                    slobodniIndexi.Add(j);
                }

                if (pocetakBroj)
                {
                    nekiIndex = broj.Next(0, brojevi.Length);
                    lozinka[0] = brojevi[nekiIndex];
                    iskoristeniZnakovi[0] = brojevi[nekiIndex];
                    slobodniIndexi.Remove(0);
                } else if (pocetakZnak)
                {
                    nekiIndex = broj.Next(0, interpunkcijski.Length);
                    lozinka[0] = interpunkcijski[nekiIndex];
                    iskoristeniZnakovi[0] = interpunkcijski[nekiIndex];
                    slobodniIndexi.Remove(0);
                }

                if (krajBroj)
                {
                    nekiIndex = broj.Next(0, brojevi.Length);
                    lozinka[duzinaLozinke-1] = brojevi[nekiIndex];
                    slobodniIndexi.Remove(duzinaLozinke - 1);
                } else if (krajZnak)
                {
                    nekiIndex = broj.Next(0, interpunkcijski.Length);
                    lozinka[duzinaLozinke - 1] = interpunkcijski[nekiIndex];
                    slobodniIndexi.Remove(duzinaLozinke - 1);
                }

                if (velikaSlovaOdabir)
                {
                    nekiIndex = broj.Next(slobodniIndexi.Count);
                    nekiDrugiIndex = broj.Next(0, velikaSlova.Length);
                    lozinka[slobodniIndexi[nekiIndex]] = velikaSlova[nekiDrugiIndex];
                    slobodniIndexi.RemoveAt(nekiIndex);
                }
                if (malaSlovaOdabir)
                {
                    nekiIndex = broj.Next(slobodniIndexi.Count);
                    nekiDrugiIndex = broj.Next(0, malaSlova.Length);
                    lozinka[slobodniIndexi[nekiIndex]] = malaSlova[nekiDrugiIndex];
                    slobodniIndexi.RemoveAt(nekiIndex);
                }
                if (brojeviOdabir)
                {
                    nekiIndex = broj.Next(slobodniIndexi.Count);
                    nekiDrugiIndex = broj.Next(0, brojevi.Length);
                    lozinka[slobodniIndexi[nekiIndex]] = brojevi[nekiDrugiIndex];
                    slobodniIndexi.RemoveAt(nekiIndex);
                }
                if (interpunkcijskiOdabir)
                {
                    nekiIndex = broj.Next(slobodniIndexi.Count);
                    nekiDrugiIndex = broj.Next(0, interpunkcijski.Length);
                    lozinka[slobodniIndexi[nekiIndex]] = interpunkcijski[nekiDrugiIndex];
                    slobodniIndexi.RemoveAt(nekiIndex);
                }

                foreach (int index in slobodniIndexi)
                {
                    nekiIndex = broj.Next(0, sviZnakovi.Length);
                    lozinka[index] = sviZnakovi[nekiIndex];
                }

                Console.WriteLine(string.Join("", lozinka));

            }

        }
    }
}
