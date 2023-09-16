namespace Csharp;

public class Program
{
    static void Main(string[] args)
    {
        ////Object Initializer
        //Manager manager = new Manager()
        //{
        //    Id = 1000,
        //    Name = "Ahmed",
        //    LoggedHour = 176,
        //    Wage = 10
        //};
        //Sales sales = new Sales()
        //{
        //    Id = 1001,
        //    Name = "MOHAMED",
        //    LoggedHour = 176,
        //    Wage = 8,
        //    Commision = 0.05m,
        //    VolumeSale = 10000
        //};
        //Miantainance miantainance = new Miantainance()
        //{
        //    Id = 1002,
        //    Name = "Omnia",
        //    LoggedHour = 185,
        //    Wage = 9
        //};
        //Developer developer = new Developer()
        //{
        //    Id = 1003,
        //    Name = "Hany",
        //    LoggedHour = 180,
        //    Wage = 14,
        //    TaskComplete = true
        //};

        //Employee[] employees = { manager, sales, miantainance, developer };

        //foreach (Employee employee in employees)
        //{
        //    Console.WriteLine("*--*--**--*-*-*-*-*-*-*-*-*-**--**");
        //    Console.WriteLine(employee.GetType().ToString().Replace("Csharp.", ""));
        //    Console.WriteLine(employee);
        //}

        //Adding Constructors and passing Values 
        Manager manager = new Manager(1000, "Hany", 176, 10);
        Sales sales = new Sales(1001, "Hany", 180, 9, 0.05m, 10000m);
        Miantainance miantainance = new Miantainance(1002, "Hany Main", 176, 9);
        Developer developer = new Developer(1003, "Hany", 180, 14, true);


        Employee[] employees = { manager, sales, miantainance, developer };

        foreach (Employee employee in employees)
        {
            Console.WriteLine("*--*--**--*-*-*-*-*-*-*-*-*-**--**");
            Console.WriteLine(employee.GetType().ToString().Replace("Csharp.", ""));
            Console.WriteLine(employee);
        }

    }
}
