namespace Emne3.Klikkespill.CommandFolder;

internal class Exit : ICommand
{
    public char Character { get; } = 'x';

    public void Run()
    {
        Environment.Exit(0);
    }
}