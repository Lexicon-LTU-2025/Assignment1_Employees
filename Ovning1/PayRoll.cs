

namespace Ovning1;

internal interface IPayRoll
{
    void AddEmployee(Employee emp);
    void AddEmployee(string name, uint salary);
    IEnumerable<Employee> GetEmployees();
}

internal class PayRoll : IPayRoll
{
    private List<Employee> _employees;

   // public AddMess AddMess { get; set; }

    public PayRoll()
    {
        _employees = new List<Employee>();
    }

    public void AddEmployee(string name, uint salary)
    {
        //.....
        //.Validate
        Employee employee = new Employee(name, salary);
        _employees.Add(employee);
    }
    public void AddEmployee(Employee emp)
    {
        ArgumentNullException.ThrowIfNull(emp, "emp");

        //if (emp is null)
        //{
        //    throw new ArgumentNullException(nameof(emp));
        //}

        _employees.Add(emp);
    }


    public IEnumerable<Employee> GetEmployees()
    {
        //ToDo: Fix this not good!
        return _employees.ToList();
    }

}