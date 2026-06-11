namespace ConsoleApp
{
    internal class Program
    {
        private static readonly Random Rand = new Random();

        internal static void Main(string[] args)
        {
            while (true)
            {
                int count = InputDiceCount();
                int[] rolls = GenerateDiceRolls(count);
                int score = CalculateScore(rolls);

                PrintDiceRolls(rolls);
                Console.WriteLine($"Liczba uzyskanych punktów: {score}");

                Console.WriteLine("Jeszcze raz? (t/n)");
                string input = (Console.ReadLine() ?? string.Empty).ToLower();
                if (input == "n")
                {
                    break;
                }
            }
        }

        private static int InputDiceCount()
        {
            while (true)
            {
                Console.WriteLine("Ile kostek chcesz rzucić? (3 - 10)");
                string input = Console.ReadLine() ?? string.Empty;
                if (int.TryParse(input, out int number) && number >= 3 && number <= 10)
                {
                    return number;
                }
            }
        }

        /************************************************
          nazwa:               GenerateDiceRolls
          opis:                Generuje wyrzucenia kości, ilość kości jest podana jako argument.
          parametry:           count - int, liczba całkowita, ilość kostek, które mają być "rzucone"
          zwracany typ i opis: int[], tablica liczba całkowitych, wygenerowanie wyrzucenia kości
          autor:               00000000000
        ************************************************/
        private static int[] GenerateDiceRolls(int count)
        {
            int[] rolls = new int[count];
            for (int i = 0; i < count; i++)
            {
                rolls[i] = Rand.Next(1, 7);
            }

            return rolls;
        }

        private static int CalculateScore(int[] rolls)
        {
            int[] counts = new int[7];
            foreach (int value in rolls)
            {
                counts[value]++;
            }

            int score = 0;
            for (int i = 1; i <= 6; i++)
            {
                int count = counts[i];
                if (count >= 2)
                {
                    score += i * count;
                }
            }

            return score;
        }

        private static void PrintDiceRolls(int[] rolls)
        {
            for (int i = 0; i < rolls.Length; i++)
            {
                Console.WriteLine($"Kostka {i + 1}: {rolls[i]}");
            }
        }
    }
}