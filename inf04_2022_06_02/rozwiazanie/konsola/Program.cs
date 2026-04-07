namespace ConsoleApp;

internal static class Program
{
    internal static void Main(string[] args)
    {
        Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.LiczbaInstancji}");
        
        var osoba1 = new Osoba();

        int id;
        while (true)
        {
            Console.Write("Podaj identyfikator osoby (np. 12): ");
            if (int.TryParse(Console.ReadLine() ?? string.Empty, out id))
                break;
        }

        string imie = null;
        while (string.IsNullOrEmpty(imie))
        {
            Console.Write("Podaj imie osoby: ");
            imie = Console.ReadLine() ?? string.Empty;
        }
        
        var osoba2 = new Osoba(id, imie);
        var osoba3 = new Osoba(osoba2);
        
        osoba1.Przywitanie("Jan");
        osoba2.Przywitanie("Jan");
        osoba3.Przywitanie("Jan");
        
        Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.LiczbaInstancji}");
    }
}