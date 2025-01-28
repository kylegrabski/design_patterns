namespace Command_Pattern.Interfaces;

public interface ICommand
{
    string Action { get; }
    string Text { get; set; }
    bool CanExecute(string action);
    string Execute(string text);
    string Undo();
}