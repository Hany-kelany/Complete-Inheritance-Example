namespace Csharp;

public class Miantainance : Employee
{
    private const int Hardship = 100;

    public Miantainance(int id, string? name, decimal loggedHour, decimal wage) : base(id, name, loggedHour, wage)
    {
    }

    protected override decimal TotalSalary()
    {
        return Math.Round(base.TotalSalary() + Hardship, 2);
    }

    public override string? ToString()
    {
        return base.ToString() +
               $"\nHardship : {Hardship}";
    }
}
