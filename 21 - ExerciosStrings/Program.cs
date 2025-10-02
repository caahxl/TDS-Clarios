﻿using System.Globalization;

void Exercicio01()
{
    // Converta as letras das strings abaixo conforme a lista abaixo.

    // 1. PROGRAMAÇÃO para programação
    // 2. métodos para MÉTODOS

    string s1 = "PROGRAMAÇÃO";
    string s2 = "métodos";

    Console.WriteLine(s1.ToLower());
    Console.WriteLine(s2.ToUpper());

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio01();



void Exercicio02()
{
    // Crie um programa que substitua a palavra "Charpe" para "Sharp".
    string valor = "Programação em C Charpe";

    Console.WriteLine(valor.Replace("Charpe", "Sharp"));

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio02();



void Exercicio03()
{
    // Crie um programa que solicite ao usuário a digitação de uma palavra e, em seguida,
    // utilize uma propriedade para retornar a quantidade de caracteres dessa palavra.

    // Entrada: Programação
    // Saída: 11 letras

    Console.WriteLine("Digite uma palavra:");
    string palavra = Console.ReadLine();

    Console.WriteLine($"Sua palavra {palavra} contém {palavra.Length} letras");

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio03();



void Exercicio04()
{
    // Crie um programa que concatene as variáveis abaixo para formar e exibir as palavras abaixo:

    // 1. Programação em Python
    // 2. Programação em C#
    // 3. Programação em PHP

    string s1 = "Programação ";
    string s2 = "em ";
    string s3 = "Python";
    string s4 = "C#";
    string s5 = "PHP";

    Console.WriteLine(string.Join(" ", s1, s2, s3));
    Console.WriteLine(string.Join(" ", s1, s2, s4));
    Console.WriteLine(string.Join(" ", s1, s2, s5));
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio04();



void Exercicio05()
{
    // Crie um programa que solicite o nome completo do usuário e, em seguida, formate-o de modo que a
    // primeira letra de cada nome seja convertida para maiúscula e as demais letras fiquem em minúsculas.

    Console.WriteLine("Digite seu nome completo:");
    string nome = Console.ReadLine();
    nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome);
    Console.WriteLine(nome);


}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio05();



void Exercicio06()
{
    // Crie um programa que solicite ao usuário que informe o nome de um produto.
    // Após a entrada dos dados, verifique se o valor informado é nulo ou vazio.

    // - Se o valor informado for inválido (nulo ou vazio), exiba:
    // >>> Nome do produto inválido.
    // - Senão, exiba:
    // >>> Produto cadastrado com sucesso!

    Console.WriteLine("Digite nome de um produto:");
    string produto = Console.ReadLine();

    Console.WriteLine(string.IsNullOrWhiteSpace(produto) ? "Nome do produto inválido." : "Produto cadastrado com sucesso!");

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio06();



void Exercicio07()
{
    // Crie um programa que remova todos os caracteres especiais "-" das strings fornecidas.

    string s1 = "C#---";
    string s2 = "---Programação em C#";
    string s3 = "Mé---todos de String";

    Console.WriteLine(s1.Remove(2));
    Console.WriteLine(s2.Substring(3, 17));
    Console.WriteLine(s3.Remove(2, 3));

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio07();



void Exercicio08()
{
    // Crie um programa que mantenha apenas os nomes próprios contidos nas strings fornecidas.

    string s1 = "Dr. Pedro Antonio";
    string s2 = "Dra. Ana Velba";
    string s3 = "Prof. João Felipe";
    string s4 = "Enga. Letícia Moura";

    s1 = s1.Replace("Dr.", " ");
    s2 = s2.Replace("Dra.", " ");
    s3 = s3.Replace("Prof.", " ");
    s4 = s4.Replace("Enga.", " ");

    Console.WriteLine(s1);
    Console.WriteLine(s2);
    Console.WriteLine(s3);
    Console.WriteLine(s4);




}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio08();



void Exercicio09()
{
    // Crie um programa que localize determinadas palavras dentro de strings fornecidas e exiba a posição (índice) em que cada uma delas foi encontrada.

    // 1. Posição da palavra String
    // 2. Posição da palavra C#
    // 3. Posição da palavra Back-end

    string s1 = "Métodos de String";
    string s2 = "Programção em C#";
    string s3 = "Desenvolvimento Back-end";

    int indexString = s1.IndexOf("String");
    int indexCSharp = s2.IndexOf("C#");
    int indexBackend = s3.IndexOf("Back-end");

    Console.WriteLine($"Posição da palavra 'String': {indexString}");
    Console.WriteLine($"Posição da palavra 'C#': {indexCSharp}");
    Console.WriteLine($"Posição da palavra 'Back-end': {indexBackend}");

    Console.WriteLine("\n--------------------------------------------------\n");

    //Outra forma de se fazer
    Console.WriteLine(s1);
    Console.WriteLine(s1.IndexOf("String"));

    Console.WriteLine(s2);
    Console.WriteLine(s2.IndexOf("C#"));

    Console.WriteLine(s3);
    Console.WriteLine(s3.IndexOf("Back-end"));
}
// Descomente o bloco de código abaixo para executar o exercício
Exercicio09();



void Exercicio10()
{
    // Crie um programa que:
    // 1. Solicite ao usuário que digite uma frase.
    // 2. Solicite ao usuário que informe uma palavra que deseja localizar nessa frase.
    // 3. Verificar se a palavra informada está presente na frase, sendo:

    // - Se a palavra informada estiver presente na frase, exiba:
    // >>> A palavra foi encontrada na frase.
    // - Senão, exiba:
    // >>> A palavra não foi encontrada na frase.

    Console.WriteLine("Digite uma frase:");
    string frase = Console.ReadLine();

    Console.WriteLine("Digite uma palavra que queira localizar na frase informada:");
    string palavra = Console.ReadLine();


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio10();

Console.ReadKey();