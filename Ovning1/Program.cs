


namespace Ovning1
{
    internal class Program
    {
        private static PayRoll payRoll = new PayRoll();

        static void Main(string[] args)
        {
            //Employee kalle = new Employee("Kalle", 25000);
            //payRoll.AddEmployee(kalle);

            //var employees = payRoll.GetEmployees();
            //Console.WriteLine(employees[0].Name);

            ////employees = null;
            ////employees = new List<Employee>();
            //// employees.Add(new Employee("Anna", 35000));

            //employees[0].Name = "Anna";

            //var after = payRoll.GetEmployees();
            //Console.WriteLine(after[0].Name);





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
            IEnumerable<Employee> employees = payRoll.GetEmployees();
            //employees[0].Name = "Anna";
            //employees.Add(new Employee("Nisse", 35));

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
}
