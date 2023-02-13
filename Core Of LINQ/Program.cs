//List<int> nums = new() { 1, 2, 3, 4, 5, 6 };

//var result = from n in nums
//             where n % 2 == 0
//             select n;

//result.ToList().ForEach(e => { Console.WriteLine(e); });

using System.Linq;

List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8 };

IEnumerable<int> evenNumbers = numbers.Where(x => x % 2 == 0);
//IEnumerable<int> evenNumbers = Enumerable.Where(numbers, x => x % 2 == 0);

numbers.Add(10);
numbers.Add(12);
numbers.Remove(4);

foreach (int number in evenNumbers)
    Console.WriteLine(number);