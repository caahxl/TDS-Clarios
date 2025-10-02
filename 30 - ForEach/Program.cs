// Estrutura de repetição For Each - Itera sobre todos os elementos de uma coleção (como arrays ou listas) sem precisar de especificar limites ou um índice. 

//Repetição sem For Each
int[] arr = { 1, 2, 3, 4, 5 };

Console.WriteLine(arr[0] * 2);
Console.WriteLine(arr[1] * 2);
Console.WriteLine(arr[2] * 2);
Console.WriteLine(arr[3] * 2);
Console.WriteLine(arr[4] * 2);

Console.WriteLine("\n----------------------\n");

// Repetição com For Each

foreach (int numero in arr)
    Console.WriteLine(numero * 2);

Console.WriteLine("\n----------------------\n");

// For Each com múltiplas linhas

foreach (int numero in arr)
{
    Console.WriteLine($"Número atual: {numero}");
    Console.WriteLine($"Dobro do número atual: {numero * 2}");
    Console.WriteLine();
}

Console.WriteLine("\n----------------------\n");

// For Each com If/Else

foreach (int numero in arr)
{
    if (numero % 2 == 0)
        Console.WriteLine($"O número: {numero} é par");
    else
        Console.WriteLine($"O número: {numero} é ímppar");
}

Console.WriteLine("\n----------------------\n");

// For Each com String

string palavra = "Sapiu";

foreach (char letra in palavra)
{
    Console.Write(letra);
    Console.Write(letra * 1);
    Console.WriteLine(Char.ToUpper(letra));
}

Console.WriteLine("\n----------------------\n");

int acumulador = 0;

foreach (int numero in arr)
    acumulador =+ numero;
// Equivalente a:
// acumulador = acumulador + numero;

Console.WriteLine($"Acumulador: {acumulador}");

Console.ReadKey();