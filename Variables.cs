using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testRun
{
    internal class Variables
    {
        int number = 5;
        long xlNumber = 1234567890123456789L;
        float decimaltype1 = 1.01F;
        decimal decimaltype2 = 1.01M;

        public Variables() { 
            Console.WriteLine("Her kommer en liste med ulike typer variabler og dummyverdier.");
            Console.WriteLine();
            Console.WriteLine($"Int representerer heltall, eksempel {number}");
            Console.WriteLine() ;   
            Console.WriteLine($"Long representerer ekstra lange tall, eksempel {xlNumber}");
            Console.WriteLine();
            Console.WriteLine($"Float representerer desimaltype som er nøyaktig, eksempel er {decimaltype1}");
            Console.WriteLine();
            Console.WriteLine($"Decimal representerer ordinær desimaltype, eksempel er {decimaltype2}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
