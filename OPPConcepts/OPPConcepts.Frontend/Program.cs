using OPPConcepts.Backend;
using System;
using System.Linq.Expressions;


try
{
    var date1 = new Date();
    var date2 = new Date(2026, 2, 29);
    var date3 = new Date(2012, 11, 30);
    var date4 = new Date(2026,12,12);

    Console.WriteLine($"Este año es {date1}");
    Console.WriteLine($"Este año es {date2}");
    Console.WriteLine($"Este año es {date3}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message );
}

