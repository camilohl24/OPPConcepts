using OPPConcepts;
using OPPConcepts.Backend;



try
{

    var expenses = new List<IPay>();
    decimal total = 0;
    var employee1 = new SalaryEmployee(2232, "Juan ", "Lopera", true, new Date(1994, 9, 24), new Date(2017, 9, 24), 2000000);
    expenses.Add(employee1);
    var employee2 = new SalaryEmployee(2233, "Jose ", "granda", true, new Date(1994, 2, 28), new Date(2015, 9, 24), 2300000);
    expenses.Add(employee2);
    var employee3 = new HourlyEmployee(2234, "Jose ", "peña", true, new Date(1901, 5, 28), new Date(2019, 9, 11), 15000, 123);
    expenses.Add(employee3);
    var employee4 = new HourlyEmployee(2235, "Juaquin ", "peña", true, new Date(1800, 5, 27), new Date(2019, 9, 11), 10000, 3);
    expenses.Add(employee4);
    var employee5 = new ComissionEmployee(2236, "Camilo ", "hernandez", true, new Date(1994, 9, 24), new Date(2026, 4, 11), 0.03f, 300000000);
    expenses.Add(employee5);
    var employee6 = new ComissionEmployee(2237, "Julian ", "hernandesz", true, new Date(1991, 4, 27), new Date(2018, 9, 17), 0.02f, 250000000);
    expenses.Add(employee6);
    var employee7 = new BaseCommisionEmployee(2236, "Mariana ", "hernandez", true, new Date(1902, 5, 24), new Date(2022, 4, 11), 0.012f, 300000000,590000);
    expenses.Add(employee7);
    var employee8 = new BaseCommisionEmployee(2237, "Cindy ", "hernandez", true, new Date(2000, 6, 27), new Date(2024, 9, 17), 0.015f, 0,600000);
    expenses.Add(employee8);
    var invoice1 = new Invoice(2238, "Aceite 20w-50", new Date(2026, 2, 27), 2, 50000);
    expenses.Add(invoice1);
    var invoice2 = new Invoice(2239, "Bombillo 12 v", new Date(2026, 2, 27), 1, 10000);
    expenses.Add(invoice2);
    foreach (var expense in expenses)
    {
        Console.WriteLine(new string('_', 47));
        Console.WriteLine(expense);
        total += expense.GetValueToPay();
    }
    Console.WriteLine(new string('=', 47));
    Console.WriteLine($"Total......................:{total,20:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

