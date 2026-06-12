namespace MobileApp;

public partial class MainPage : ContentPage
{
    private bool _vacuumState = false;

    public MainPage()
    {
        InitializeComponent();
    }

    private void ConfirmProgramButton_OnClicked(object? sender, EventArgs e)
    {
        if (!int.TryParse(ProgramEntry.Text, out int program))
        {
            return;
        }

        if (program >= 1 && program <= 12)
        {
            ProgramLabel.Text = $"Numer prania: {program}";
        }
    }


    private void SwitchVacuumButton_OnClicked(object? sender, EventArgs e)
    {
        _vacuumState = !_vacuumState;

        SwitchVacuumButton.Text = _vacuumState ? "Wyłącz" : "Włącz";
        VacuumStateLabel.Text = _vacuumState ? "Odkurzacz włączony" : "Odkurzacz wyłączony";
    }
}