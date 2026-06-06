namespace ConsoleApp
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.LiczbaInstancji}");

            Osoba osoba1 = new Osoba();
            Osoba osoba2 = new Osoba(1, "Michał");
            Osoba osoba3 = new Osoba(osoba2);

            osoba1.PrzywitajSie("Jan");
            osoba2.PrzywitajSie("Jan");
            osoba3.PrzywitajSie("Jan");

            Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.LiczbaInstancji}");
        }
    }
}