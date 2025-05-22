namespace Ovning1;

internal class PayRoll
{
    private List<Employee> _employees;
    public PayRoll()
    {
        _employees = new List<Employee>();
    }

    public void AddEmployee(string name, int salary)
    {
        Employee employee = new Employee(name, salary);
        _employees.Add(employee);
    }
}