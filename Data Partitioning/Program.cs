using Data_Partitioning;

List<int> numbers = new();
for (int i = 1; i <= 50; i++)
    numbers.Add(i);

//SkipPartitioning.PrintNumbers(numbers, 10, true);

//Console.WriteLine("\n\n****************************************************\n");

//SkipPartitioning.PrintNumbersByPredicate(numbers, e => e <= 10);

//Console.WriteLine("\n\n************************** Tack Partitioning **************************\n");

//TakePartitioning.PrintNumbers(numbers, 20, true);

//Console.WriteLine("\n\n****************************************************\n");

//TakePartitioning.PrintNumbersByPredicate(numbers, e => e <= 10);

var numbersChunked = numbers.Chunk(10).ToList();

for (int i = 0; i < numbersChunked.Count; i++)
{
    Console.WriteLine($"\n\n********* Chunk {i} *********\n");
    foreach (var number in numbersChunked[i])
        Console.Write($"[{number}] ");
}