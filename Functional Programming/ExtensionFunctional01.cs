namespace FunctionalProgramming;

public static class ExtensionFunctional01
{
    public static IEnumerable<Employee> Filter(IEnumerable<Employee> source, Func<Employee, bool> predicate) //  Func<Employee, bool> predicate =  Predicate<Employee> predicate 
    {
        foreach (var employee in source)
        {
            if (predicate(employee))
            {
                yield return employee;
            }
        }
    }

    public static void Print<T>(IEnumerable<T> source, string title)
    {
        if (source == null)
            return;
        Console.WriteLine();
        Console.WriteLine("┌───────────────────────────────────────────────────────┐");
        Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
        Console.WriteLine("└───────────────────────────────────────────────────────┘");
        Console.WriteLine();
        foreach (var item in source)
            Console.WriteLine(item);
    }

    public static IEnumerable<T> Partitaining<T>(this IEnumerable<T> source, int page = 1, int size = 10) where T : class
    {
        if (source is null || size <= 0 || page <= 0)
            throw new ArgumentNullException(nameof(source));

        var result = source.Chunk(size).ToList();

        return result[page].ToList();
    }

}
