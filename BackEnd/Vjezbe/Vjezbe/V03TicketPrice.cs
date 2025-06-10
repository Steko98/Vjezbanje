using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Vjezbe
{
    internal class V03TicketPrice
    {
        public static void Izvedi()
        {
            Console.WriteLine("V03TicketPrice");

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter day of the week: ");
            string dayOfWeek = Console.ReadLine();
            Console.Write("Are you a student (Yes/No): ");
            string student = Console.ReadLine();

            double basePrice = 12.50;
            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                basePrice = basePrice + 5;
            }

            if (age <= 5)
            {
                Console.WriteLine("Your ticket is free!");
            } else if (age > 64)
            {
                    Console.WriteLine("Your ticket price is ${0}", basePrice * 0.80);
            } else
            {
                if (student == "Yes")
                {
                    Console.WriteLine("Your ticket price is ${0}", basePrice * 0.80);
                } else
                {
                    Console.WriteLine("Your ticket price is ${0}", basePrice);
                }
            }
        }
    }
}
