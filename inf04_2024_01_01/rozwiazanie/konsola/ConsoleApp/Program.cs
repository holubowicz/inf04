namespace ConsoleApp
{
    internal class Program
    {
        private static readonly int[] PositionWeights = new int[] { 1, 3, 7, 9 };

        internal static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer PESEL:");
            string peselNumber = Console.ReadLine() ?? string.Empty;
            
            string gender = ParseGender(peselNumber) == 'K'
                ? "Kobieta"
                : "Mężczyzna";
            
            bool isValid = IsPeselNumberValid(peselNumber);
            
            Console.WriteLine();
            Console.WriteLine($"Płeć numeru PESEL to: {gender}");
            Console.WriteLine($"Podany PESEL{(isValid ? "" : " nie")} jest poprawny");
        }

        /**********************************************
        nazwa funkcji:       ParseGender
        opis funkcji:        Wyciąga informacji o płci z numeru PESEL.
        parametry:           peselNumber - string, ciąg znaków, numer pesel
        zwracany typ i opis: char, płeć z numeru PESEL, 'K' dla kobiety, a 'M' dla mężczyzny
        autor:               00000000000
        ***********************************************/
        private static char ParseGender(string peselNumber)
        {
            int digit = int.Parse(peselNumber[9].ToString());
            return digit % 2 == 0 ? 'K' : 'M';
        }

        private static bool IsPeselNumberValid(string peselNumber)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int weight = PositionWeights[i % PositionWeights.Length];
                int digit = int.Parse(peselNumber[i].ToString());
                sum += digit * weight;
            }

            int modulo = sum % 10;
            int checksum = modulo == 0 ? 0 : 10 - modulo;
            int lastDigit = int.Parse(peselNumber[10].ToString());
            
            return checksum == lastDigit;
        }
    }
}