using Classes.Klassen;

namespace Classes
{
    internal class Program
    {
        static void Main()
        {
            Dobbelsteen dobbelsteen1 = new Dobbelsteen();
            dobbelsteen1.Kleur = "Doorzichtig geel";
            dobbelsteen1.AantalZijden = 10;
            dobbelsteen1.Getallen = new List<int> { 00, 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            dobbelsteen1.Grootte = "Normaal";

            Dobbelsteen dobbelsteen2 = new Dobbelsteen();
            dobbelsteen2.Kleur = "Grijs met zwarte spikkels";
            dobbelsteen2.AantalZijden = 4;
            dobbelsteen2.Getallen = new List<int> { 1, 2, 3, 4 };
            dobbelsteen2.Grootte = "Normal";

            Console.WriteLine($"Dobbelsteen 1:");
            Console.WriteLine($"Aantalzijden: {dobbelsteen1.AantalZijden}");
            Console.WriteLine($"Kleur: {dobbelsteen1.Kleur}");
            Console.WriteLine("Getallen:");
            foreach (int getal in dobbelsteen1.Getallen)
            {
                Console.WriteLine($"{getal}");
            }
            Console.WriteLine($"Dobbelsteen grootte: {dobbelsteen1.Grootte}");

            Console.WriteLine($"\nDobbelsteen 2:");
            Console.WriteLine($"Aantalzijden: {dobbelsteen2.AantalZijden}");
            Console.WriteLine($"Kleur: {dobbelsteen2.Kleur}");
            Console.WriteLine("Getallen:");
            foreach (int getal in dobbelsteen2.Getallen)
            {
                Console.WriteLine($"{getal}");
            }
            Console.WriteLine($"Dobbelsteen grootte: {dobbelsteen2.Grootte}");
        }
    }
}
