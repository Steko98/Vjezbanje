using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe
{
    internal class V02CalcBMI
    {
        public static void Izvedi()
        {
            Console.WriteLine("V02CalcBMI");
            Console.Write("Weight in kg: ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Height in m: ");
            float height = float.Parse(Console.ReadLine());
            float BMI = weight / (height * height);

            if (BMI < 18.5)
            {
                double targetWeight = 18.5 * (height * height);
                Console.WriteLine("You need to gain at least {0}kg to get to healthy BMI", targetWeight-weight);
            }
            else if (BMI > 24.9)
            {
                double targetWeight = 24.9 * (height * height);
                Console.WriteLine("You need to lose at least {0}kg to get to healthy BMI", weight-targetWeight);
            }
            else
            {
                Console.WriteLine("BMI is in healthy range");
            }
        }
    }
}
