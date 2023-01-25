using Delegate_CSharp;

public class Program
{
    public delegate void RectangleDelegate(decimal width, decimal height);
    private static void Main(string[] args)
    {
        Employee[] employees = new Employee[]
        {
            new Employee{ Id=1,Name="Kassem",Gender="Male",TotalSales=50000m },
            new Employee{ Id=2,Name="Ahmed",Gender="Male",TotalSales=45000m },
            new Employee{ Id=3,Name="Mahmoud",Gender="Male",TotalSales=60000m },
            new Employee{ Id=4,Name="Ebrahim",Gender="Male",TotalSales=72000m },
            new Employee{ Id=5,Name="Abdo",Gender="Male",TotalSales=24000m },
        };


        /* Using Force
        ReportUsingForce report = new();

        report.ProcessEmployeeWith60000PlusSales(employees);
        report.ProcessEmployeeWith30000MinceSales(employees);
        report.ProcessEmployeeBetween30000And59999(employees);
        */

        /* Using Delegate
        ReportUsingDelegate report = new();

        report.ProcessEmployee(employees, "Employee With $60000 Plus Sales", IsEmployeeWith60000PlusSales);
        report.ProcessEmployee(employees, "Employee Between $30000 And $59999 Sales", IsEmployeeBetween30000And59999);
        report.ProcessEmployee(employees, "Employee With $30000 Mince Sales", IsEmployeeWith30000MinceSales);

        static bool IsEmployeeWith60000PlusSales(Employee employee) => employee.TotalSales >= 60000m;
        static bool IsEmployeeBetween30000And59999(Employee employee) => employee.TotalSales >= 30000m && employee.TotalSales < 60000m;
        static bool IsEmployeeWith30000MinceSales(Employee employee) => employee.TotalSales < 30000m;

        //Using Anonymous Delegate

        report.ProcessEmployee(employees, "Employee With $60000 Plus Sales", delegate (Employee employee) { return employee.TotalSales >= 60000m; });
        report.ProcessEmployee(employees, "Employee Between $30000 And $59999 Sales", delegate (Employee employee) { return employee.TotalSales >= 30000m && employee.TotalSales < 60000m; });
        report.ProcessEmployee(employees, "Employee With $30000 Mince Sales", delegate (Employee employee) { return employee.TotalSales < 30000m; });//Using Anonymous Delegate

        //Using Lambda Expression

        report.ProcessEmployee(employees, "Employee With $60000 Plus Sales", (Employee employee) => employee.TotalSales >= 60000m);
        report.ProcessEmployee(employees, "Employee Between $30000 And $59999 Sales", (Employee employee) => employee.TotalSales >= 30000m && employee.TotalSales < 60000m);
        report.ProcessEmployee(employees, "Employee With $30000 Mince Sales", (Employee employee) => employee.TotalSales < 30000m);

        //Using Short Lambda Expression

        report.ProcessEmployee(employees, "Employee With $60000 Plus Sales", e => e.TotalSales >= 60000m);
        report.ProcessEmployee(employees, "Employee Between $30000 And $59999 Sales", e => e.TotalSales >= 30000m && e.TotalSales < 60000m);
        report.ProcessEmployee(employees, "Employee With $30000 Mince Sales", e => e.TotalSales < 30000m);
        */

        RectangleHelper helper = new();

        /* Using Force 
        helper.GetArea(10, 5);
        helper.GetPerimeter(10, 5);
        */

        // Using Malticast Delegate
        RectangleDelegate rectangleDelegate = helper.GetArea;
        rectangleDelegate += helper.GetPerimeter;

        rectangleDelegate(10, 6);
    }
}

