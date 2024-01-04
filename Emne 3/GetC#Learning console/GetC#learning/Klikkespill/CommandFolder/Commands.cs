namespace Emne3.Klikkespill.CommandFolder;

internal class Commands
{
    private ICommand[] _commands;

    public Commands(ClickerGame game)
    {
        _commands = new ICommand[]
        {
            new Exit(),
            new Click(game),
            new Upgrade(game),
            new SuperUpgrade(game)
        };
    }
    public void Run(char commandChar)
    {
        var command = FindCommand(commandChar);
        if (command != null) command.Run();
    }
    private ICommand FindCommand(char commandChar)
    {
        foreach (var command in _commands)
        {
            if (command.Character == commandChar) return command;
        }

        return null!;
    }
}