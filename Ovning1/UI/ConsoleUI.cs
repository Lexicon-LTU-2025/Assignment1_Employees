using Employees.Abstractions;

namespace Ovning1.UI;

public class ConsoleUI : IUI
{
    public void Print(string message)
    {
        Console.WriteLine(message);
    }

    public string GetInput()
    {
        return Console.ReadLine() ?? string.Empty;
    }
}
