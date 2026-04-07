namespace ConsoleApp;

/******************************************************
 nazwa klasy: Film
 pola:        Tytul - tytuł filmu
              LiczbaWypozyczen - liczba wypożyczeń
 metody:      UstawTytul, brak - ustawia tytuł na podaną wartość
              PobierzTytul, string - pobiera wartość tytułu i go zwraca
              PobierzLiczbaWypozyczen, int - pobiera wartość liczby wypożyczeń i ją zwraca
              InkrementujLiczbaWypozyczen, brak - powiększa wartość liczby wypożyczeń o 1
 informacje:  Klasa reprezentująca wypożyczony film, zawartę są w niej informacje o tytule i liczbie wypożyczeń.
 autor:       00000000000
*****************************************************/
public class Film
{
    protected string Tytul = string.Empty;
    protected int LiczbaWypozyczen = 0;
    
    public void UstawTytul(string tytul)
    {
        if (tytul.Length > 20)
            throw new ArgumentException("Tytuł może mieć maksymalnie 20 znaków");
        Tytul = tytul;
    }
    
    public string PobierzTytul()
    {
        return Tytul;
    }

    public int PobierzLiczbaWypozyczen()
    {
        return LiczbaWypozyczen;
    }
    
    public void InkrementujLiczbaWypozyczen()
    {
        LiczbaWypozyczen++;
    }
}