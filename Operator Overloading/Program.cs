/*

Operator Overloading => User Defiend Type That Can Overload Predefined operators 

var z = x + y ---> (Binary Operator)-> Arthmatics Operators
var z = x > y ---> (Binary Operator)-> Logical Operators
var z != y ---> (unary Operator) -> Boolean Operators

 */

Money m1 = new(10);
Money m2 = new(20);
Money m3 = m1 + m2;
Money m4 = m3 - m1;

bool m5 = m1 > m2;
bool m6 = m1 < m2;

Console.WriteLine(
    $"Money M1 : {m1.Amount}$\n" +
    $"Money M2 : {m2.Amount}$\n" +
    $"Money M3 : M1 + M2 = {m3.Amount}$\n" +
    $"Money M4 : M3 - M1 = {m4.Amount}$\n" +
    $"Money m5 : {m5}\n" +
    $"Money m6 : {m6}\n" +
    $"Money ++m3 : {(++m3).Amount}\n"
    );
public class Money
{
    private decimal amount;
    public decimal Amount => amount;

    public Money(decimal value) =>
        this.amount = Math.Round(value, 2);

    public static Money operator +(Money m1, Money m2) =>
        new Money(m1.Amount + m2.Amount);

    public static Money operator -(Money m1, Money m2)
    {
        if (m1.Amount >= m2.Amount)
            return new Money(m1.Amount - m2.Amount);
        else
            return new Money(m2.Amount - m1.Amount);
    }

    // You must declare less than when you declare greater than
    public static bool operator >(Money m1, Money m2) =>
        m1.Amount > m2.Amount;

    public static bool operator <(Money m1, Money m2) =>
        m1.Amount < m2.Amount;

    // You must decalare not equal when you declare equal
    public static bool operator ==(Money m1, Money m2) =>
        m1.Amount == m2.Amount;
    public static bool operator !=(Money m1, Money m2) =>
        m1.Amount != m2.Amount;

    public static Money operator ++(Money money)
    {
        decimal value = money.Amount;
        return new Money(++value);
    }
    public static Money operator --(Money money)
    {
        decimal value = money.Amount;
        return new Money(--value);
    }
}