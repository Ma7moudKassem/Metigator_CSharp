using System;
using System.Linq.Expressions;

IEnumerable<int> numbers = new int[] { 2, 5, 4, 1, 7, 9, 3, 6, 8 };

//PrintNumbersWithPredicate(e => e % 2 == 0, numbers);

//PrintNumbersWithDelegete(e => e % 2 == 0, numbers);

Action<string> action = Print;
Func<int, int, int> func = Add;

action("Kassem Delegete");

Console.WriteLine(func(5, 10));

void Print(string text) => Console.WriteLine(text);
int Add(int num1, int num2) => num1 + num2;




static void PrintNumbersWithPredicate(Func<int, bool> predicate, IEnumerable<int> numbers)
{
    foreach (int number in numbers.Where(predicate))
    {
        Console.WriteLine(number);
    }
}

static void PrintNumbersWithDelegete(MyFunc<bool, int> filter, IEnumerable<int> numbers)
{
    foreach (int number in numbers)
    {
        if (filter(number))
            Console.WriteLine(number);
    }
}

public delegate TResult MyFunc<out TResult, in T>(T arg);