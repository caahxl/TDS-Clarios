// Operador: + - * /
// Operando 1,2,3...(Valores)


//Operador Unário
// Um operador unário em um operando
int usuario1 = +1;
int usuario2 = -1;

// Operador binário
//Um operador binário trabalha em dois operandos
int x = 2 + 3;
int y  = 5 - 2;

if ( x > y)
{
    Console.WriteLine("x é maior que y");
}
else
{
    Console.WriteLine("x é menor que y");
}

//Operador ternário
//Um operador ternário trabalha em três operandos
string resultado = x > y ? "x é menor que y" : "x é menor que y";
Console.WriteLine(resultado);

Console.WriteLine("---------------------------------------------");

bool valor = true;
Console.WriteLine(valor ? "Verdadeiro" : "Falso");

Console.WriteLine("---------------------------------------------");

int z = 4;
string parImpar = z % 2 == 0
    ? "Par"
    : "Impar";

Console.WriteLine(parImpar);

Console.WriteLine("---------------------------------------------");

bool isVip = true;
double preco = 100.00;
double precoFinal = isVip ? preco * 0.8: preco;

Console.WriteLine($"Preco: {precoFinal}");

Console.WriteLine("---------------------------------------------");

//Operador Ternário Aninhado

int n = 0;
string resp = n > 0
    ? "x é maior que 0" : (n < 0)
    ? "x é menor que 0" : "x é zero";

Console.Write(n > 0 
    ? "x é maior que 0" : (n < 0)
    ? "x é menor que 0" : "x é zero");