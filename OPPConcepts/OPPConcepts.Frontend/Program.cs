using OPPConcepts.Backend;
using System;
using System.Linq.Expressions;


try
{
    var date1 = new Date();
    var date2 = new Date(1, 3, 32);
    var date3 = new Date(1, 12, 12);
    var date4 = new Date(2026,12,12);

    Console.WriteLine($"Este año es {date1}");
    Console.WriteLine($"Este año es {date2}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message );
}

