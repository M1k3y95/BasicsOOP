using System;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational_Number rNumber1 = new(2, 3);
            Rational_Number rNumber2 = new(3, 5);

            Rational_Number rNumber3 = rNumber1 * rNumber2;
            Console.WriteLine(rNumber3.ToString());

            rNumber3 = rNumber1 / rNumber2;
            Console.WriteLine(rNumber3.ToString());

            rNumber3 = rNumber1 + rNumber2;
            Console.WriteLine(rNumber3.ToString());

            rNumber3++;
            Console.WriteLine(rNumber3.ToString());

            float something = (float)rNumber3;
            Console.WriteLine(something);

            int somethingtoo = (int)rNumber2;
            Console.WriteLine(somethingtoo);
        }
    }
}
