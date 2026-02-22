using System;
using System.Collections.Generic;
using System.Text;

namespace OPPConcepts.Backend;

public class HourlyEmployee: Employee
{
    private decimal _hourlyValue;
    private float _workingHours;



    public HourlyEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, decimal hourlyValue, float workingHours) : base(id, firstName, lastName, isActive, bornDate, hireDate)
    {
        HourlyValue = hourlyValue;
        WorkingHours = workingHours;
    }

    public decimal HourlyValue {
        get => _hourlyValue;
        set => _hourlyValue = ValidateHourlyValue(value); 
    }
    public float WorkingHours {
        get => _workingHours;
        set => _workingHours =ValidateWorkingHours(value); 
    }

    public override decimal GetValueToPay() => (decimal)WorkingHours * HourlyValue;


    public override string ToString() => base.ToString() + $"\n\t" +
        $"Hourly Value.....: {HourlyValue,20:C2}\n\t" +
        $"Working Hours....: {WorkingHours,20:N2}";

    private decimal ValidateHourlyValue(decimal hourlyValue)
    {
        if (hourlyValue < 10000)
        {
            throw new ArgumentOutOfRangeException(nameof(hourlyValue), $"Hourly value must be greater than or equal to $10000. ");
            
        }
        return hourlyValue;
    }
    private float ValidateWorkingHours(float workingHours)
    {
        if (workingHours < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(workingHours), $"Working Hours must be greater than or equal to 0. ");

        }
        return workingHours;
    }


}
