



using Employees.Abstractions;
using Employees.Helpers;
using Ovning1.UI;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Ovning1;

internal class Program
{
    private static IPayRoll _payRoll = new PayRoll();
    private static IUI _ui = new ConsoleUI();

    static void Main(string[] args)
    {

        IPayRoll payRoll = new PayRoll();
        IUI ui = new ConsoleUI();
        Main main = new Main(ui, payRoll);

        //Util.AskForString("Over 10 char", ui, s =>
        //{
        //    //..
        //    //..
        //    var res = s.Length > 10;
        //    return res;
        //});



        try
        {

            main.Run();

        }
        catch (ArgumentNullException)
        {

            //...
           
        }
        catch (ArgumentException)
        {
            //..
        }
        catch (Exception ex)
        {

        }
        finally
        {
            main.Run();
        }




    }
}
