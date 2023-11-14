namespace testRun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei! Hva heter du?");
            var nameInput = Console.ReadLine();
            Console.WriteLine($"Hei, {nameInput}");
            Console.WriteLine("Hvis du går til Variables.cs, så vil du finne oversikt over ulike variabler.");
        }
    }
}