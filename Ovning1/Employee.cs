namespace Ovning1;

internal class Employee
{
    public string Name { get; }
    public int Salary { get; }

    public Employee(string name, int salary)
    {
        this.Name = name;
        this.Salary = salary;
    }
}