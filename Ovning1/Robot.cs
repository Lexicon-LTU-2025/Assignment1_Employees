namespace Ovning1;

internal class Robot
{
    private string _name;

    private int _age;

    public int Age
    {
        get { return _age; }
        set 
        {
            if (value < 0)
            {
                _age = 0;
            }
            else
            {
              _age = value; 
            }
        
        }
    }

      public int Salary { get; private set; }

    public static  void Count()
    {
       // int x = _age;
    }

    //  public int SomeField;

    public Robot(string name, int age)
    {
        _name = name;
        Age = age;
    }


    public string GetName()
    {
       // List<int> list = new();
        return _name;
    }

    public void SetName(string value)
    {
        //Validate
        _name = value;
    }
}