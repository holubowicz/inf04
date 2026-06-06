namespace ConsoleApp
{
    public class SelectionSort
    {
        private static readonly int ArraySize = 10;

        private int[] _array = new int[ArraySize];

        public void GetUserInput()
        {
            Console.WriteLine("Podaj tablice liczb całkowitych");

            for (int i = 0; i < ArraySize; i++)
            {
                while (true)
                {
                    Console.Write($"Podaj {i + 1} liczbe: ");
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        _array[i] = number;
                        break;
                    }
                }
            }
        }

        public void PrintArray()
        {
            Console.WriteLine("\nPosortowana tablica:");
            Console.WriteLine(string.Join(", ", _array));
        }

        /********************************************************
         * nazwa funkcji: SortDescending
         * parametry wejściowe: brak
         * wartość zwracana: brak
         * autor: 00000000000
         * ****************************************************/
        public void SortDescending()
        {
            for (int i = 0; i < ArraySize; i++)
            {
                int maxIndex = FindMaxIndex(i);

                int temp = _array[i];
                _array[i] = _array[maxIndex];
                _array[maxIndex] = temp;
            }
        }

        /********************************************************
         * nazwa funkcji: FindMaxIndex
         * parametry wejściowe: start - początkowy indeks wyszukiwania maksymalnej liczby
         * wartość zwracana: indeks największej wartości tablicy od start do końca
         * autor: 00000000000
         * ****************************************************/
        private int FindMaxIndex(int start)
        {
            int maxIndex = start;
            for (int i = start + 1; i < ArraySize; i++)
            {
                if (_array[i] > _array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}