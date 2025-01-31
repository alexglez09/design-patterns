using Command.Commands;

namespace Command
{
    public class CommandManager
    {
        private readonly Stack<ICommand> commands = new();

        public void Invoke(ICommand command)
        {
            if (command.CanExecute())
            {
                commands.Push(command);
                command.Execute();
            }
        }

        public void UndoAll()
        {
            while (commands.Any())
            {
                var command = commands.Pop();
                command.Undo();
            }
        }
    }
}