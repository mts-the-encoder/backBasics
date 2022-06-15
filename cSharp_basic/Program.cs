class Program {
    static void Main() {
        string[] names = { "mts", "matheus" };

        string name = "matheus";

        Console.WriteLine(name.Length);
        Console.WriteLine(name.EndsWith("a"));
        Console.WriteLine(name.EndsWith("s"));
        Console.WriteLine(name.Contains("u"));
        Console.WriteLine(name.IndexOf("us"));
    }
}