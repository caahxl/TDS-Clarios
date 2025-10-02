//  DECLARANDO UMA LISTA EM C#

// LISTA VAZIA
using System.Diagnostics.Metrics;

List<int> lista1 = new List<int> { };

// LISTA COM VALORES
List<bool> list2 = new List<bool> { true, false };

//LISTA COM VALORES

List<string> list3 = new List<string>
{
"Thiago",
"Camilly",
"Ana",
};

// IMPRIMIR VALORES DA LISTA
Console.WriteLine(list3); // imprimi tipo da lista

// PODEMOS IMPRIMIR OS VALORES DA LISTA UTILIZANDO O METODO STRING.JOIN()

Console.WriteLine(string.Join(",", list3));

// IMPRIMIR UM INDICE DA LISTA
Console.WriteLine(list3[5]);

Console.ReadKey();

//METODOS DE LISTA 

// .Add() - ADICIONA UM NOVO ELEMENTO NO FINAL DA LISTA
List<string> listAdd = new List<string> { "Terra", "agua", "fogo" };
listAdd.Add("Ar");

Console.WriteLine(string.Join(",", listAdd));

// .INSERT() - ADICIONA UM NOVO ELEMENTO NA POSIÇÃO INFORMADA

List<string> ListInsert = new List<string> { "Terra", "fogo", "agua" };
ListInsert.Insert(1, "Ar");

Console.WriteLine(string.Join(",", ListInsert));

// REMOVE() - Remove um elemento pelo valor na posição informada
List<string> listRemove = new List<string> { "Terra", "Fogo", "agua", "Ar" };
listRemove.Remove("Agua");

Console.WriteLine(string.Join(",", listRemove));


// REMOVEAT() - REMOVE UM ELEMENTO PELO INDICE INFORMACADO

List<string> listRemove2 = new List<string> { "Terra", "Fogo", "agua", "Ar" };
listRemove2.RemoveAt(1);

Console.WriteLine(string.Join(",", listRemove2));

//INDEXOF - RETORNA A POSICAO DO ELEMENTO INFORMADO
List<string> listIndex = new List<string> { "Terra", "Fogo", "agua", "Ar" };

Console.WriteLine(listIndex.IndexOf("Fogo"));
Console.WriteLine(listIndex.IndexOf("Fogo"));

// Sort - ORDENA OS VALORES DA LISTA EM ORDEM CRESCENTE

List<int> listSort = new List<int> { 2, 3, 5, 1, 4 };
listSort.Sort();


Console.WriteLine(String.Join(",", listSort));


// Reverse - Inverte a posição dos elementos da lista

List<int> listReverse = new List<int> { 1, 2, 3, 4, 5 };

Console.WriteLine(String.Join(",", listReverse));

//AddRange - CONCATENA AS LISTA

List<int> listRange1 = new List<int> { 1, 2, 3 };
List<int> listRange2 = new List<int> { 4, 5, 6 };
listRange1.AddRange(listRange2);

Console.WriteLine(String.Join(",", listRange1));

// MOTODOS PARA OPERACOES ARITMETICAS BASICAS

List<double> listValores = new List<double> { 1.5, 2.6, 3.5, 4.5, 5.5 };

Console.WriteLine(listValores.Sum()); // soma
Console.WriteLine(listValores.Average()); // media
Console.WriteLine(listValores.Max()); // maior valor
Console.WriteLine(listValores.Min()); // menor valor
Console.WriteLine(listValores.Count()); //qtd elementos


// Count - Retorna a quantidade de elementos da lista
List<string> listCount = new List<string> { "terra", "fogo", "agua", "ar" };

Console.WriteLine(listCount.Count);

// Clear - REMOVE TODOS OS ELEMENTOS DA LISTA
List<string> listClear = new List<string> { "terra", "fogo", "agua", "ar" };
listClear.Clear();

Console.WriteLine(string.Join(",", listClear));
