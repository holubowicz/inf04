namespace MobileApp
{
    public class PytanieZamkniete : Pytanie
    {
        public string OdpowiedzA;
        public string OdpowiedzB;
        public string OdpowiedzC;
        
        private char _poprawnaOdpowiedz;

        public PytanieZamkniete(string tresc, string nazwaZdjecia, string odpowiedzA, string odpowiedzB,
            string odpowiedzC, char poprawnaOdpowiedz) : base(tresc, nazwaZdjecia)
        {
            OdpowiedzA = odpowiedzA;
            OdpowiedzB = odpowiedzB;
            OdpowiedzC = odpowiedzC;
            _poprawnaOdpowiedz = poprawnaOdpowiedz;
        }

        public override bool CzyPoprawnaOdpowiedz(char odpowiedz)
        {
            _czyPoprawna = odpowiedz == _poprawnaOdpowiedz;
            return _czyPoprawna;
        }
    }
}