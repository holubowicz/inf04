using System.Text;

namespace ConsoleApp
{
    /************************************************
     klasa:  StringUtility
     opis:   Służy do przetrzymywania pomocnych metod dla typu ciagu znaków (string).
     metody: CountVowels - int, liczba całkowita, liczba samogłosek w tekście
             RemoveDuplicates - string, ciąg znaków, zwraca tekst, w którym zostały usunięte powtarzające się znaki koło siebie
     autor:  00000000000
    ************************************************/
    public static class StringUtility
    {
        private static readonly string Vowels = "aąeęiouóyAĄEĘIOUÓY";
        
        public static int CountVowels(string input)
        {
            return string.IsNullOrEmpty(input) ? 0 : input.Count(c => Vowels.Contains(c));
        }

        public static string RemoveDuplicates(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            StringBuilder stringBuilder = new StringBuilder(input.First().ToString());
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    stringBuilder.Append(input[i]);
                }
            }
            
            return stringBuilder.ToString();
        }
    }
}

