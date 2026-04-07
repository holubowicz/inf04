namespace ConsoleApp;

internal static class Program
{
    internal static void Main(string[] args)
    {
        var film = new Film();
        
        Console.WriteLine($"Początkowy tytuł: {film.GetTitle()}");
        Console.WriteLine($"Początkowa liczba wypożyczeń: {film.GetBorrowsCount()}");
        
        film.SetTitle("Szybcy i wściekli");
        
        Console.WriteLine($"Tytuł: {film.GetTitle()}");
        Console.WriteLine($"Liczba wypożyczeń: {film.GetBorrowsCount()}");
        
        Console.WriteLine($"Liczb wypożyczeń przed inkrementacją: {film.GetBorrowsCount()}");
        film.IncrementBorrowsCount();
        Console.WriteLine($"Liczb wypożyczeń po inkrementacji: {film.GetBorrowsCount()}");
    }
}