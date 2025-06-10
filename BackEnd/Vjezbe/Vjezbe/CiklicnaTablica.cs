using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe
{
    internal class CiklicnaTablica
    {
        public static void Izvedi()
        {
            Console.WriteLine("CiklicnaTablica");

            Console.Write("Broj redaka: ");
            int redak = int.Parse(Console.ReadLine());
            Console.Write("Broj stupaca: ");
            int stupac = int.Parse(Console.ReadLine());

            int ukupnoBrojeva = redak * stupac;

            for (int i = redak; i > 0; i--)
            {
                for (int j = stupac; j > 0; j--)
                {
                    Console.Write(ukupnoBrojeva--);

                }
                Console.WriteLine();
            }
        }
    }
}
