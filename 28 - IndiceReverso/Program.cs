// índice Reverso - Operador ^
List<string> lista = new List<string>()
{
   "Maça", 
   "Laranja",
   "Banana",
   "Melão",
   "Abacaxi",
};

Console.WriteLine(string.Join(", ", lista[^1])); // Abacaxi
Console.WriteLine(string.Join(", ", lista[^2])); // Melão
Console.WriteLine(string.Join(", ", lista[^3])); // Banana
Console.WriteLine(string.Join(", ", lista[^4])); // Laranja
Console.WriteLine(string.Join(", ", lista[^5])); // Maça

Console.WriteLine("\n------------------------------------------\n");

//índice Reverso String
string str = "Lógica";

Console.WriteLine(str);
Console.WriteLine(str[^1]); // a
Console.WriteLine(str[^2]); // c
Console.WriteLine(str[^3]); // i
Console.WriteLine(str[^4]); // g
Console.WriteLine(str[^5]); // ó
Console.WriteLine(str[^6]); // L

Console.WriteLine("\n------------------------------------------\n");

// Operação de Fatiamento com índice Reverso

int[] arr = { 10, 20, 30, 40, 50, 60 };

// Pegando os 2 último elemento:
int[] fatia1 = arr[^2..]; //Saída: {50, 60}


// Pegando os 3 último elemento:
int[] fatia2 = arr[^3..]; //Saída: {40, 50, 60}


// Pegando os 4 último elemento:
int[] fatia3 = arr[^4..]; //Saída: {30, 40, 50, 60}

Console.WriteLine(string.Join(", ", fatia1));
Console.WriteLine(string.Join(", ", fatia2));
Console.WriteLine(string.Join(", ", fatia3));

Console.WriteLine("\n------------------------------------------\n");

// Fatiando uma lista usando apenas o índice de Inicio e Fim:

int[] fatia4 = arr[1..^]; //Saída: {20, 30, 40, 50}

// Pegando os 2 último elemento:
int[] fatia5 = arr[1..^2]; // Saída: {20, 30, 40}

Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(string.Join(", ", fatia4));
Console.WriteLine(string.Join(", ", fatia5));

Console.ReadKey();
