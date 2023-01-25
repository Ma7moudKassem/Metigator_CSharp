namespace Delegate_CSharp;

public class RectangleHelper
{
    public void GetArea(decimal width, decimal height)
    {
        decimal result = width * height;
        Console.WriteLine($"Area = {width} * {height} = {result}");
    }
    public void GetPerimeter(decimal width, decimal height)
    {
        decimal result = 2 * (width + height);
        Console.WriteLine($"Perimeter = 2 * ({width} + {height}) = {result}");
    }
}
