namespace ConsoleApp
{
    public abstract class Pytanie
    {
        protected string _tresc;
        protected string _nazwaZdjecia;
        protected bool _czyPoprawna;

        public Pytanie(string tresc, string nazwaZdjecia)
        {
            _tresc = tresc;
            _nazwaZdjecia = nazwaZdjecia;
            _czyPoprawna = false;
        }

        public abstract bool CzyPoprawnaOdpowiedz(char odpowiedz);
    }
}