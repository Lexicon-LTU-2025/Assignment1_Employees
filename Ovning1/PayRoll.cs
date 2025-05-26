
namespace Ovning1;

internal class PayRoll
{
    private List<Employee> _employees;
    public PayRoll()
    {
        _employees = new List<Employee>();
    }

    public void AddEmployee(string name, uint salary)
    {
        Employee employee = new Employee(name, salary);
        _employees.Add(employee);
    }
    public void AddEmployee(Employee emp)
    {
        _employees.Add(emp);
    } 
     
   
    public IEnumerable<Employee> GetEmployees()
    {
        //ToDo: Fix this not good!
        return _employees.ToList();
    }

}