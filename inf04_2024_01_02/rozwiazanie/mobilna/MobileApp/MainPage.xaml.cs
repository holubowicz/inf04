namespace MobileApp;

public partial class MainPage : ContentPage
{
    private static readonly string[] Species = new string[] { "Pies", "Kot", "Świnka morska" };

    private string _species = string.Empty;
    private int _age;

    public MainPage()
    {
        InitializeComponent();
        SpeciesCollectionView.ItemsSource = Species;
    }

    private void SpeciesCollectionView_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        _species = e.CurrentSelection.First().ToString()!;
        int maximumAgeSlider = 20;

        if (_species == "Pies")
        {
            maximumAgeSlider = 18;
        }
        else if (_species == "Świnka morska")
        {
            maximumAgeSlider = 9;
        }

        PetAgeSlider.Maximum = maximumAgeSlider;
    }

    private void AgeSlider_OnValueChanged(object? sender, ValueChangedEventArgs e)
    {
        _age = (int)e.NewValue;
        PetAgeLabel.Text = _age.ToString();
    }

    private async void OkButton_OnClicked(object? sender, EventArgs e)
    {
        string ownerFullName = OwnerFullNameEntry.Text;
        string visitPurpose = VisitPurposeEntry.Text;
        string time = VisitTimePicker.Time.ToString()!;

        string message = string.Join(", ", ownerFullName, _species, _age, visitPurpose, time);
        
        await DisplayAlertAsync("Zapisana Wizyta", message, "OK");
    }
}