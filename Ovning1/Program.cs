



using Employees.Helpers;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Ovning1;

internal class Program
{
    private static PayRoll payRoll = new PayRoll();

    static void Main(string[] args)
    {
       
        SeedData();

        do
        {
            ShowMainMeny();

            string input = Console.ReadLine() ?? string.Empty;

            switch (input)
            {
                case MenyHelpers.Add:
                    AddEmployee();
                    break; 
                case MenyHelpers.Print:
                    PrintEmployees();
                    break; 
                case MenyHelpers.Quit:

                    break;
                default:
                    break;
            }

        } while (true);
    }

    private static void AddEmployee()
    {
        string name = Util.AskForString("Name");
        uint salary = Util.AskForUInt("Salary");
       
    }

    private static void PrintEmployees()
    {
        IEnumerable<Employee> employees = payRoll.GetEmployees();
        
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.Print());
        }
    }

    private static void ShowMainMeny()
    {
        Console.WriteLine($"{MenyHelpers.Add}. Add");
        Console.WriteLine($"{MenyHelpers.Print}. Print");
        Console.WriteLine($"{MenyHelpers.Quit}. Quit");
    }

    private static void SeedData()
    {
        payRoll.AddEmployee("Nisse", 12);
        payRoll.AddEmployee("Kalle", 60);
        payRoll.AddEmployee("Anna", 12);
        payRoll.AddEmployee("Olle", 500);
        
    }
}
