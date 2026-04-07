namespace ConsoleApp;

/******************************************************
 nazwa klasy: Film
 pola:        Title - tytuł filmu
              BorrowsCount - liczba wypożyczeń
 metody:      SetTitle, brak - ustawia tytuł na podaną wartość
              GetTitle, string - pobiera wartość tytułu i go zwraca
              GetBorrowsCount, int - pobiera wartość liczby wypożyczeń i ją zwraca
              IncrementBorrowsCount, brak - powiększa wartość liczby wypożyczeń o 1
 informacje:  Klasa reprezentująca wypożyczony film, zawartę są w niej informacje o tytule i liczbie wypożyczeń.
 autor:       00000000000
*****************************************************/
public class Film
{
    protected string Title = "";
    protected int BorrowsCount = 0;
    
    public void SetTitle(string title)
    {
        Title = title;
    }
    
    public string GetTitle()
    {
        return Title;
    }

    public int GetBorrowsCount()
    {
        return BorrowsCount;
    }
    
    public void IncrementBorrowsCount()
    {
        BorrowsCount++;
    }
}