
using Employees.Abstractions;

namespace Employees.Helpers;

public static class Util
{
    public static string AskForString(string prompt, IUI ui, Func<string, bool> validate = null!)
    {

        do
        {
            ui.Print($"{prompt}: ");
            string answer = ui.GetInput();

            if (string.IsNullOrWhiteSpace(answer))
            {
                ui.Print($"You must enter a valid {prompt}");
                continue;
            }
            if(validate != null && !validate(answer))
            {
                ui.Print($"You must enter a valid {prompt}");
                continue;
            }

            return answer;

        } while (true);

    }

    public static uint AskForUInt(string prompt, IUI ui, uint? min = null, uint? max = null)
    {
        return uint.Parse(AskForString(prompt, ui, (input) =>
        {
            if(!uint.TryParse(input, out uint result)) 
                return false;

            if (min.HasValue && result < min.Value)
                return false;

            if (max.HasValue && result > max.Value)
                return false;

            return true;
        }));
    }
}
