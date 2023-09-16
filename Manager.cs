namespace Csharp;

public class Manager : Employee
{
    private const decimal Allowance = 0.05m;

    public Manager(int id, string? name, decimal loggedHour, decimal wage) : base(id, name, loggedHour, wage)
    {
    }

    protected decimal CalculateAllowance()
    {
        return Math.Round(base.TotalSalary() * Allowance, 2);
    }
    protected override decimal AdditionalHoursSalary()
    {
        return Math.Round(base.AdditionalHoursSalary() + (base.AdditionalHoursSalary() * Allowance), 2);
    }
    protected override decimal TotalSalary()
    {
        return Math.Round(base.TotalSalary() + (base.TotalSalary() * Allowance), 2);
    }

    public override string? ToString()
    {
        return base.ToString() +
            $"\nAllowance : {CalculateAllowance()}";
    }
}
