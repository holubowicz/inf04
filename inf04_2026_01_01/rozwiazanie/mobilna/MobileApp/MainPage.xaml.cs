namespace MobileApp;

public partial class MainPage : ContentPage
{
    private static readonly int IloscKosci = 5;

    private ImageButton[] _zdjecia;
    private Kosc[] _kosci = new Kosc[IloscKosci];

    public MainPage()
    {
        InitializeComponent();

        _zdjecia = new ImageButton[]
        {
            Kosc0ImageButton,
            Kosc1ImageButton,
            Kosc2ImageButton,
            Kosc3ImageButton,
            Kosc4ImageButton,
        };

        for (int i = 0; i < IloscKosci; i++)
        {
            _kosci[i] = new Kosc(0);
        }
    }

    private void RzutButton_OnClicked(object? sender, EventArgs e)
    {
        int suma = 0;
        for (int i = 0; i < IloscKosci; i++)
        {
            _kosci[i].RzucKosc();

            int liczbaOczek = _kosci[i].LiczbaOczek;
            suma += liczbaOczek;

            _zdjecia[i].Source = ImageSource.FromFile($"kosc{liczbaOczek}.png");
        }

        WynikLabel.Text = suma.ToString();
    }

    private void KoscImageButton_OnClicked(object? sender, EventArgs e)
    {
        ImageButton imageButton = (ImageButton)sender!;
        int identyfikator = int.Parse(imageButton.CommandParameter.ToString());

        if (_kosci[identyfikator].CzyDostepna)
        {
            imageButton.Opacity = 0.5;
            _kosci[identyfikator].ZablokujKosc();
        }
        else
        {
            imageButton.Opacity = 1;
            _kosci[identyfikator].CzyDostepna = true;
        }
    }
}