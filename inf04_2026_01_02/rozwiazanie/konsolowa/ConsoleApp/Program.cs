namespace ConsoleApp
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            // Pytanie pytanie = new Pytanie("Ile Ziemia ma księżyców?", "ziemia.jpg");
            // Error CS0144 : Cannot create an instance of the abstract type or interface 'Pytanie'

            Console.WriteLine("Podaj treść pytania:");
            string tresc = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Podaj nazwę pliku graficznego:");
            string nazwaZdjecia = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Podaj odpowiedź A:");
            string odpowiedzA = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Podaj odpowiedź B:");
            string odpowiedzB = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Podaj odpowiedź C:");
            string odpowiedzC = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Która odpowiedź jest prawidłowa? (A/B/C):");
            char poprawnaOdpowiedz = Console.ReadKey().KeyChar.ToString().ToUpper()[0];

            PytanieZamkniete pytanieZamkniete = new PytanieZamkniete(tresc, nazwaZdjecia, odpowiedzA, odpowiedzB,
                odpowiedzC, poprawnaOdpowiedz);
            
            Console.WriteLine("\n\nQuiz");
            Console.WriteLine(tresc);
            Console.WriteLine($"A. {odpowiedzA}");
            Console.WriteLine($"B. {odpowiedzB}");
            Console.WriteLine($"C. {odpowiedzC}");
            
            Console.WriteLine("\nTwoja odpowiedź (A/B/C):");
            char odpowiedzUzytkownika = Console.ReadKey().KeyChar.ToString().ToUpper()[0];
            bool czyPoprawna = pytanieZamkniete.CzyPoprawnaOdpowiedz(odpowiedzUzytkownika);
            
            Console.WriteLine($"\n\nOdpowiedź {(czyPoprawna ? "" : "nie")}prawidłowa");
        }
    }
}