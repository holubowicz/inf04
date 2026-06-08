namespace ConsoleApp
{
    /************************************************
     klasa: Notatka
     opis:  Klasa reprezentuje notatkę, która zawiera unikalny identyfikator, tytuł oraz treść.
     pola:  _id - int, liczba całkowita, unikalny identyfikator
            _tytul - string, tekst, tytuł notatki
            _tresc - string, tekst, treść notatki
     autor: 00000000000
    ************************************************/
    public class Notatka
    {
        private static int _licznik;

        private int _id;
        protected string _tytul;
        protected string _tresc;

        public Notatka(string tytul, string tresc)
        {
            _id = ++_licznik;
            _tytul = tytul;
            _tresc = tresc;
        }

        public void WyswietlNotatke()
        {
            Console.WriteLine($"Tytuł: {_tytul}");
            Console.WriteLine($"Treść: {_tresc}");
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine(string.Join(", ", _licznik, _id, _tytul, _tresc));
        }
    }
}