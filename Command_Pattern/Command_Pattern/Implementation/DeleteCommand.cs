using Command_Pattern.Interfaces;

namespace Command_Pattern.Implementation;

public class DeleteCommand : ICommand
{
    private readonly TextReceiver _receiver;
    private string? _previousText;
    public string Action => "--delete";
    public string Text { get; set; }

    public DeleteCommand(TextReceiver receiver)
    {
        _receiver = receiver;
    }


    public bool CanExecute(string action) => action == Action;

    public string Execute(string text)
    {
        _previousText = _receiver.GetCurrentText();
        return _receiver.DeleteText(text);
    }

    public string Undo()
    {
        return _receiver.RestoreText(_previousText);
    }
}