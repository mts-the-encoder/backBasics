namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "mts";
            switch (value)
            {
                case "joao": Console.WriteLine("nome é joão");
                    break;
                case "ali": Console.WriteLine("nome é ali"); 
                    break;  
                case "mts": Console.WriteLine("nome encontrado");
                    break;
                case "4": Console.WriteLine("4");
                    break;
                default: Console.WriteLine("nda");
                    break;
            }
        }
    }
}

