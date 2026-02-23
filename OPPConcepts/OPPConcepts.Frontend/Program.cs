using OPPConcepts.Backend;
using System;
using System.Linq.Expressions;


try
{

    var employees = new List<Employee>();
    decimal payroll = 0;
    var employee1 = new SalaryEmployee(2232, "Juan ", "Lopera", true, new Date(1994, 9, 24), new Date(2017, 9, 24), 2000000);
    employees.Add(employee1);
    var employee2 = new SalaryEmployee(2233, "Jose ", "granda", true, new Date(1994, 2, 28), new Date(2015, 9, 24), 2300000);
    employees.Add(employee2);
    var employee3 = new HourlyEmployee(2234, "Jose ", "peña", true, new Date(1901, 5, 28), new Date(2019, 9, 11), 15000, 123);
    employees.Add(employee3);
    var employee4 = new HourlyEmployee(2235, "Juaquin ", "peña", true, new Date(1800, 5, 27), new Date(2019, 9, 11), 10000, 3);
    employees.Add(employee4);
    var employee5 = new ComissionEmployee(2236, "camilo ", "hernandez", true, new Date(1994, 9, 24), new Date(2026, 4, 11), 0.03f, 300000000);
    employees.Add(employee5);
    var employee6 = new ComissionEmployee(2237, "Julian ", "hernandesz", true, new Date(1991, 4, 27), new Date(2018, 9, 17), 0.02f, 250000000);
    employees.Add(employee6);
    var employee7 = new BaseCommisionEmployee(2236, "mariana ", "hernandez", true, new Date(1902, 5, 24), new Date(2022, 4, 11), 0.012f, 300000000,590000);
    employees.Add(employee7);
    var employee8 = new BaseCommisionEmployee(2237, "cindy ", "hernandesz", true, new Date(2000, 6, 27), new Date(2024, 9, 17), 0.015f, 0,600000);
    employees.Add(employee8);
    foreach (var employee in employees)
    {
        Console.WriteLine(new string('_', 47));
        Console.WriteLine(employee);
        payroll += employee.GetValueToPay();
    }
    Console.WriteLine(new string('=', 47));
    Console.WriteLine($"Payroll...................:{payroll,20:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

