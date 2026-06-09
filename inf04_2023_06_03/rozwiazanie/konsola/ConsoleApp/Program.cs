namespace ConsoleApp
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Film film = new Film();
            
            film.SetTitle("Bee Movie");
            Console.WriteLine(film.GetTitle());
            
            Console.WriteLine($"Liczba wypożyczeń przed wypożyczeniem: {film.GetRentalsCount()}");
            film.IncrementRentalsCount();
            Console.WriteLine($"Liczba wypożyczeń po wypożyczeniu: {film.GetRentalsCount()}");
        }
    }
}