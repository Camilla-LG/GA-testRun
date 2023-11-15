using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testRun
{
    internal class MathSolutions
    {

        public static decimal SumOfNumbers()
        {
            Console.WriteLine("Skriv inn det første tallet.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv inn det andre tallet med desimaler.");
            decimal number2 = Convert.ToDecimal(Console.ReadLine());

            decimal sum = number1 + number2;
            return sum;
        }



    }
}
