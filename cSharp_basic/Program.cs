Console.Write("Digite seu nome: ");
string name = Console.ReadLine();

Console.WriteLine($"Olá {name}");  
 
Console.Write("Digite seu ano de nascimento: ");
int year = int.Parse(Console.ReadLine());   
int age = 2022 - year;
Console.WriteLine($"Sua idade é {age}");