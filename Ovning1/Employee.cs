namespace Ovning1;

internal class Employee : Object
{
    public string Name { get; set; }
    public uint Salary { get; }

    public SalaryLevel SalaryLevel => Salary < 25000 ? SalaryLevel.Junior : SalaryLevel.Senior;
    //{
    //    get 
    //    {
    //        if(Salary < 25000)
    //        {
    //            return SalaryLevel.Junior;
    //        }
    //        else
    //        {
    //            return SalaryLevel.Senior;
    //        }
    //    }

    //}

    public Employee(string name, uint salary)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
        }
        //Validate
        this.Name = name;
        this.Salary = salary;
    }

   // public string Print() => $"Name: {Name}, Salary {Salary} Salarylevel: {SalaryLevel}";

    public override string ToString() => $"Name: {Name}, Salary {Salary} Salarylevel: {SalaryLevel}";


}