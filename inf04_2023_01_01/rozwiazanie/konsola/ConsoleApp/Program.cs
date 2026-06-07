namespace ConsoleApp
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Algorytm Euklidesa (NWD)");

            int a = InputNumber("Podaj pierwszą liczbe (a): ");
            int b = InputNumber("Podaj drugą liczbe (b): ");

            int gcd = GreatestCommonDivisor(a, b);

            Console.WriteLine($"\nNajwiększy wspólny dzielnik wynosi: {gcd}");
        }

        /**********************************************
        nazwa funkcji:       GreatestCommonDivisor
        opis funkcji:        Sprawdzanie największego wspólnego dzielnika dla podanych liczb.
        parametry:           a - int, liczba całkowita, pierwsza liczba algorytmu Euklidesa
                             b - int, liczba całkowita, druga liczba algorytmu Euklidesa
        zwracany typ i opis: int, największy wspólny dzielnik obu liczb
        autor:               00000000000
        ***********************************************/
        private static int GreatestCommonDivisor(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return a;
        }

        private static int InputNumber(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine() ?? string.Empty, out int number))
                {
                    return number;
                }
            }
        }
    }
}