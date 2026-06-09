namespace ConsoleApp
{
    internal class Program
    {
        private static readonly int RangeStart = 0;
        private static readonly int RangeEnd = 1000;
        private static readonly int ArraySize = 100;

        private static readonly Random Rand = new Random();

        internal static void Main(string[] args)
        {
            int[] array = new int[ArraySize];
            PopulateArray(array);

            BubbleSort(array);

            Console.WriteLine("Posortowana tablica liczb całkowitych:");
            Console.WriteLine(string.Join(", ", array));
        }

        private static void PopulateArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Rand.Next(RangeStart, RangeEnd + 1);
            }
        }

        private static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}