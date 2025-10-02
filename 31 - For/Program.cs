// For - Gera uma sequência de números

// Sintaxe - for(início; final; intervalo)
// Pode ser usado para repetir um bloco de código um número fixo de vezes, com ou sem uma coleção. 

for (int i = 1; i < 5; i = i + 1)
    Console.WriteLine($"Valor atual: {i}");

Console.WriteLine("\n-----------------------------------\n");

/* Formas de incrementar uma variavel - Todos fazem a mesma coisa em um contexto simples: incrementar a variável em 1.
i = i + 1
i += 1
i ++
*/

// Incrementar com i++: Exemplo
for (int i = -5; i <= 0; i++) //+1
    Console.WriteLine($"Valor atual: {i}");

Console.WriteLine("\n-----------------------------------\n");

// For com valores regressivos
for (int i = 5; i > 0; i--)
    Console.WriteLine($"Valor atual: {i}");

Console.WriteLine("\n-----------------------------------\n");

// For com ReadLine - Exemplo
Console.WriteLine("Digite um número de parada:");
int final = int.Parse(Console.ReadLine() );

for (int i = 1; i <= final; i++)
    Console.WriteLine($"Valor atual: {i}");

Console.WriteLine("\n-----------------------------------\n");

// Como percorrer uma coleção usando For
string[] arr = { "A", "B", "C", "D" };
int tamanhoArr = arr.Length;

Console.WriteLine($"Tamnho do array: {tamanhoArr}");

for (int i = 0; i < tamanhoArr; i++)
{
    Console.WriteLine($"Índice atual: {i}");
    Console.WriteLine($"Valor atual do array: {arr[i]}");
    Console.WriteLine();
}