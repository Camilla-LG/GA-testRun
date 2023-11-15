namespace testRun
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hei! Hva heter du?");
            var nameInput = Console.ReadLine();
            Console.WriteLine($"Hei, {nameInput}");
            Console.WriteLine("Hvis du går til Variables.cs, så vil du finne oversikt over ulike variabler.");
            Console.WriteLine("Ellers så vil du få eksempler her.");
            Console.WriteLine();
            Variables variablesInstance = new Variables();
            variablesInstance.RunVariablesCode();

            Console.WriteLine("Hei! Hva heter du?");
            var Username = Console.ReadLine();
            Random rand = new Random();
            var hobbyResult = rand.Next(hobbies);
            Console.WriteLine($"{Username} er visst blitt {hobbyResult}");

            Console.WriteLine();
            decimal sumResult = MathSolutions.SumOfNumbers();
            Console.WriteLine($"Summen av tallene er {sumResult}.");
        }
    }
}