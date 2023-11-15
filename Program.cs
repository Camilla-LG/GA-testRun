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


            Console.WriteLine();
            decimal sumResult = MathSolutions.SumOfNumbers();
            Console.WriteLine($"Summen av tallene er {sumResult}.");

            Console.WriteLine();
            Console.WriteLine("Hei! Hva var det du het igjen?");
            var Username = Console.ReadLine();
            string hobbyResult = RandomHelper.HowToUseRandom();
            Console.WriteLine($"{Username} er visst blitt {hobbyResult}");
        }
    }
}