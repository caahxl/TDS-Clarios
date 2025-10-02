// somar dois numeros e coverter para int

Console.Write("Digite o 1º numero:");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o 2º numero: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Resultado: {n1 + n2}");

/* 
 Convert.ToInt16() - Converte para o tipo short
 Convert.ToInt32() - Converte para o tipo int - Padrão
 Convert.ToInt64() - Converte para o tipo long
 Convert.ToBoolean() - Converte para o tipo bool
 Convert.ToDouble() - Converte para o tipo double
*/

Console.WriteLine("\n----------------------------------------\n");

//Armazenar tipo double
Console.Write("Digite um número:");

//Forma correta de se converter
double numero = Convert.ToDouble(Console.ReadLine());

//Outras formas de converter:
int nInteiro = int.Parse("5");
double nDouble = double.Parse("5,99");
float nFloat = float.Parse("5,99");
bool nBool = bool.Parse("5");

//Formas erradas:
//string numero = Convert.ToDouble(Console.ReadLine());
//double numero = Console.ReadLine();

// ------------------------------------------------------------------

// Não é uma boa prática porém há casos específicos que DEVE ser usado.
var numero1 = Console.ReadLine();


