// Interpolação
string linguagem = "C#";

Console.WriteLine($"Esse semestre eu estou apredendo {linguagem}");

Console.WriteLine("\n--------------------\n");

// Exibir entrada de dados em uma interpolação

Console.Write("Digite a sua idade: ");
string idade = Console.ReadLine();

Console.WriteLine($"Eu tenho {idade} anos de idade!");

Console.WriteLine("\n--------------------\n");

// Expressões dentro de uma interpolação
int n1 = 14;
int n2 = 15;

Console.WriteLine($"Soma:  {n1 + n2}");

// Arredondamento de valores
double preco = 2.12345;

// Um argumento, valor decimal que eu quero arredondar
// Segundo argumento, quantas casa decimais deverão ser arredondadas
Console.WriteLine("Exemplos de arredondamento:");
Console.WriteLine(preco);
Console.WriteLine(Math.Round(preco, 1));
Console.WriteLine(Math.Round(preco, 2));

Console.WriteLine("Exemplos de arredondamento:");
Console.WriteLine($"{preco)");
Console.WriteLine($"{preco:#.##}"); // # Significa casa decimal
Console.WriteLine($"{preco:f2}"); // float
Console.WriteLine($"{preco:c2}"); // moeda local

Console.WriteLine("\n--------------------\n");

// Converter números para string.
Console.WriteLine("Converter números para string:");
Console.WriteLine(preco.ToString());
Console.WriteLine(preco.ToString("F2"));
Console.WriteLine(preco.ToString("C2"));

