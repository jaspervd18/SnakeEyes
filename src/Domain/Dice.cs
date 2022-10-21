namespace Domain;

public class Dice
{
    private Random _randomizer = new();

    public int Dots { get; private set; }

    public Dice()
    {
        Dots = 6;
    }

    public void Roll()
    {
        Dots = _randomizer.Next(1, 7);
    }
}