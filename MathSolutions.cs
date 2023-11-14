using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testRun
{
    internal class MathSolutions
    {

        public static int SumOfNumbers()
        {
            Console.WriteLine("Skriv inn det første tallet.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv inn det andre tallet.");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            return sum;
        }



    }
}
