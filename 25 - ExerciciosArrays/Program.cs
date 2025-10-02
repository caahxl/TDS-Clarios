using System.Collections;

void Exercicio01()
{
    // Crie um array com os nomes de 5 dias da semana (Segunda a Sexta) e exiba no console:
    // - O primeiro dia
    // - O terceiro dia
    // - O último dia

    string[] arrSemana = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta" };

    Console.WriteLine($"Primeiro dia: {arrSemana[0]}");
    Console.WriteLine($"Segundo dia: {arrSemana[2]}");
    Console.WriteLine($"Último dia: {arrSemana[4]}");

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio01();



void Exercicio02()
{
    // Crie um programa que redimensione o array abaixo para incluir mais um elemento e adicione o valor "Laranja" ao final da lista de frutas.

    string[] frutas = { "Maçã", "Banana", "Uva", "Melão", "Abacaxi" };

    Array.Resize(ref frutas, frutas.Length + 1);
    frutas[frutas.Length - 1] = "Laranja";

    Console.WriteLine(string.Join(", ", frutas));
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio02();



void Exercicio03()
{
    // Crie um programa para retornar a quantidade de elementos presentes no array abaixo.

    string[] carros = { "Volvo", "BMW", "Ford", "FIAT", "Hyundai" };

    Console.WriteLine($"A quantidade de carros: {carros.Length}");

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio03();



void Exercicio04()
{
    // Crie um programa que copie todos os elementos de um array de números inteiros (int) para um novo array do tipo short."

    int[] numeros = { 1, 2, 3, 4, 5 };
    long[] novoArr = new long[5];

    numeros.CopyTo(novoArr, 0);

    Console.WriteLine(string.Join (", ", novoArr));
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio04();



void Exercicio05()
{
    // Crie um programa que localize e exiba a posição da primeira e da última ocorrência da palavra "Creta" do array abaixo.

    string[] carros = { "HB20", "Creta", "Tucson", "Ioniq", "Creta", "HB20S" };

    int primeira = Array.IndexOf(carros, "Creta");
    int ultima = Array.LastIndexOf(carros, "Creta");

    Console.WriteLine($"Primeira occorrência de Creta: {primeira}");
    Console.WriteLine($"Última occorrência de Creta: {ultima}");


}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio05();



void Exercicio06()
{
    // Converta a Lista e a String abaixo para o tipo Array

    List<string> lista = new List<string> { "Maria", "José", "Ana", "Pedro", "Paula" };
    string palavra = "Métodos";

    string[] arrList = lista.ToArray();

    char[] arrStr = palavra.ToCharArray(); // ToCharArrya - Somente char | ToArray - Ideal/Flexivel

    Console.WriteLine("Lista convertida para array: " + string.Join(", ", arrList));
    Console.WriteLine("String convertida para array: " + string.Join(", ", arrStr));

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio06();



void Exercicio07()
{
    // Crie um array com 5 nomes e exiba-os:
    // - Na ordem original
    // - Na ordem inversa

    string[] nomes = { "Santiana", "Camis", "Milly", "Cah", "Chamito" };

    Console.WriteLine("Ordem original: " + string.Join(", ", nomes));

    Array.Reverse(nomes);

    Console.WriteLine("Ordem inversa: " + string.Join(", ", nomes));

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio07();



void Exercicio08()
{
    // Crie um programa para ordenar os elementos dos arrays abaixo em ordem Alfabetica.

    string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio" };
    int[] numeros = { 50, 40, 30, 20, 10 };

    Array.Sort(meses);
    Array.Sort(numeros);

    Console.WriteLine(string.Join("Números Ordenados: ", numeros));
    Console.WriteLine(string.Join("Meses Ordenados: ", meses));
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio08();



void Exercicio09()
{
    // Crie um programa para imprimir as ações indicadas no array a seguir.

    // 1. Exiba a soma dos valores.
    // 2. Exiba o maior valor.
    // 3. Exiba o menor valor.
    // 4. Exiba a média dos valores.
    // 5. Exiba a quantidade de elementos contidos na lista.

    int[] numeros = { 5, 7, 8, 6, 9, 1, 4, 0, 3, 2 };

    Console.WriteLine($"Soma:{numeros.Sum()}");

    Console.WriteLine($"Maior Valor: {numeros.Average()}");

    Console.WriteLine($"Menor Valor: {numeros.Max()}");

    Console.WriteLine($"Média dos Valores: {numeros.Min()}");

    Console.WriteLine($"Quantidade de Elemntos Contido na Lista: {numeros.Count()}");

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio09();



void Exercicio10()
{
    // Crie um programa que:
    // 1. Solicite ao usuário que informe o nome que deseja localizar no array de convidados.
    // 2. Verificar se o nome informado está presente na frase, sendo:

    // - Se o nome informado estiver presente no array de convidados, exiba:
    // >>> {nome} foi convidado(a).
    // - Senão, exiba:
    // >>> {nome} não foi convidado(a).

    string[] convidados = { "Maria", "José", "Ana", "Pedro", "Paula", "João" };

    Console.WriteLine("Informe o nome que deseja localizar no array de convidados:");
    string nome = Console.ReadLine();

    // Verificar se o nome está no array (ignorando maiúsculas/minúsculas)
    bool existe = convidados.Contains(nome);

    if (existe)
        Console.WriteLine($"{nome} foi convidado(a).");
    else
        Console.WriteLine($"{nome} não foi convidado(a).");
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio10();

Console.ReadKey();