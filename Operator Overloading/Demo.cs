using System.Reflection;

namespace Operator_Overloading
{
    public class Demo
    {
        public static void PrintAssemblies()
        {
            Console.WriteLine($"Executing assemblies {Assembly.GetExecutingAssembly()}");
            Console.WriteLine($"CallingAssembly assemblies {Assembly.GetCallingAssembly()}");
            Console.WriteLine($"EntryAssembly assemblies {Assembly.GetEntryAssembly()}");
        }
    }
}
