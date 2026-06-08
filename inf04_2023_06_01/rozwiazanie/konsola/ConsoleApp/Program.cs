namespace ConsoleApp
{
    internal class Program
    {
        private static readonly int RangeStart = 2;
        private static readonly int RangeEnd = 100;

        internal static void Main(string[] args)
        {
            bool[] array = new bool[RangeEnd + 1];
            PopulateArray(array);

            int n = (int)Math.Sqrt(RangeEnd);
            for (int i = RangeStart; i <= n; i++)
            {
                if (!array[i])
                {
                    continue;
                }

                for (int j = RangeStart * i; j <= RangeEnd; j += i)
                {
                    array[j] = false;
                }
            }
            
            Console.WriteLine("Wszystkie liczby pierwsze:");
            for (int i = RangeStart; i <= RangeEnd; i++)
            {
                if (array[i])
                {
                    Console.Write(i + " ");
                }
            }
        }

        /*******************************************************
         nazwa funkcji:       PopulateArray
         parametry wejściowe: array - tablica wartości typu logicznego, czy indeks jest liczbą pierwszą
         wartość zwracana:    brak
         informacje:          Wypełnia tablicę wartościami true, od indeksu 2 do 100, co oznacza, że te liczby
                              mogą być pierwsze.
         autor:               00000000000
        ****************************************************/
        private static void PopulateArray(bool[] array)
        {
            for (int i = RangeStart; i <= RangeEnd; i++)
            {
                array[i] = true;
            }
        }
    }
}