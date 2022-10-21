namespace Domain;
public class Game
{
    private List<int> _highscores = new();

    public int Eye1 { get => _dice1.Dots; }
    public int Eye2 { get => _dice2.Dots; }
    public bool HasSnakeEyes => Eye1 == 1 && Eye2 == 2;
    public IReadOnlyList<int> HighScores { get; }
    public int Total { get; private set; }

    private Dice _dice1;
    private Dice _dice2;

    public Game()
    {
        Initialize();
    }

    public void Initialize()
    {
        _dice1 = new Dice();
        _dice2 = new Dice();
    }

    public void Play()
    {
        _dice1.Roll();
        _dice2.Roll();

        if (HasSnakeEyes)
        {
            _highscores.Add(Total);
            Total = 0;
        } else
        {
            Total += _dice1.Dots + _dice2.Dots;
        }

    }

    public void Restart()
    {
        Initialize();
    }
}
