// See https://aka.ms/new-console-template for more information

using Command_Pattern.Implementation;

var userTextFile = new UserTextFile();

while (true)
{
    Console.WriteLine("Type a command. Type '--exit' to quit. Type '--help' for help:");
    var userInput = Console.ReadLine() ?? "";

    if (userInput.Contains("--exit"))
    {
        break;
    }

    if (userInput.Contains("--help"))
    {
        Console.WriteLine(
            "\n*****COMMANDS*****\n--add <text>\tAdd new text\n--undo\t\tRevert last command.\n--redo\t\tReapply a previously undone command.\n--delete <text>\tDelete specified text.\n");
        continue;
    }

    var parts = userInput.Split(' ', 2);
    var action = parts[0];
    var text = parts.Length > 1 ? parts[1] : "";

    var result = userTextFile.ProcessCommand(action, text);
    Console.WriteLine(result);
}

Console.WriteLine("Program exited.");