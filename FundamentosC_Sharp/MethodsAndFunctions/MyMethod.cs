static void Main(string[] args)
{
    MyMethod("C#");
}

static void MyMethod(string name)
{
    Console.WriteLine(name);
}

static string ReturnName(string name, string nickName)
{
    return name + " " + nickName;
}

var name = ReturnName("matheus", "mts");
Console.WriteLine(name);