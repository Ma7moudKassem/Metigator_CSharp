
Console.WriteLine($"Memory usage before MakeSomeCarbadge: {GC.GetTotalMemory(false):N0}");
MakeSomeCarbadge();
Console.WriteLine($"Memory usage before collect: {GC.GetTotalMemory(false):N0}");
GC.Collect();
Console.WriteLine($"Memory usage after collect: {GC.GetTotalMemory(false):N0}");


void MakeSomeCarbadge()
{
    Version v;
    for (int i = 0; i <= 1000; i++)
        v = new();
}