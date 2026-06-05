namespace ConsoleApp
{
    internal class Program
    {
        private static readonly int _arraySize = 10;
        private static int[] _array = new int[_arraySize];
        
        internal static void Main(string[] args)
        {
            GetUserInput();
            SelectionSort();
            PrintArray();
        }

        /********************************************************
        * nazwa funkcji: SelectionSort
        * parametry wejściowe: brak
        * wartość zwracana: brak
        * autor: 00000000000
        * ****************************************************/
        private static void SelectionSort()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                int maxIndex = FindMaxIndex(i);
                
                int temp = _array[i];
                _array[i] = _array[maxIndex];
                _array[maxIndex] = temp;
            }
        }

        /********************************************************
         * nazwa funkcji: FindMaxIndex
         * parametry wejściowe: startIndex - początkowy indeks wyszukiwania maksymalnej liczby
         * wartość zwracana: brak
         * autor: 00000000000
         * ****************************************************/
        private static int FindMaxIndex(int startIndex)
        {
            int maxIndex = startIndex;
            for (int i = startIndex + 1; i < _array.Length; i++)
            {
                if (_array[i] > _array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private static void GetUserInput()
        {
            Console.WriteLine("Podaj tablice liczb całkowitych");

            for (int i = 0; i < _arraySize; i++)
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

        private static void PrintArray()
        {
            Console.WriteLine("\nPosortowana tablica:");
            for (int i = 0; i < _arraySize; i++)
            {
                Console.WriteLine($"{i + 1}. {_array[i]}");
            }
        }
    }
}
