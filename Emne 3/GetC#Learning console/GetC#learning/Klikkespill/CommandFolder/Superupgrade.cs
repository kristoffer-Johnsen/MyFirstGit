namespace Emne3.Klikkespill.CommandFolder;

internal class SuperUpgrade : ICommand
{
    private ClickerGame _game;
    public char Character { get; } = 's';

    public SuperUpgrade(ClickerGame game)
    {
        _game = game;
    }

    public void Run()
    {
        _game.SuperUpgrade();
    }
}