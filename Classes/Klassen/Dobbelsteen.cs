using Microsoft.Win32.SafeHandles;

namespace Classes.Klassen
{
    public class Dobbelsteen
    {
        public string Kleur { get; set; }
        public int AantalZijden { get; set; }
        public List<int> Getallen { get; set; }
        public string Grootte { get; set; }
        public int Worp()
        {
            Random rng = new Random();
            int Zijde = rng.Next(1, AantalZijden + 1);
            return Getallen[Zijde];
        }
    }
}
