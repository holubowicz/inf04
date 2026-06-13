using System.Text;

namespace ConsoleApp
{
    public class Program
    {
        private static readonly int LettersCount = 26;

        internal static void Main(string[] args)
        {
            Console.WriteLine("Szyfr Cezara\n");

            Console.WriteLine("Podaj tekst do zaszyfrowania:");
            string input = Console.ReadLine() ?? string.Empty;

            int key;
            while (true)
            {
                Console.WriteLine("Podaj klucz szyfru:");
                if (int.TryParse(Console.ReadLine() ?? string.Empty, out key))
                {
                    break;
                }
            }

            Console.WriteLine("\nZaszyfrowany tekst:");
            string cipher = CaesarCipher(input, key);
            Console.WriteLine(cipher);
        }

        public static string CaesarCipher(string input, int key)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            
            int shift = (key % LettersCount + LettersCount) % LettersCount;
            if (shift == 0)
            {
                return input;
            }

            StringBuilder cipher = new StringBuilder();
            foreach (char character in input)
            {
                if (character >= 'a' && character <= 'z')
                {
                    int newCharacter = (character - 'a' + shift) % LettersCount + 'a';
                    cipher.Append((char)newCharacter);
                    continue;
                }

                cipher.Append(character);
            }

            return cipher.ToString();
        }
    }
}