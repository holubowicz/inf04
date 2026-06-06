namespace ConsoleApp
{
    internal class Program
    {
        private static readonly Random Rand = new Random();

        internal static void Main(string[] args)
        {
            int[] array = new int[50];
            PopulateArray(array);

            int target = GetUserTarget();
            int searchIndex = LinearSearchWithGuard(array, target);

            Console.WriteLine("\nTablica liczb całkowitych:");
            Console.WriteLine(string.Join(", ", array));

            Console.WriteLine();
            Console.WriteLine(searchIndex != -1
                ? $"Znaleziono element pod indeksem {searchIndex}"
                : "Nie znaleziono elementu");
        }

        private static void PopulateArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Rand.Next(1, 101);
            }
        }

        private static int GetUserTarget()
        {
            while (true)
            {
                Console.WriteLine("Podaj liczbę całkowitą z przedziału 1-100, do wyszukania: ");
                if (int.TryParse(Console.ReadLine() ?? string.Empty, out int target))
                {
                    return target;
                }
            }
        }

        /******************************************************
         nazwa funkcji: LinearSearchWithGuard
         argumenty:     array - tablica liczb całkowitych
                        target - szukana liczba
         typ zwracany:  int, indeks szukanej liczby, lub w przypadku nieznalezienia -1
         informacje:    Metoda wyszukuje podaną liczbę za pomocą wyszukiwania z wartownikiem.
         autor:         00000000000
        *****************************************************/
        private static int LinearSearchWithGuard(int[] array, int target)
        {
            if (array.Length == 0)
            {
                return -1;
            }

            int length = array.Length;
            int last = array[length - 1];

            array[length - 1] = target;

            int i = 0;
            while (array[i] != target)
            {
                i++;
            }

            array[length - 1] = last;

            if (i < length - 1 || last == target)
            {
                return i;
            }

            return -1;
        }
    }
}