// Fatiamento - Slincing 
//Dica - Index Index -1

using System.Linq;

List<string> lista = new List<string> { "Python", "Java", "C#", "PHP", "SQL" };

Console.WriteLine(string.Join(", ", lista));

Console.WriteLine(string.Join(", ", lista[1..]));
Console.WriteLine(string.Join(", ", lista[2..]));
Console.WriteLine(string.Join(", ", lista[3..]));

Console.WriteLine("\n--------------------------------------------------\n");

// Sem fatia[..final -1]
List<string> nomes = new List<string> { "Camilly", "Alexo", "Rafa", "Aninha", "Mario" };

// Com fatiamento
Console.WriteLine(string.Join(", ", nomes[..4]));
Console.WriteLine(string.Join(", ", nomes[..3]));
Console.WriteLine(string.Join(", ", nomes[..2]));

Console.WriteLine("\n--------------------------------------------------\n");

// Fatia[Início..Final -1]
List<string> lista2 = new List<string> { "Python", "Java", "C#", "PHP", "SQL" };

// Sem Fatia[Início..Final -1]
Console.WriteLine(string.Join(", ", lista2));

Console.WriteLine(string.Join(", ", lista2[0..3]));
Console.WriteLine(string.Join(", ", lista2[1..4]));
Console.WriteLine(string.Join(", ", lista2[2..5]));

Console.WriteLine("\n--------------------------------------------------\n");

//Armazenar uma fatia
List<string> times = new List<string> { "Vasco", "São Paulo", "Palmeiras", "Corinthians", "Santos", "São Bento" };

List<string> fatia1 = times[4..];
List<string> fatia2 = times[..4];
List<string> fatia3 = times[1..5];

Console.WriteLine(string.Join(", ", fatia1));
Console.WriteLine(string.Join(", ", fatia2));
Console.WriteLine(string.Join(", ", fatia3));

Console.ReadKey();