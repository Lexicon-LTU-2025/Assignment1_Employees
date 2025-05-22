namespace Ovning1;

//Publik synlig för alla, Internal synlig inne i den här Assemblyn (Det här programmet)
internal class Robot
{
    //Struktur på en klass
    // 1. privata fält
    // 2. publika properties (privata properties make no sense)
    // 3. Konstruktor/Konstruktorer
    // 4. Metoder

    //1. privata fält
    private string _name;

    private int _age;

    //2. Publika properties
    //När vi försöker sätta ett värde(set) till mindre än 0 sätter vi _age till 0.
    //Returnerar värdet på det bakomliggande privata fältet _age (get)
    //Snippet propfull för att skapa ett property med bakomliggande fält.
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

    //2. Autoproperty om du inte behöver validera eller göra något, dvs skriva kod i gettern eller settern
    //Använd den här syntaxen istället för publika fält!
    //Här med private set värdet kan enbart sättas inifrån den här klassen
    //Snippet prop
    public int Salary { get; private set; }

    //Statiskt metod gemensamt för alla instanser av klassen Robot.
    //Måste anropas med Robot.Count()
    //Kan inte använda sig av instans data tex _age eller GetName()
    public static  void Count()
    {
       // int x = _age;
    }

    //  public int SomeField;

    //3. Konstruktor
    //Snippet ctor
    //Det här en default konstruktor den finns även om den inte syns.
    //Tills man skapar en annan konstuktor. Då måste man skriva ut den manuellt för att få tillgång till den.
    //public Robot()
    //{

    //}

    //Konstruktor med parametrar
    //En konstruktor har aldrig någon retur typ och heter samma sak som klassen
    //Konstruktorn körs direkt när man skapar ett ny instans av klassen med nyckelordet new
    //Tex Robot robot = new Robot("Kalle", 25);
    //Nu måste vi alltid skicka med ett namn och age för att få skapa en ny Robot

    public Robot(string name, int age)
    {
        _name = name;
        Age = age;
    }

    //4. Metoder
    //Så här gör man oftast i andra språk tex Java. När vi vill hämta och sätta värden.
    //I C# används nästan alltid properties istället om det inte är så att det är mer komplex logik.
    //Tex att man anropar andra metoder och klasser.
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