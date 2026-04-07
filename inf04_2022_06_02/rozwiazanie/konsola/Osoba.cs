namespace ConsoleApp;

public class Osoba
{
    public static int LiczbaInstancji = 0;
    
    private int id;
    private string imie;

    public Osoba()
    {
        id = 0;
        imie = string.Empty;

        LiczbaInstancji++;
    }

    public Osoba(int id, string imie)
    {
        this.id = id;
        this.imie = imie;
        
        LiczbaInstancji++;
    }

    public Osoba(Osoba osoba)
    {
        id = osoba.id;
        imie = osoba.imie;
        
        LiczbaInstancji++;
    }

    public void Przywitanie(string inneImie)
    {
        if (string.IsNullOrEmpty(inneImie))
        {
            Console.WriteLine("Brak danych");
            return;
        }
        Console.WriteLine($"Cześć {inneImie}, mam na imię {imie}");
    }
}