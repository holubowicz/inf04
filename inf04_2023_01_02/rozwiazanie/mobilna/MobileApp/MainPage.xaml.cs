using System.Collections.ObjectModel;

namespace MobileApp;

public partial class MainPage : ContentPage
{
    public ObservableCollection<string> Notes { get; } = new ObservableCollection<string>()
    {
        "Zakupy: chleb, masło, ser",
        "Do zrobienia: obiad, umyć podłogi",
        "weekend: kino, spacer z psem"
    };
    
    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private void AddButton_OnClicked(object? sender, EventArgs e)
    {
        string note = AddNoteEntry.Text;
        if (!string.IsNullOrEmpty(note))
        {
            Notes.Add(note);
        }
    }
}