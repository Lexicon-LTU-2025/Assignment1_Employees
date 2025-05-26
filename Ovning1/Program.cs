



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
                case "1":
                    AddEmployee();
                    break; 
                case "2":
                    PrintEmployees();
                    break; 
                case "Q":

                    break;
                default:
                    break;
            }

        } while (true);
    }

    private static void AddEmployee()
    {
        string name = Util.AskForString("Name");

       
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
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Print");
        Console.WriteLine("Q. Quit");
    }

    private static void SeedData()
    {
        payRoll.AddEmployee("Nisse", 12);
        payRoll.AddEmployee("Kalle", 60);
        payRoll.AddEmployee("Anna", 12);
        payRoll.AddEmployee("Olle", 500);
        
    }
}
