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
        double decimaltype3 = 1.01;
        string text = "String";
        char letter = 'A';
        bool trueFalse = true;

        public void RunVariablesCode() { 
            Console.WriteLine("Her kommer en liste med ulike typer variabler og dummyverdier.");
            Console.WriteLine();
            Console.WriteLine($"Int representerer heltall, eksempel {this.number}");
            Console.WriteLine() ;   
            Console.WriteLine($"Long representerer ekstra lange tall, eksempel {this.xlNumber}");
            Console.WriteLine();
            Console.WriteLine($"Float representerer desimaltype som er nøyaktig, eksempel er {this.decimaltype1}");
            Console.WriteLine();
            Console.WriteLine($"Decimal representerer ordinær desimaltype, eksempel er {this.decimaltype2}");
            Console.WriteLine();
            Console.WriteLine($"Double representerer desimaltall med to tall etter komma, eksempelvis {this.decimaltype3}");
            Console.WriteLine();
            Console.WriteLine($@"String representerer tekst, om det er en setning eller et ord, et eksempel er {this.text}");
            Console.WriteLine();
            Console.WriteLine($"Char representerer en bokstav, eksempelvis {this.letter}");
            Console.WriteLine();
            Console.WriteLine($@"Bool representerer True eller False, eksempelvis {this.trueFalse}");
        }
    }
}
