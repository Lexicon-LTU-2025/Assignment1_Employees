namespace Ovning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("Kalle", 2);
            Robot robot2 = new Robot();
            string robotName = robot.GetName();
            robot.Age = 20;
            // robot.SomeField = 30;
            //robot.Salary = 50;
            
          
        }
    }
}
