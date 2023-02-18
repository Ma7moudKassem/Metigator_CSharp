using FunctionalProgramming;
using Pagination;
using System.Security.Cryptography;

int page = 1;
int size = 10;

Console.WriteLine("result by page:");
if (int.TryParse(Console.ReadLine(), out int resultPerPage))
    size = resultPerPage;
Console.WriteLine("Page No.:");

if (int.TryParse(Console.ReadLine(), out int pageNum))
    page = pageNum;

IEnumerable<Employee> employees = Repository.LoadEmployees();

IEnumerable<Employee> result = employees.Paginate(page, size);

int resultCount = result.Count();

int startRecord = ((page - 1) * size) + 1;
int endRecord =
    resultCount < size ?
    startRecord + resultCount - 1 :
    size * (page - 1) + size;

result.Print($"Show employees {startRecord} - {endRecord}");