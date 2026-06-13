namespace MobileApp;

public class Kosc
{
    private static readonly Random Rand = new Random();

    private static string[] WartosciKosci = new string[]
    {
        "zero",
        "jeden",
        "dwa",
        "trzy",
        "cztery",
        "pięć",
        "sześć"
    };

    public static int IloscInstancji;

    public string[] NazwyPlikow = new string[]
    {
        "kosc0.png",
        "kosc1.png",
        "kosc2.png",
        "kosc3.png",
        "kosc4.png",
        "kosc5.png",
        "kosc6.png"
    };

    public int LiczbaOczek;
    public int IdentyfikatorObrazu;
    public bool CzyDostepna;

    public Kosc(int wyrzuconaKosc)
    {
        if (wyrzuconaKosc < 1 || wyrzuconaKosc > 6)
        {
            wyrzuconaKosc = 0;
        }

        LiczbaOczek = wyrzuconaKosc;
        IdentyfikatorObrazu = wyrzuconaKosc;
        CzyDostepna = true;

        IloscInstancji++;
    }

    public Kosc()
    {
        int wyrzuconaKosc = Rand.Next(1, 7);

        LiczbaOczek = wyrzuconaKosc;
        IdentyfikatorObrazu = wyrzuconaKosc;
        CzyDostepna = true;

        IloscInstancji++;
    }

    public void RzucKosc()
    {
        if (!CzyDostepna)
        {
            return;
        }

        int wyrzuconaKosc = Rand.Next(1, 7);
        LiczbaOczek = wyrzuconaKosc;
        IdentyfikatorObrazu = wyrzuconaKosc;
    }

    public void ZablokujKosc()
    {
        CzyDostepna = false;
    }

    public string DostanWartoscKosci()
    {
        return WartosciKosci[LiczbaOczek];
    }
}