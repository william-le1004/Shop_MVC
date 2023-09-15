internal class Program
{
    static void Main(string[] args)
    {
        var r = (sum: "hello", count: 0);
        //for
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(1);
        list.Add(1);
        list.Add(1);
        list.ForEach(x => list.Add(x));
        list.ForEach(Console.WriteLine);
    }
}