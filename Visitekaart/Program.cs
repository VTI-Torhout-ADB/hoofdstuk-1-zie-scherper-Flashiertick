namespace Visitekaart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je voornaam ?");
            string voornaam = Console.ReadLine();
            Console.WriteLine("Wat is je achternaam ?");
            string achternaam = Console.ReadLine();
            Console.WriteLine("Waar woon je ?");
            string woonplaats = Console.ReadLine();
            Console.WriteLine("Wat is je hobby ?");
            string hobby = Console.ReadLine();

            Console.WriteLine("Goed, Hier volgt je visitekaartje.");
            Console.WriteLine("naam: " + voornaam);
            Console.WriteLine("achternaam: " + achternaam);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("woonplaats: " + woonplaats);
            Console.ResetColor();
            Console.WriteLine("hobby: " + hobby);
        }
    }
}
