namespace Emne3.Klikkespill.CommandFolder;

internal class Upgrade : ICommand
{
    private ClickerGame _game;
    public char Character => 'k';

    public Upgrade(ClickerGame game)
    {
        _game = game;
    }

    public void Run()
    {
        _game.upgrade();
    }
}