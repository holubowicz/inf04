namespace ConsoleApp;

internal static class Program
{
    internal static void Main(string[] args)
    {
        var film = new Film();
        
        Console.WriteLine($"Początkowy tytuł: {film.PobierzTytul()}");
        Console.WriteLine($"Początkowa liczba wypożyczeń: {film.PobierzLiczbaWypozyczen()}");
        
        film.UstawTytul("Szybcy i wściekli");
        
        Console.WriteLine($"Tytuł: {film.PobierzTytul()}");
        Console.WriteLine($"Liczba wypożyczeń: {film.PobierzLiczbaWypozyczen()}");
        
        Console.WriteLine($"Liczb wypożyczeń przed inkrementacją: {film.PobierzLiczbaWypozyczen()}");
        film.InkrementujLiczbaWypozyczen();
        Console.WriteLine($"Liczb wypożyczeń po inkrementacji: {film.PobierzLiczbaWypozyczen()}");
    }
}