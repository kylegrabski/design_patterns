namespace Command_Pattern.Implementation;

public class TextReceiver
{
    private string _currentText = "";

    public string AddText(string newText)
    {
        _currentText += newText;
        return _currentText;
    }

    public string DeleteText(string textToDelete)
    {
        if (_currentText.Contains(textToDelete))
        {
            _currentText = _currentText.Replace(textToDelete, "");
        }

        return _currentText;
    }

    public string GetCurrentText() => _currentText;

    public string RestoreText(string? previousText)
    {
        if (previousText != null)
        {
            _currentText = previousText;
        }

        return _currentText;
    }
}

// public class TextReceiver
// {
//     private string _currentText = "";
//     private Stack<string> _undoStack = new();
//     
//     public string AddText(string newText)
//     {
//         var previousText = _currentText;
//         _currentText += newText;
//         _undoStack.Push(previousText);
//         return _currentText;
//     }
//
//     public string DeleteText(string textToDelete)
//     {
//         var previousText = _currentText;
//         if (!string.IsNullOrEmpty(textToDelete) && _currentText.Contains(textToDelete))
//         {
//             _currentText = _currentText.Replace(textToDelete, "");
//         }
//         _undoStack.Push(previousText);
//         return _currentText;
//     }
//
//     public string Undo()
//     {
//         if (_undoStack.Count > 0)
//         {
//             _currentText = _undoStack.Pop();
//         }
//         return _currentText;
//     }
// }