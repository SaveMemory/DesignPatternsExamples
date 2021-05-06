using System.Collections.Generic;

namespace Command
{
    public class CommandManager
    {
        private Stack<ICommand> _commands = new Stack<ICommand>();

        public void Invoke(ICommand command)
        {
            if (!command.CanExecute())
                return;

            command.Execute();
            _commands.Push(command);
        }

        public void Undo(ICommand command)
        {
            _commands.Pop().Undo();
        }
    }
}