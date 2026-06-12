namespace ConsoleApp
{
    public class RandomArray
    {
        private static readonly Random Rand = new Random();

        private int[] _array;
        private int _size;

        public RandomArray(int size)
        {
            _size = size;
            _array = new int[_size];

            for (int i = 0; i < _size; i++)
            {
                _array[i] = Rand.Next(1, 1001);
            }
        }

        /**********************************************
        nazwa metody:        PrintArray
        opis metody:         Wyświetla wszystkie elementy tablicy z ich indeksem.
        parametry:           brak
        zwracany typ i opis: brak
        autor:               00000000000
        ***********************************************/
        public void PrintArray()
        {
            Console.WriteLine("Wszystkie elementy tablicy:");
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine($"{i}. {_array[i]}");
            }
        }

        public int FindElement(int key)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_array[i] == key)
                {
                    return i;
                }
            }

            return -1;
        }

        public int OddNumbers()
        {
            int[] oddNumbers = _array.Where(number => number % 2 != 0).ToArray();

            Console.WriteLine("Liczby nieparzyste:");
            foreach (int number in oddNumbers)
            {
                Console.WriteLine(number);
            }

            return oddNumbers.Length;
        }

        public double Average()
        {
            return _array.Average();
        }
    }
}