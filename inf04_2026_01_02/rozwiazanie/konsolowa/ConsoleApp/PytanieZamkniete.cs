namespace ConsoleApp
{
    public class PytanieZamkniete : Pytanie
    {
        private string _odpowiedzA;
        private string _odpowiedzB;
        private string _odpowiedzC;
        private char _poprawnaOdpowiedz;

        public PytanieZamkniete(string tresc, string nazwaZdjecia, string odpowiedzA, string odpowiedzB,
            string odpowiedzC, char poprawnaOdpowiedz) : base(tresc, nazwaZdjecia)
        {
            _odpowiedzA = odpowiedzA;
            _odpowiedzB = odpowiedzB;
            _odpowiedzC = odpowiedzC;
            _poprawnaOdpowiedz = poprawnaOdpowiedz;
        }

        public override bool CzyPoprawnaOdpowiedz(char odpowiedz)
        {
            _czyPoprawna = odpowiedz == _poprawnaOdpowiedz;
            return _czyPoprawna;
        }
    }
}