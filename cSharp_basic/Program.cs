Console.Write("Digite seu nome: ");
string name = Console.ReadLine();

Console.WriteLine($"Olá {name}");  
 
Console.Write("Digite seu ano de nascimento: ");
int year = int.Parse(Console.ReadLine());   
int age = 2022 - year;
Console.WriteLine($"Sua idade é {age}");

    if (age >= 18) {
        Console.WriteLine("Você é maior de idade");
    } else if (age.Equals(12)) {
        Console.WriteLine("Você tem 12 anos");
    } else {
        Console.WriteLine("Você ainda é menor de idade");
    }