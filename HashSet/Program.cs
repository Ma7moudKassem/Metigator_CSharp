//HashSet use HashTable to search 
//SortedSet use linear search

List<Employee> employees = new()
{
    new Employee{ Id = 1, Name = "Kassem", Salary = 5000 },
    new Employee{ Id = 2, Name = "Kassem1", Salary = 5000 },
    new Employee{ Id = 3, Name = "Ahmed", Salary = 5000 }
};

PrintEmployees(employees);

void PrintEmployees(List<Employee> employees)
{
    HashSet<Employee> employeesDonotRepeted = new(employees);
    //foreach (Employee employee in employees)
    //{
    //    Employee employeeToAdd = employee;
    //    if (!employeesDonotRepeted.Contains(employeeToAdd))
    //        employeesDonotRepeted.Add(employeeToAdd);
    //}

    employeesDonotRepeted.ToList().ForEach(e => { Console.WriteLine(e.ToString()); });
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public override string ToString()
        => $"Id: {Id}\n" +
           $"Name: {Name}\n" +
           $"Salary: {Salary}\n\n";

    public override int GetHashCode()
    {
        int hash = 19;
        hash = hash * 319 * this.Name.GetHashCode();
        return hash;
    }
    public override bool Equals(object? obj)
    {
        Employee? employee = obj as Employee;

        if (employee is null) return false;

        return this.Name.Equals(employee.Name);
    }
}