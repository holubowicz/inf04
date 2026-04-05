namespace ConsoleApp;

internal static class Program
{
    internal static void Main(string[] args)
    {
        var operations = new NumberArrayOperations(50);
        
        operations.PrintAll();

        const int searchValue = 500;
        int index = operations.FindFirst(searchValue);
        if (index != -1)
            Console.WriteLine($"Znaleziono liczbę {searchValue} pod indeksem {index}");
        
        Console.WriteLine("Liczby nieparzyste:");
        int count = operations.PrintOddNumbers();
        Console.WriteLine($"Razem nieparzystych: {count}");
        
        float mean = operations.GetMean();
        Console.WriteLine($"Średnia wszystkich elementów: {mean}");
    }
}