//Formas de se declarar uma string
//Apelidos String
using System.Globalization;

string s1 = "C#";
String s2 = "C#";

//Apelido Short
int i1 = 0;
Int16 i2 = 0;

//Apelido Int
int n1 = 0;
Int32 n2 = 0;

//Apelido Long
long l1 = 0;
Int64 l2 = 0;

Console.WriteLine(s1);
Console.WriteLine(s2);

if (s1 == s2)
    Console.WriteLine("As strings são iguais");
else
    Console.WriteLine("As string não são iguais");

Console.WriteLine("\n--------------------------------------------------\n");

//Métodos de String
//ToUpper() - Converte as letras para maiúscula
Console.WriteLine("c# tem upper!".ToUpper());

//ToLower() - Converte as letras para minúsculas
string lower = "C# TAMBÉM TEM LOWER";
Console.WriteLine(lower.ToLower());

//Converter a primeira letra  de cada palavra para maiúscula
string nome = "thiago ferreira";
nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome);
Console.WriteLine(nome);

//Replace - Subistitui um texto por outro
string ling = "Programação em Python";
Console.WriteLine(ling);
Console.WriteLine(ling.Replace("Python", "C#"));

//Remove - Remove um trecho sa string
string rev1 = "0123456789";
string rev2 = "C#--------";
string rev3 = "C#--- É TOP";

Console.WriteLine(rev2.Remove(2));
Console.WriteLine(rev3.Remove(2, 3));

// Substring - Mantém parte da string
string sub1 = "0123456789";
string sub2 = "----C#----";
string sub3 = "--Python--";

Console.WriteLine(sub2.Substring(4,2));
Console.WriteLine(sub3.Substring(2, 6));

//IndexOf - Retorna a posição inicial do caracter informado
string ind = "Programação em C#";
Console.WriteLine(ind);
Console.WriteLine(ind.IndexOf("#"));
Console.WriteLine(ind.IndexOf("@"));

Console.WriteLine("\n--------------------------------------------------\n");

//IndeOf com a Estrutura Condicional If
string dds =  "Seg, Ter, Qua, Qui, Sex";
Console.WriteLine("Digite um dia da semana:");
string resposta = Console.ReadLine();

if (dds.IndexOf(resposta) >= 0)
    Console.WriteLine("Dia localizado");
else
    Console.WriteLine("Dia inválido");

//Length - Comprimento de uma string
//Length é uma propriedade
Console.WriteLine("Python");
Console.WriteLine("Python".Length);

Console.WriteLine("\n--------------------------------------------------\n");

//Operaodor + : Concatena duas ou mais string
string letra1 = "A";
string letra2 = "B";
string letra3 = "C";

Console.WriteLine(letra1 + "B" + letra3);
Console.WriteLine("A" + letra2 + "C");

//MÉTODOS ESTÁTICOS
//Join - Concatena strings utilizando o delimitador informado
//string.Join(Delimitador, Texto1, Texto2, ...)

Console.WriteLine(string.Join(", ", letra1, letra2, letra3));
Console.WriteLine(string.Join(". ", letra1, letra2, letra3));
Console.WriteLine(string.Join(" ", letra1, letra2, letra3));

// IsNullOrEmpty - Verifica se string é
// nula
// vazia (sem caracteres)
//Apenas com espaço
//Retorna true ou false
string teste1 = "";
string teste2 = null;
string teste3 = " ";

Console.WriteLine(string.IsNullOrEmpty(teste1)); //true
Console.WriteLine(string.IsNullOrEmpty(teste2)); //true
Console.WriteLine(string.IsNullOrEmpty(teste3)); //true