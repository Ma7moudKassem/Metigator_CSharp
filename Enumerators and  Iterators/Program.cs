using System.Collections;

FiveIntegersNumbers fiveIntegers = new(1, 2, 3, 4, 5);
foreach (int item in fiveIntegers)
    Console.WriteLine(item);



public class FiveIntegersNumbers : IEnumerable
{
    int[] values;
    public FiveIntegersNumbers(int n1, int n2, int n3, int n4, int n5)
    {
        values = new[] { n1, n2, n3, n4, n5 };
    }

    public IEnumerator GetEnumerator()
    {
        foreach (var item in values)
            yield return item;
    }
}