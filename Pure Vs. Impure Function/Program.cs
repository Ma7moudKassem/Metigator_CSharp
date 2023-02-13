#region goto

/*
repeat:
Console.WriteLine("Enter a number less than 10");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10)
{
    goto repeat;
}
*/

#endregion

#region StatmentAndExpression

/*
Statement must end with semicolne --> (;)

int num; --> Declaration

num = 5; --> Assignment

int num = 10; ---> Initialization (Declaration + Assignment)

expression return value

decimal r = 10;
decimal area = 3.14 * (r * r);

Console.WriteLine(area); ===> method invokation Expression

*/
#endregion

#region PureAndImpure

List<int> nums = new() { 2, 3, 6, 7, 10 };

Print(nums);

void Print(List<int> nums) =>
    nums.ForEach(e => { Console.WriteLine(e); });

void AddInteger(int num) =>
    nums.Add(num);   // impure
void AddIntegerByRefrence(ref int num) =>
    nums.Add(num); //impure

List<int> AddIntegerPure(List<int> numbers, int num)
{
    List<int> result = new(numbers);
    result.Add(num);

    return result;
}


#endregion