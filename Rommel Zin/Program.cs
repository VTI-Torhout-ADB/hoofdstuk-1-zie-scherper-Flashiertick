namespace Rommel_Zin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je favoriete kleur ?");
            string kleur = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete eten ?");
            string eten = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete automerk ?");
            string automerk = Console.ReadLine();

            Console.WriteLine("dus je favoriete kleur is " + eten + " en je favoriete eten " + automerk + " en je favoriete automerk " + kleur);

        }
    }
}
