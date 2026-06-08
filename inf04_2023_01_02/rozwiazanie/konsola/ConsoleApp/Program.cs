namespace ConsoleApp
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Notatka notatka1 = new Notatka("Do zrobienia", "zrobić zakupy, ugotować obiad, umyć okna");
            Notatka notatka2 = new Notatka("Lista zakupów", "chleb, masło ser");
            
            Console.WriteLine("Notatka 1");
            notatka1.WyswietlNotatke();
            notatka1.WyswietlInformacje();
            
            Console.WriteLine("\nNotatka 2");
            notatka2.WyswietlNotatke();
            notatka2.WyswietlInformacje();
        }
    }
}