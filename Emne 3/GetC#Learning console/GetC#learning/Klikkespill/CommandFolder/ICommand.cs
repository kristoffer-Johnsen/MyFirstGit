

namespace Emne3.Klikkespill.CommandFolder
{
    internal interface ICommand
    {
        char Character { get; }
        void Run();
    }
}