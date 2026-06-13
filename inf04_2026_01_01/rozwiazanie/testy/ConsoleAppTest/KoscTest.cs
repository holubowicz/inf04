using ConsoleApp;

namespace ConsoleAppTest
{
    public class KoscTest
    {
        [Fact]
        public void RzucKosc_GdyDostepna_WartoscWOdpowiednimZakresie()
        {
            Kosc kosc = new Kosc(0);
            
            kosc.RzucKosc();
            
            Assert.InRange(kosc.LiczbaOczek, 1, 6);
        }
        
        [Fact]
        public void RzucKosc_GdyNieDostepna_WartoscSieNieZmienia()
        {
            int wartoscKosci = 5;
            Kosc kosc = new Kosc(wartoscKosci);
            kosc.ZablokujKosc();
            
            kosc.RzucKosc();
            
            Assert.Equal(wartoscKosci, kosc.LiczbaOczek);
        }
    }
}