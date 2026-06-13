namespace ConsoleApp
{
    internal class Program
    {
        private static readonly int ZakresMinimum = 1;
        private static readonly int ZakresMaksimum = 49;
        private static readonly int LosowanieIloscLiczb = 6;

        private static readonly Random Rand = new Random();

        internal static void Main(string[] args)
        {
            int ilosc;
            while (true)
            {
                Console.WriteLine("Ile wygenerować losowań?");
                if (int.TryParse(Console.ReadLine() ?? string.Empty, out ilosc) && ilosc > 0)
                {
                    break;
                }
            }

            int[,] losowania = WygenerujLosowania(ilosc);
            WyswietlWyniki(losowania);
        }

        /**********************************************
        nazwa funkcji:       WygenerujLosowania
        opis funkcji:        Generuje losowania liczb pseudolosowych, ilość losowań jest determinowane podawanym argumentem funkcji.
        parametry:           ilosc - int, liczba całkowita, ilość losowań, które mają zostać wykonane
        zwracany typ i opis: int[,] - dwuwymiarowa tablica liczb całkowitych, przechowuje wyniki kilku losowań
        autor:               00000000000
        ***********************************************/
        private static int[,] WygenerujLosowania(int ilosc)
        {
            int[,] losowania = new int[ilosc, LosowanieIloscLiczb];

            for (int i = 0; i < ilosc; i++)
            {
                HashSet<int> wiersz = new HashSet<int>();
                while (wiersz.Count != LosowanieIloscLiczb)
                {
                    wiersz.Add(Rand.Next(ZakresMinimum, ZakresMaksimum + 1));
                }

                for (int j = 0; j < LosowanieIloscLiczb; j++)
                {
                    losowania[i, j] = wiersz.ElementAt(j);
                }
            }

            return losowania;
        }

        private static void WyswietlWyniki(int[,] losowania)
        {
            Console.WriteLine("Zestawy wylosowanych liczb:");

            for (int i = 0; i < losowania.GetLength(0); i++)
            {
                Console.Write($"Losowanie {i + 1}:");
                for (int j = 0; j < LosowanieIloscLiczb; j++)
                {
                    Console.Write($" {losowania[i, j]}");
                }

                Console.WriteLine();
            }

            int[] wystapienia = new int[ZakresMaksimum + 1];
            foreach (int liczba in losowania)
            {
                wystapienia[liczba]++;
            }

            for (int i = ZakresMinimum; i <= ZakresMaksimum; i++)
            {
                Console.WriteLine($"Wystąpienia liczby {i}: {wystapienia[i]}");
            }
        }
    }
}