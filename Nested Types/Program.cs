// Nested type ===> type defiend within a class
// internal ===> be public in assembly alone 

Employee employee = new();

Console.WriteLine(employee.EmployeeInsurance.CompanyName);
class Employee
{
    public Employee()
    {
        EmployeeInsurance = new Insurance { PolicyId = 1, CompanyName = "StateLabs" };
    }
    public int Id { get; set; }

    public Insurance EmployeeInsurance { get; set; }

    public class Insurance
    {
        public int PolicyId { get; set; }
        public string CompanyName { get; set; }
    }
}

