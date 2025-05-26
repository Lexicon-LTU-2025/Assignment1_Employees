namespace Ovning1;

internal class Employee
{
    public string Name { get; set; }
    public uint Salary { get; }

    public Employee(string name, uint salary)
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