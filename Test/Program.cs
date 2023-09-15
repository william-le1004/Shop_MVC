internal class Program
{
    
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        test(test:"test");
    }
    public static void test(string? test = null)
    {
        Console.WriteLine(test);
    }
}