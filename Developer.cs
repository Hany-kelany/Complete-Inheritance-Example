namespace Csharp;

public class Developer : Employee
{
    public bool TaskComplete { get; set; }
    private const decimal Ratio = 0.03m;

    public Developer(int id, string? name, decimal loggedHour, decimal wage, bool TaskComplete) : base(id, name, loggedHour, wage)
    {
        this.TaskComplete = TaskComplete;
    }

    protected decimal Bonus()
    {
        if (TaskComplete)
        {
            return BasicSalary() * Ratio;
        }
        return 0;
    }
    protected override decimal TotalSalary()
    {
        return base.TotalSalary() + Bonus();
    }
    public override string ToString()
    {
        return base.ToString() +
            $"\nTaskComplete : ${TaskComplete}" +
            $"\nBasic Salary : {BasicSalary()}" +
            $"\nBonus : {Bonus()}" +
            $"\nTotal Salary : {TotalSalary()}";
    }

}
