namespace Employees.Abstractions;

public interface IUI
{
    string GetInput();
    void Print(string message);
}

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

public class MockUI : IUI
{
    public string GetInput()
    {
        return "1";
    }

    public void Print(string message)
    {
        
    }
}
