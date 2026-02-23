
namespace OPPConcepts.Backend;

public class ComissionEmployee : Employee

{
    // Fields
    private float _comissionPercent;
    private decimal _sales;

    // Constructors
    public ComissionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, float comissionPercent, decimal sales) : base(id, firstName, lastName, isActive, bornDate, hireDate)
    {
        ComissionPercent = comissionPercent;
        Sales = sales;
    }


    //Properties

    public float ComissionPercent
    {
        get => _comissionPercent;
        set => _comissionPercent = ValidateComissionPercent(value);
    }
    public decimal Sales
    {
        get => _sales;
        set => _sales = ValidateSales(value);
    }

    //Methods
    public override string ToString() => base.ToString() + $"\n\t" +
        $"Comission percent: {ComissionPercent,20:P2}\n\t" +
        $"Sales............: {Sales,20:C2}";

    public override decimal GetValueToPay() => (decimal)ComissionPercent * Sales;

    private float ValidateComissionPercent(float ComissionPercent)
    {
        if(ComissionPercent < 0 || ComissionPercent > 1)
        {
            throw new ArgumentOutOfRangeException(nameof(ComissionPercent),$"Commission percent must be between 0 and 1");
        }
        return ComissionPercent;
    }
    private decimal ValidateSales(decimal Sales)
    {
        if (Sales < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(Sales), $"Sales must be greater than  or equal to 0");
        }
        return Sales;
    }
   


}