LinkedList<int> numbers = new();

numbers.AddFirst(10);
numbers.AddAfter(numbers?.First, 20);
numbers.AddLast(30);

numbers.PrintLinkedList();

public static class Extentions
{
    public static void PrintLinkedList(this LinkedList<int> source)
    {
        foreach (int item in source)
        {
            if (source?.Last?.Value != item)
                Console.Write($"{item} --> ");
            else Console.Write($"{item}");
        }
    }
}