using System;
using System.Collections.Generic;
using System.Text;

namespace OPPConcepts.Backend;

public class BaseCommisionEmployee : ComissionEmployee
{
    //Fields
    private decimal _salary;

    // Constructors
    public BaseCommisionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, float comissionPercent, decimal sales, decimal salary) : base(id, firstName, lastName, isActive, bornDate, hireDate, comissionPercent, sales)
    {
        Salary = salary;
    }

    // Properties
    public decimal Salary
    {
        get => _salary;
        set => _salary = ValidateSalary(value);
    }

    //Methods

    public override decimal GetValueToPay() => base.GetValueToPay() + Salary;

    public override string ToString() => base.ToString() + $"\n\t" +
        $"Salary Base......: {Salary,20:C2}";

    private decimal ValidateSalary(decimal s)
    {
        if (s < 500000)
        {
            throw new ArgumentOutOfRangeException(nameof(s), $"Salary base must be greater than or equal to $500000");
        }
        return s;
    }
}
