namespace ConsoleApp
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst:");
            string input = Console.ReadLine() ?? string.Empty;
            
            Console.WriteLine();
            Console.WriteLine($"Liczba samogłosek: {StringUtility.CountVowels(input)}");
            Console.WriteLine("Tekst bez powtórzeń:");
            Console.WriteLine(StringUtility.RemoveDuplicates(input));
        }
    }
}