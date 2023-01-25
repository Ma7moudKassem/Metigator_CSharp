namespace Delegate_CSharp;

public class ReportUsingDelegate
{
    public delegate bool IllegibleSales(Employee employee);

    public void ProcessEmployee(Employee[] employee, string title,IllegibleSales isLlegibleSales)
    {
        Console.WriteLine(title);
        Console.WriteLine("*******************************************");
        foreach (Employee emp in employee)
        {
            if (isLlegibleSales(emp))
                Console.WriteLine($"{emp.Id} | {emp.Name} | {emp.Gender} | {emp.TotalSales}");
        }
        Console.WriteLine("\n\n");
    }
}
