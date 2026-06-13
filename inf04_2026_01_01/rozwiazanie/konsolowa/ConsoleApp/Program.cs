namespace ConsoleApp
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int wartoscKosci;
            while (true)
            {
                Console.Write("Podaj wartość kości: ");
                if (int.TryParse(Console.ReadLine() ?? string.Empty, out wartoscKosci))
                {
                    break;
                }
            }
            
            Kosc kosc1 = new Kosc(wartoscKosci);
            Console.WriteLine("\nKość 1");
            Console.WriteLine($"Utworzone instancje klasy: {Kosc.IloscInstancji}");
            Console.WriteLine($"Ilość oczek: {kosc1.LiczbaOczek} - {kosc1.DostanWartoscKosci()}");
            Console.WriteLine($"Nazwa pliku graficznego: {kosc1.NazwyPlikow[kosc1.IdentyfikatorObrazu]}");
            
            Kosc kosc2 = new Kosc();
            Console.WriteLine("\nKość 2");
            Console.WriteLine($"Utworzone instancje klasy: {Kosc.IloscInstancji}");
            Console.WriteLine($"Ilość oczek: {kosc2.LiczbaOczek} - {kosc2.DostanWartoscKosci()}");
            Console.WriteLine($"Nazwa pliku graficznego: {kosc2.NazwyPlikow[kosc2.IdentyfikatorObrazu]}");
        }
    }
}