namespace Csharp;

public class Sales : Employee
{

    public decimal Commision { get; set; }
    public decimal VolumeSale { get; set; }
    public Sales(int id, string? name, decimal loggedHour, decimal wage, decimal Commision, decimal VolumeSale) : base(id, name, loggedHour, wage)
    {
        this.Commision = Commision;
        this.VolumeSale = VolumeSale;
    }


    protected decimal Bonus()
    {
        if (VolumeSale > 0)
        {
            return Math.Round(VolumeSale * Commision, 2);
        }
        return 0;
    }
    protected override decimal TotalSalary()
    {
        return Math.Round(base.TotalSalary() + Bonus(), 2);
    }
    public override string? ToString()
    {
        return base.ToString() +
            $"\nBonus : {Bonus()}" +
            $"\nCommision : {Commision}" +
            $"\nBasic Salary :{BasicSalary()}";
    }
}
