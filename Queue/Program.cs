Queue<PrintingJob> printingJobs = new();
printingJobs.Enqueue(new PrintingJob("a.docs", 2));
printingJobs.Enqueue(new PrintingJob("b.docs", 2));
printingJobs.Enqueue(new PrintingJob("c.docs", 2));
printingJobs.Enqueue(new PrintingJob("d.docs", 2));
printingJobs.Enqueue(new PrintingJob("e.docs", 2));

Random random = new();
while (printingJobs.Count > 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    PrintingJob printingJob = printingJobs.Dequeue();
    Console.WriteLine($"printing [{printingJob}]");
    Thread.Sleep(random.Next(1, 5) * 1000);
}
Console.WriteLine($"Queue Count = {printingJobs.Count}");

if (printingJobs.TryPeek(out PrintingJob job))
{
    Console.WriteLine(job);
}
class PrintingJob
{
    private readonly string _file;
    private readonly int _copies;

    public PrintingJob(string file, int copies) =>
        (_file, _copies) = (file, copies);

    public override string ToString() =>
        $"{_file} x #{_copies} copies";
}