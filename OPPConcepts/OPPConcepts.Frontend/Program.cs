using OPPConcepts.Backend;
using System;
using System.Linq.Expressions;


try
{

    var employee1 = new SalaryEmployee(109, "Juan ", "Lopera", true, new Date(1994, 9, 24), new Date(2017, 9, 24), 2000000);
    var employee2 = new SalaryEmployee(2234, "Jose ", "granda", true, new Date(1994, 2, 28), new Date(2015, 9, 24), 2300000);

    Console.WriteLine(employee1);
    Console.WriteLine(employee2);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message );
}

