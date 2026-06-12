namespace ConsoleApp
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            RandomArray randomArray = new RandomArray(50);
            
            randomArray.PrintArray();

            int key = 102;
            int index = randomArray.FindElement(key);
            if (index != -1)
            {
                Console.WriteLine($"Liczba {key} została znaleziono pod indeksem {index}");
            }

            int oddNumbersCount = randomArray.OddNumbers();
            Console.WriteLine($"Razem nieparzystych: {oddNumbersCount}");

            double average = randomArray.Average();
            Console.WriteLine($"Średnia wszystkich elementów: {average}");
        }
    }
}