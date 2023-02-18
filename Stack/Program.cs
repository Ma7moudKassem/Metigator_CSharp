//"Peek" is Like "Pop" but doesn't remove element

Stack<Command> redo = new();
Stack<Command> undo = new();

string line;
while (true)
{
    Console.WriteLine("Url ('exit' to quit)");
    line = Console.ReadLine().ToLower();

    switch (line)
    {
        case "exit": break;
        case "back":
            {
                if (undo.Count > 0)
                {
                    Command item = undo.Pop();
                    redo.Push(item);
                }
                break;
            };
        case "forward":
            {
                if (redo.Count > 0)
                {
                    Command item = redo.Pop();
                    undo.Push(item);
                }
                break;
            };
        default:
            {
                undo.Push(new(line));
                break;
            };
    }
    Console.Clear();
    undo.PrintStack("Back");
    redo.PrintStack("Forward");
}

class Command
{
    private readonly DateTime _createdAt;
    private readonly string _url;
    public Command(string url)
        => (_createdAt, _url) = (DateTime.Now, url);

    public override string ToString()
        => $"[{this._createdAt.ToString("yyyyy-MM-dd hh:mm")}] {this._url}";
}
public static class Extentions
{
    public static void PrintStack<T>(this Stack<T> stack, string name)
    {
        Console.WriteLine($"{name} History");
        Console.BackgroundColor = name.ToLower() == "back" ? ConsoleColor.DarkGreen : ConsoleColor.DarkBlue;

        stack.ToList().ForEach(e => { Console.WriteLine($"\t{e}"); });

        Console.BackgroundColor = ConsoleColor.Black;
    }
}