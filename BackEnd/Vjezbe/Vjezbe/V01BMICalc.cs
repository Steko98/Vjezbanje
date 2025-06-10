using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe
{
    internal class V01BMICalc
    {
        public static void Izvedi()
        {
            Console.WriteLine("V01BMICalc");
            Console.Write("Weight in kg: ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Height in m: ");
            float height = float.Parse(Console.ReadLine());
            float BMI = weight / (height * height);
            if (BMI < 18.5)
            {
                Console.WriteLine("BMI is {0} - underweight", BMI);
            } else if (BMI>24.9 && BMI < 30)
            {
                Console.WriteLine("BMI is {0} - overweight.", BMI);
            } else if (BMI > 30)
            {
                Console.WriteLine("BMI is {0} - obese.", BMI);
            } else
            {
                Console.WriteLine("BMI is {0} - healthy weight", BMI);
            };
        }
    }
}
