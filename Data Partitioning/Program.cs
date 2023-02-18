List<int> numbers = new();
for (int i = 1; i <= 50; i++)
    numbers.Add(i);

var numbersChunked = numbers.Chunk(10).ToList();

for (int i = 0; i < numbersChunked.Count; i++)
{
    Console.WriteLine($"\n\n********* Chunk {i} *********\n");
    foreach (var number in numbersChunked[i])
        Console.Write($"[{number}] ");
}