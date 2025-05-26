using Employees.Abstractions;

namespace Ovning1.UI;

public class MockUI : IUI
{
    public string SetInput { private get; set; } = "1";
    public string GetInput()
    {
        return SetInput;
    }

    public void Print(string message)
    {
        
    }
}
