/* Sintaxe para criar variável
 TipoDaVariavel NomeDaVariavel = Valor*/

//Variáveis 
string nome = "Camilly";
int inteiro = 5;
bool verdadeiro = true;
bool falso = false;

// Mas se utiliza mas em C# double.
double flutuante = 10.5;


// char - Um único caracter, delimitado por aspas simples
char letra = 'C';

// float - Número de ponto flutuante, sempre terminado com f
float flutuante2 = 1.0f;

// decimal - Número Decimal, sempre terminado com m
decimal flutuante3 = 1.0m;

//Armazenar entrada de um úsuario
Console.WriteLine("Digite o nome da sua escola:");
 string escola = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Nome da escola");
Console.WriteLine(escola);