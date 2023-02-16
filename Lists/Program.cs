
Country egypt = new() { Id = 1, Name = "Egypt" };
Country qatar = new() { Id = 2, Name = "Qatar" };
Country yamn = new() { Id = 3, Name = "Yamn" };

Country[] countries = new[]
{
    yamn,
    egypt,
    qatar,
};
List<Country> countriesList = new();

countriesList.AddRange(countries);

Console.WriteLine($"List count = {countriesList.Count}");
countriesList.Add(new());
countriesList.Remove(countriesList[countriesList.IndexOf(yamn)]);
countriesList.Remove(countriesList[countriesList.IndexOf(new() { Id = 2, Name = "Qatar" })]);
Console.WriteLine($"List capacity = {countriesList.Capacity}");
Console.WriteLine($"List count agine = {countriesList.Count}");

foreach (var country in countriesList)
    Console.WriteLine(country.ToString());
class Country
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}\nName : {Name}";
    }
    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash * 701 + Name.GetHashCode();
        hash = hash * 701 + Id.GetHashCode();

        return hash;
    }
    public override bool Equals(object? obj)
    {
        var country = obj as Country;
        if (country is null) return false;


        return this.Name.Equals(country.Name, StringComparison.OrdinalIgnoreCase);
    }
}