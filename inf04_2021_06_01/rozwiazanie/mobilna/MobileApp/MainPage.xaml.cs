namespace MobileApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void ConfirmButton_OnClicked(object? sender, EventArgs e)
    {
        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;
        string passwordRepetition = PasswordRepetitionEntry.Text;

        if (string.IsNullOrEmpty(email) || !email.Contains("@"))
        {
            MessageLabel.Text = "Nieprawidłowy adres e-mail";
            return;
        }

        if (password != passwordRepetition)
        {
            MessageLabel.Text = "Hasła się różnią";
            return;
        }

        MessageLabel.Text = $"Witaj {email}";
    }
}