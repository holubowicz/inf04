namespace MobileApp;

public partial class MainPage : ContentPage
{
    private static readonly string[] Quotes = new string[]
    {
        "Dzień dobry",
        "Good morning",
        "Buenos dias"
    };
    
    private int _quoteIndex;
    
    public MainPage()
    {
        InitializeComponent();
        UpdateQuoteLabel();
    }

    private void SizeSlider_OnValueChanged(object? sender, ValueChangedEventArgs e)
    {
        Slider slider = (Slider)sender!;
        int fontSize = (int)slider.Value;
        
        QuoteLabel.FontSize = fontSize;
        SizeLabel.Text = $"Rozmiar: {fontSize}";
    }
    
    private void NextButton_OnClicked(object? sender, EventArgs e)
    {
        _quoteIndex++;
        UpdateQuoteLabel();
    }

    private void UpdateQuoteLabel()
    {
        _quoteIndex %= Quotes.Length;
        QuoteLabel.Text = Quotes[_quoteIndex];
    }
}