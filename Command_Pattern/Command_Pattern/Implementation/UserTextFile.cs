using Command_Pattern.Interfaces;

namespace Command_Pattern.Implementation;

public class UserTextFile
{
    private readonly TextReceiver _receiver = new();
    private readonly Stack<ICommand> _commands = new();
    private readonly Stack<ICommand> _undoneCommands = new();
    private readonly List<ICommand> _availableCommands;

    public UserTextFile()
    {
        _availableCommands = new List<ICommand>
        {
            new AddCommand(_receiver),
            new DeleteCommand(_receiver),
        };
    }

    public string ProcessCommand(string action, string text)
    {
        foreach (var command in _availableCommands)
        {
            if (command.CanExecute(action))
            {
                var result = command.Execute(text);
                _commands.Push(command);
                return result;
            }
        }

        return action switch
        {
            "--undo" => Undo(),
            "--redo" => Redo(),
            _ => "NOPE!"
        };
    }

    private string Undo()
    {
        if (_commands.Count > 0)
        {
            var lastCommand = _commands.Pop();
            _undoneCommands.Push(lastCommand);
            return lastCommand.Undo();
        }

        return "Nothing to undo.";
    }

    public string Redo()
    {
        if (_undoneCommands.Count > 0)
        {
            var lastUndoneCommand = _undoneCommands.Pop();

            var recreatedCommand = _availableCommands.FirstOrDefault(x => x.CanExecute(lastUndoneCommand.Action));
            if (recreatedCommand != null)
            {
                var result = recreatedCommand.Execute(lastUndoneCommand.Text);
                _commands.Push(recreatedCommand);
                return result;
            }
        }

        return "Nothing to redo.";
    }


}