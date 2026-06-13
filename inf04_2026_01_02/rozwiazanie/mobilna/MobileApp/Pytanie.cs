namespace MobileApp
{
    public abstract class Pytanie
    {
        public string Tresc;
        public string NazwaZdjecia;
        
        protected bool _czyPoprawna;

        public Pytanie(string tresc, string nazwaZdjecia)
        {
            Tresc = tresc;
            NazwaZdjecia = nazwaZdjecia;
            _czyPoprawna = false;
        }

        public abstract bool CzyPoprawnaOdpowiedz(char odpowiedz);
    }
}