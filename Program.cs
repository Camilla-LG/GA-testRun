namespace testRun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei! Hva heter du?");
            var nameInput = Console.ReadLine();
            Console.WriteLine($"Hei, {nameInput}");
            Console.WriteLine("Her kommer en liste med ulike typer variabler og dummyverdier.");
            Console.WriteLine();
            int number = 5;
            Console.WriteLine($"Int representerer heltall, eksempel {number}");
            Console.WriteLine() ;   
            long xlNumber = 1234567890123456789L;
            Console.WriteLine($"Long representerer ekstra lange tall, eksempel {xlNumber}");
            Console.WriteLine();
            float decimaltype1 = 1,01F;
            Console.WriteLine($"Float representerer desimaltype som er nøyaktig, eksempel er {decimaltype1}");


        }
    }
}