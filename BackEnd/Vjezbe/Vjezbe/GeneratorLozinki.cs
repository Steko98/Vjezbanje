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
            else if (malaSlovaOdabir)
            {
                sviZnakovi += malaSlova;
            }
            else if (brojeviOdabir)
            {
                sviZnakovi += brojevi;
            }
            else if (interpunkcijskiOdabir)
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
                ponavljanje = Pomocno.UcitajBool("Lozinka ima ponavljajuće znakove?");
            }

            int brojLozinki = Pomocno.UcitajCijeliBroj("Unesite broj lozinki koje želite");
            
            for (int i = 0; i < brojLozinki; i++) //generira broj lozinki
            {
                
            }

        }
    }
}
