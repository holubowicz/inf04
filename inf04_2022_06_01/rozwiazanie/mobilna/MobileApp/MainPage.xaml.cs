namespace MobileApp;

public partial class MainPage : ContentPage
{
    private int _likesCount;

    public MainPage()
    {
        InitializeComponent();
    }

    private void LikeButton_OnClicked(object? sender, EventArgs e)
    {
        _likesCount++;
        UpdateLikesLabel();
    }

    private void DeleteButton_OnClicked(object? sender, EventArgs e)
    {
        if (_likesCount == 0) return;
        _likesCount--;
        UpdateLikesLabel();
    }

    private void UpdateLikesLabel()
    {
        LikesLabel.Text = $"{_likesCount} polubień";
    }
}