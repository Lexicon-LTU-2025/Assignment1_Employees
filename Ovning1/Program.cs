


namespace Ovning1
{
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

        private static void PrintEmployees()
        {
            List<Employee> employees = payRoll.GetEmployees();

            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Salary {employee.Salary}");
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
}
