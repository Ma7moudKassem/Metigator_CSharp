//var article = "Dot NET is a free cross-platform and open source developer platform" +
//              "for building many different types of applications" +
//              "With Dot NET you can use multiple languages and libraries" +
//              "to build for web and IoT";

//Dictionary<char, List<string>> map = new();

//foreach (string word in article.Split())
//{
//    foreach (char ch in word)
//        if (!map.ContainsKey(ch))
//            map.Add(ch, new List<string> { word });
//        else
//            map[ch].Add(word);
//}

//Console.WriteLine();

List<Employee> employees = new()
{
    new Employee{Id=1 , Name="Mahmoud",ReportTo=100 },
    new Employee{Id=2 , Name="Kassem",ReportTo=150 },
    new Employee{Id=3 , Name="Ahmed",ReportTo=200 },
    new Employee{Id=4 , Name="Hussien",ReportTo=500 },
    new Employee{Id=5 , Name="Mohamed",ReportTo=null },
};

var managers = employees.GroupBy(e => e.ReportTo).ToDictionary(e => e.Key ?? -1, e => e.ToList());
var managersToLookUp = employees.ToLookup(e => e.ReportTo).ToDictionary(e => e.Key ?? -1, e => e.ToList());

foreach (var manager in managers)
{
    if (manager.Key == -1) continue;
    Console.Write($"{manager.Key}");
    manager.Value.ForEach(e => { Console.WriteLine($"\t\t{e.Name}"); });
}

Console.WriteLine();
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? ReportTo { get; set; }
}