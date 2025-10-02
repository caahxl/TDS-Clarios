// Formas de se declarar um array em C#

//01 - Array vazio
string[] arrStr = {};
int[] arrInt = {};

//02 - Array com Valores
string[] arrStr2 = {"C#","HTML", "Python"};
int[] arrInt2  = {1, 2, 3};

//Imprimindo os valores do Array
Console.WriteLine(arrStr2);
Console.WriteLine(string.Join(", ", arrStr));

//ATENÇÃO!
//Os Arrays, por padrão não podem adicionar novos elementos
//arrStr2.Add("A");
//arrStr2.Insert(1, "A");

//03 - Declarar um Array vazio, mas com posições definidas
string[] arrElemeentos = new string[3];
arrElemeentos[0] = "Ar";
arrElemeentos[1] = "água";
arrElemeentos[2] = "Fogo";
//arrElemeentos[3] = "Terra"; //Erro - O Array possí 3 posições

Console.WriteLine(string.Join(", ", arrElemeentos));

//04 - Declarar uma Array com valores e com posições definidas
string[] arrElementos = new string[4] {"Ar","Água","Fogo", null};

Console.WriteLine("\n---------------------------------------------------------\n");

//Valores padrão do array
//Array de string são ´reenchidos com null
string[] arrStrvazio = new string[3];
Console.WriteLine(arrStrvazio[0] == null);
Console.WriteLine(string.Join(", " , arrStrvazio));

//Array de int são preenchidos com 0 
int[] arrIntvazio = new int[3]; // {0,0,0}
Console.WriteLine(arrIntvazio[0] == 0);
Console.WriteLine(string.Join(", ", arrIntvazio));

//Array de bool são preenchidos com false
bool[] arrBoolvazio = new bool[3]; // {false,false,false}
Console.WriteLine(arrBoolvazio[0] == false);
Console.WriteLine(string.Join(", ", arrBoolvazio));

//Como redimencionar um Array
string[] arrFolgas = { "Sexta", "Sábado" };

Array.Resize(ref arrFolgas, 3);

arrFolgas[2] = "Domingo";
Console.WriteLine (string.Join(", ", arrFolgas));

Console.WriteLine("\n---------------------------------------------------------\n");

//Sobrescrever um valor do Array 
string[] arrSobre = { "A", "b", "C" };

arrSobre[1] = "B";
Console.WriteLine (string.Join(", ", arrSobre));

Console.WriteLine("\n---------------------------------------------------------\n");

//Formas  de conversão
//Converter um Array par a lista - é mais facil para usar os metodos de lista
string[] arrMeses = { "Janeiro", "Fevereiro", "Março" };

List<string> listameses = new List<string>(arrMeses);
Console.WriteLine(string.Join(", ",listameses));

Console.WriteLine("\n---------------------------------------------------------\n");

//Converteer uma Lista para Array
List<int> listaNumeros = new List<int> {1,2,3};

int[] arrNumeros = listaNumeros.ToArray();
Console.WriteLine(string.Join(", ", arrNumeros));

//  CONVERTER UMA STRING EM UM ARRAY

char[] arrletras = "dificil".ToArray();
char[] arrletras2 = "dificil".ToCharArray();

Console.WriteLine(string.Join(",", arrletras));
Console.WriteLine(string.Join(",", arrletras2));

////// METODOS ESTATICOS
// copyT0() - cria uma copia de um array
string[] arrCopy1 = { "C#", "HTML", "Python" };
string[] arrCopy2 = new string[3];

arrCopy1.CopyTo(arrCopy2 , 0);
Console.WriteLine(string.Join(", ", arrCopy2 ));

Console.WriteLine("\n---------------------------------------------------------\n");


// Reverse() - Inverte os elementos de um Array
double[] arrReverse = { 1.5, 2.5, 3.5 };

Array.Reverse(arrReverse);

Console.WriteLine(string.Join (", ", arrReverse ));

Console.WriteLine("\n---------------------------------------------------------\n");

//Sort() - Ordena os elementos de um Array
string[] arrSort = { "B", "D", "C", "A" };

Array.Sort(arrSort);

Console.WriteLine(string.Join(", ", arrSort));

Console.WriteLine("\n---------------------------------------------------------\n");

// IndexOf - Retorna o 1° elemento encontrado
string[] nomes = { "Maria", "Josè", "Maria", "Pedro", "Maria" };

int indice1 = Array.IndexOf(nomes, "Maria");

Console.WriteLine($"Posição inicial: {indice1}");

Console.WriteLine("\n---------------------------------------------------------\n");

// LastIndexOf - Retorna o último elemento encontrado
int indice2 = Array.IndexOf(nomes, "Maria");

Console.WriteLine($"Posição inicial: {indice2}");

Console.WriteLine("\n---------------------------------------------------------\n");

//Metódos para operações matemáticas básicas
int[] arrValores = { 10, 20, 30 };

Console.WriteLine(arrValores.Sum());
Console.WriteLine(arrValores.Average());
Console.WriteLine(arrValores.Max());
Console.WriteLine(arrValores.Min());
Console.WriteLine(arrValores.Count());


//Clear - REMOVE OS ELEMENTOS DO ARRAY 
int[] arrClear = { 1, 2, 3 };

// Array.Clear(Array, PosicaoInicial,QtdEleemntoRemovidos);

Array.Clear(arrClear, 0, 3);

Console.WriteLine(string.Join(",", arrClear));

Console.WriteLine("\n---------------------------------------------------------\n");

// PRORPRIEDADE
//Length - Retorna a qualidade de elementos do array
string[] arrTamanho = { "A", "B", "C", "D" };

int qtd =  arrTamanho.Length;

Console.WriteLine($"Quantidade de elementos: {qtd}");

