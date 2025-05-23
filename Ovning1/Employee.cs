namespace Ovning1;

internal class Employee
{
    public string Name { get; set; }
    public int Salary { get; }

    public Employee(string name, int salary)
    {
        //Validate
        this.Name = name;
        this.Salary = salary;
    }

    public string Print()
    {
        return $"Name: {Name}, Salary {Salary}";
    }
}