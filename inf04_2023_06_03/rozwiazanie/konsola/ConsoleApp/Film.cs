namespace ConsoleApp
{
    /******************************************************
     nazwa klasy: Film
     pola:        _title - string, ciąg znaków, tytuł filmu
                  _rentalsCount - int, liczba całkowita, liczba wypożyczeń filmu
     metody:      SetTitle, void (brak) - ustawia nową wartość tytułu
                  GetTitle, string (ciąg znaków) - zwraca aktualną wartość tytułu
                  GetRentalsCount, int (liczba całkowita) - zwraca aktualną wartość liczby wypożyczeń
                  IncrementRentalsCount, void (brak) - zwiększa wartość wypożyczeń o 1
     informacje:  Klasa reprezentuja film, zawiera jego tytuł oraz liczbę wypożyczeń.
     autor:       00000000000
    *****************************************************/
    public class Film
    {
        protected string _title = string.Empty;
        protected int _rentalsCount = 0;

        public void SetTitle(string tytul)
        {
            _title = tytul;
        }

        public string GetTitle()
        {
            return _title;
        }

        public int GetRentalsCount()
        {
            return _rentalsCount;
        }

        public void IncrementRentalsCount()
        {
            _rentalsCount++;
        }
    }
}