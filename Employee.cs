namespace Csharp;

public class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal LoggedHour { get; set; }
    public decimal Wage { get; set; }
    private const int MinimumHourRequired = 176;
    private const decimal Rate = 1.25m;

    public Employee(int id, string? name, decimal loggedHour, decimal wage)
    {
        Id = id;
        Name = name;
        LoggedHour = loggedHour;
        Wage = wage;
    }

    protected decimal BasicSalary()
    {
        return Math.Round(MinimumHourRequired * Wage, 2);
    }

    protected virtual decimal AdditionalHoursSalary()
    {
        var AddtionalHour = (LoggedHour - MinimumHourRequired) > 0 ? (LoggedHour - MinimumHourRequired) : 0;
        return Math.Round(AddtionalHour * Wage * Rate, 2);
    }
    protected virtual decimal TotalSalary()
    {
        return Math.Round(BasicSalary() + AdditionalHoursSalary(), 2);
    }

    public override string? ToString()
    {
        return $"Id : {Id}" +
               $"\nName : {Name}" +
               $"\nLogged Hour : {LoggedHour}" +
               $"\nWage : ${Wage}" +
               $"\nAddtional Hour Salary: {AdditionalHoursSalary()}" +
               $"\nTotal Salary : ${TotalSalary()}";
    }
}
