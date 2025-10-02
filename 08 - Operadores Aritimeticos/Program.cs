// Operadores Aritméticos

int n1 = 8;
int  n2 = 4;

//Soma: +
Console.WriteLine($"A soma de n1 + n2 é {n1 + n2}");

//Subtração: - 
Console.WriteLine($"A subtração de n1 - n2 é {n1 -  n2}");

//Divisão: /
Console.WriteLine($"A divisão subtração de n1 / n2 é {n1 / n2}");

//Multiplicação: *
Console.WriteLine($"A multiplicação de n1 * n2 é {n1 * n2}");

// Módulo: %
Console.WriteLine($"O módulo de de n1 % n2 é {n1 % n2}");

Console.WriteLine("\n--------------------------------------------------------\n");

// Potência
int nBase = 2;
int expoente = 4;

//Math.Pow(base, expoente)
double resultado = Math.Pow( nBase, expoente );
Console.WriteLine($"A potencia de 2³ é {resultado}");

Console.WriteLine("\n--------------------------------------------------------\n");

Console.Write("Digite o preço do produto: ");
double preco = double.Parse(Console.ReadLine() );

Console.Write("Digite a quantidade de produtos: ");
int qtd = Convert.ToInt32(Console.ReadLine());

Console.Write($"O {preco} x {qtd} = {preco * qtd}");

Console.WriteLine("\n--------------------------------------------------------\n");

//Ordem de Precedência
//01 - Parenteses
//02 - Potência
//03 - Multiplicação e Divisão
//04 - Divisão e Subtração

//Porcentagem
Console.WriteLine($"15% de 220 é {220 * 0.15}");
Console.WriteLine($"220 + 15% é {220 + (220 * 0.15)}");
Console.WriteLine($"220 - 15% é {220 - (220 * 0.15)}");

//Porcentagem Equivalente:
Console.WriteLine($"220 + 15% é {220 * 1.15}"); // Adionar 15%
Console.WriteLine($"220 - 15% é {220 * 0.85}"); // Subtrair 15%

// Parse: usado para interpretar strings com um formato conhecido e transformá-las em tipos estruturados (ex: string -> JSON).
// Convert: usado para transformar valores entre tipos compatíveis de forma genérica (ex: int -> string, object -> double).
