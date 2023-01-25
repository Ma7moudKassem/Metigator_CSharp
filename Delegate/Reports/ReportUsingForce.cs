namespace Delegate_CSharp;

public class ReportUsingForce
{
    public void ProcessEmployeeWith60000PlusSales(Employee[] employee)
    {
        Console.WriteLine("Employee With 60000 Plus Sales");
        Console.WriteLine("*******************************");
        foreach (Employee emp in employee)
        {
            if (emp.TotalSales >= 60000m)
                Console.WriteLine($"{emp.Id} | {emp.Name} | {emp.Gender} | {emp.TotalSales}");
        }
        Console.WriteLine("\n\n");
    }
    public void ProcessEmployeeBetween30000And59999(Employee[] employee)
    {
        Console.WriteLine("Employee Between 30000 And 59999");
        Console.WriteLine("********************************");
        foreach (Employee emp in employee)
        {
            if (emp.TotalSales >= 30000m && emp.TotalSales < 60000m)
                Console.WriteLine($"{emp.Id} | {emp.Name} | {emp.Gender} | {emp.TotalSales}");
        }
        Console.WriteLine("\n\n");
    }
    public void ProcessEmployeeWith30000MinceSales(Employee[] employee)
    {
        Console.WriteLine("Employee With 30000 Mince Sales");
        Console.WriteLine("*******************************");
        foreach (Employee emp in employee)
        {
            if (emp.TotalSales < 30000m)
                Console.WriteLine($"{emp.Id} | {emp.Name} | {emp.Gender} | {emp.TotalSales}");
        }
        Console.WriteLine("\n\n");
    }
}
