namespace MobileApp;

public partial class MainPage : ContentPage
{
    private static readonly int DiceCount = 5;
    private static readonly Random Rand = new Random();

    private int _score;
    private int _gameScore;

    public MainPage()
    {
        InitializeComponent();
    }

    private void RollDiceButton_OnClicked(object? sender, EventArgs e)
    {
        int[] rolls = GenerateDiceRolls(DiceCount);

        _score = CalculateScore(rolls);
        _gameScore += _score;
        UpdateScoreLabels();

        for (int i = 0; i < DiceCount; i++)
        {
            Image image = (Image)ImagesStackLayout.Children[i];
            int roll = rolls[i];

            image.Source = ImageSource.FromFile("k" + roll + ".jpg");
        }
    }

    private void ResetScoreButton_OnClicked(object? sender, EventArgs e)
    {
        _score = 0;
        _gameScore = 0;
        UpdateScoreLabels();

        for (int i = 0; i < DiceCount; i++)
        {
            Image image = (Image)ImagesStackLayout.Children[i];
            image.Source = ImageSource.FromFile("question.jpg");
        }
    }

    private void UpdateScoreLabels()
    {
        ScoreLabel.Text = $"Wynik tego losowania: {_score}";
        GameScoreLabel.Text = $"Wynik gry: {_gameScore}";
    }

    private int[] GenerateDiceRolls(int count)
    {
        int[] rolls = new int[count];
        for (int i = 0; i < count; i++)
        {
            rolls[i] = Rand.Next(1, 7);
        }

        return rolls;
    }

    private int CalculateScore(int[] rolls)
    {
        int[] counts = new int[7];
        foreach (int value in rolls)
        {
            counts[value]++;
        }

        int score = 0;
        for (int i = 1; i <= 6; i++)
        {
            int count = counts[i];
            if (count >= 2)
            {
                score += i * count;
            }
        }

        return score;
    }
}