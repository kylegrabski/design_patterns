using Command_Pattern.Interfaces;

namespace Command_Pattern.Implementation;

public class AddCommand : ICommand
{
    private readonly TextReceiver _receiver;
    private string? _previousText;
    public string Action => "--add";
    public string Text { get; set; } = "";

    public AddCommand(TextReceiver receiver)
    {
        _receiver = receiver;
    }


    public bool CanExecute(string action) => action == Action;

    public string Execute(string text)
    {
        _previousText = _receiver.GetCurrentText();
        Text = text;
        return _receiver.AddText(text);
    }

    public string Undo()
    {
        return _receiver.RestoreText(_previousText);
    }
}