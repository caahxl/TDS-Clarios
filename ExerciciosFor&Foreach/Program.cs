using static System.Runtime.InteropServices.JavaScript.JSType;

void Exercicio01()
{
    // Crie um programa que percorra a lista abaixo e retorne, para cada número, o resultado da multiplicação desse número por 2.

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    foreach (int numero in numeros)
        Console.WriteLine(numero * 2);

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio01();



void Exercicio02()
{
    // Crie um programa que solicite ao usuário um número inteiro e, em seguida,
    // multiplique esse número por cada item da lista abaixo, exibindo os resultados.

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    Console.WriteLine("Digite um número inteiro:");
    int numeroDigitado = int.Parse(Console.ReadLine());

    foreach (int numero in numeros)
        Console.WriteLine(numero * numeroDigitado);

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio02();



void Exercicio03()
{
    // Crie um programa que percorra a lista abaixo e, para cada linguagem, exiba a frase: "Eu quero aprender {nome da linguagem}".

    List<string> linguagens = new List<string> { "C", "C#", "Java", "Python", "Javascript" };

    foreach (string frase in linguagens)
        Console.WriteLine($"Eu quero aprender {frase}");

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio03();



void Exercicio04()
{
    // Utilizando a estrutura de repetição For, crie um programa que imprima os números de 5 a 10.

    for (int numero = 5; numero <= 10; numero++)
        Console.WriteLine(numero);
}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio04();



void Exercicio05()
{
    // Crie um programa que percorra a lista de frutas abaixo e utilize uma estrutura condicional if/else para verificar cada item, sendo:

    // - Se o valor for igual a "Abacaxi", exiba a mensagem: "Eu gosto de Abacaxi"
    // - Senão a mensagem: "Eu não gosto de {nome da fruta}"

    List<string> frutas = new List<string> { "Maçã", "Banana", "Jaca", "Melão", "Abacaxi" };

    foreach (string fruta in frutas)
    {
        if (fruta == "Abacaxi")
            Console.WriteLine($"Eu gosto de {fruta}");
        else
            Console.WriteLine($"Eu não gosto de {fruta}");
    }
}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio05();



void Exercicio06()
{
    // Crie um programa que percorra a lista abaixo e exiba cada número convertido para seu valor negativo.
    // Exemplo: -1, -2, -3, -4, -5, -6, -7, -8, -9, -10

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    foreach (int numero in numeros)
        Console.WriteLine(-numero);

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio06();



void Exercicio07()
{
    // Crie um programa que percorra a lista de números abaixo e, para cada item,
    // utilize uma estrutura condicional if/else para verificar se o número é maior ou menor do que 10.

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    foreach(int numero in numeros)
    {
        if (numero >= 10)
            Console.WriteLine($"O número {numero} é maior ou igual que 10");

        else if(numero < 10)
            Console.WriteLine($"O número {numero} é menor que 10");
    }

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio07();



void Exercicio08()
{
    // Utilizando a estrutura de repetição For, crie um programa que imprima os números de 5 a 0, ou seja, em ordem decrescente.

    for (int numero = 5; numero >= 0; numero--)
        Console.WriteLine($"Valores: {numero}");

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio08();



void Exercicio09()
{
    // Utilizando a estrutura de repetição For, crie um programa que imprima os números de 2 a 10, pulando de 2 em 2.
    // Exemplo: 2, 4, 6, 8, 10

    for (int numero = 2; numero <= 10; numero += 2)
        Console.WriteLine(numero);

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio09();



void Exercicio10()
{
    // Crie um programa que percorra a lista abaixo e exiba cada número elevado ao quadrado.
    // Fórmula: Math.Pow(n, 2)

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    foreach (int numero in numeros)
        Console.WriteLine($"O número {numero} elevado ao quadrado é: {Math.Pow(numero, 2)}");

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio10();



void Exercicio11()
{
    // Crie um programa que percorra a lista e exiba apenas os números menores que 7.

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    foreach (int numero in numeros)
    {
        if (numero < 7)
            Console.WriteLine(numero);
    }
}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio11();

Console.ReadKey();
