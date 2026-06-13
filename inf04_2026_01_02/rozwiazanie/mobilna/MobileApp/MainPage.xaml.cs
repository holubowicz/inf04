namespace MobileApp;

public partial class MainPage : ContentPage
{
    private static readonly PytanieZamkniete[] Pytania = new PytanieZamkniete[]
    {
        new PytanieZamkniete("Które to schronisko?",
            "zad1.jpg",
            "Na Rysiance.",
            "Na Wielkiej Raczy.",
            "Na Wielkiej Rycerzowej.",
            'B'),
        new PytanieZamkniete("Zwierzę na zdjęciu to",
            "zad2.jpg",
            "owczarek.",
            "wilk.",
            "kozica.",
            'A'),
        new PytanieZamkniete("W oddali są widoczne",
            "zad3.jpg",
            "Himalaje.",
            "Alpy.",
            "Tatry.",
            'C'),
    };

    private int _wybranePytanie = 0;
    private int _punkty = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void DalejButton_OnClicked(object? sender, EventArgs e)
    {
        char wybranaOdpowiedz = ' ';
        if (OdpowiedzARadioButton.IsChecked)
        {
            wybranaOdpowiedz = 'A';
        }
        else if (OdpowiedzBRadioButton.IsChecked)
        {
            wybranaOdpowiedz = 'B';
        }
        else if (OdpowiedzCRadioButton.IsChecked)
        {
            wybranaOdpowiedz = 'C';
        }

        PytanieZamkniete pytanie = Pytania[_wybranePytanie];
        bool czyPoprawna = pytanie.CzyPoprawnaOdpowiedz(wybranaOdpowiedz);
        if (czyPoprawna)
        {
            _punkty++;
        }

        _wybranePytanie = (_wybranePytanie + 1) % Pytania.Length;
        PytanieZamkniete nowePytanie = Pytania[_wybranePytanie];
        
        PytanieImage.Source = ImageSource.FromFile(nowePytanie.NazwaZdjecia);
        PytanieLabel.Text = nowePytanie.Tresc;

        ((Label)OdpowiedzARadioButton.Content!).Text = nowePytanie.OdpowiedzA;
        OdpowiedzARadioButton.IsChecked = false;
        
        ((Label)OdpowiedzBRadioButton.Content!).Text = nowePytanie.OdpowiedzB;
        OdpowiedzBRadioButton.IsChecked = false;
        
        ((Label)OdpowiedzCRadioButton.Content!).Text = nowePytanie.OdpowiedzC;
        OdpowiedzCRadioButton.IsChecked = false;
    }
}