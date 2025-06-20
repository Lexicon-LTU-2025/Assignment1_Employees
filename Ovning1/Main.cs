﻿using Employees.Abstractions;
using Employees.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning1;
internal class Main
{
    private IUI _ui;
    private IPayRoll _payRoll;

    public Main(IUI ui, IPayRoll payRoll)
    {
        this._ui = ui;
        this._payRoll = payRoll;
    }

    public void Run()
    {
        //var rob = new Robot("", 25);
        //rob.Age = 35;
        //var robotAge = rob.Age;

        var isOverFourChar = Util.AskForString("Enter something with 5 characters or more", _ui, s => s.Length > 4);
        var isBetween2and6 = Util.AskForUInt("Between 2 and 6", _ui, 2, 6);


        //rob.SalaryLevel = SalaryLevel.Senior;
        //SalaryLevel robsSalarylevel = rob.SalaryLevel;


        SeedData();

        do
        {
            ShowMainMeny();

            string input = _ui.GetInput();

            switch (input)
            {
                case MenyHelpers.Add:
                    AddEmployee();
                    break;
                case MenyHelpers.Print:
                    PrintEmployees();
                    break;
                case MenyHelpers.Quit:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

        } while (true);
    }

    private void AddEmployee()
    {
        string name = Util.AskForString("Name", _ui);
        uint salary = Util.AskForUInt("Salary", _ui);

        _payRoll.AddEmployee(name, salary);

    }

    private void PrintEmployees()
    {
        IEnumerable<Employee> employees = _payRoll.GetEmployees();

        foreach (var employee in employees)
        {
            _ui.Print(employee.ToString());
        }
    }

    private void ShowMainMeny()
    {
        _ui.Print($"{MenyHelpers.Add}. Add");
        _ui.Print($"{MenyHelpers.Print}. Print");
        _ui.Print($"{MenyHelpers.Quit}. Quit");
    }

    private void SeedData()
    {
        _payRoll.AddEmployee("Nisse", 12);
        _payRoll.AddEmployee("Kalle", 60);
        _payRoll.AddEmployee("Anna", 12);
        _payRoll.AddEmployee("Olle", 500);
     //   _payRoll.AddEmployee("   ", 500);

    }
}
