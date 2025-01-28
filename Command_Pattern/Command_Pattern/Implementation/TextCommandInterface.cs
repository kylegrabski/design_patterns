// using Command_Pattern.Interfaces;
//
// namespace Command_Pattern.Implementation;
//
// // Concrete Command
// public class TextCommandInterface : ICommandInterface
// {
//     private TextReceiver _textReceiver;
//     private string _action;
//     private string? _newText;
//
//     public TextCommandInterface(TextReceiver textReceiver, string action, string? newText)
//     {
//         _textReceiver = textReceiver;
//         _action = action;
//         _newText = newText;
//     }
//
//     public string Execute()
//     {
//         return _action switch
//         {
//             "--add" => _textReceiver.AddText(_newText ?? ""),
//             "--delete" => _textReceiver.DeleteText(_newText ?? ""),
//             _ => _textReceiver.AddText("")
//         };
//     }
//
//     public string UnExecute()
//     {
//         return _textReceiver.Undo();
//     }
// }