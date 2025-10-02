void Exercicio01()
{
    // Utilize o operador de índice reverso, imprima o item "Abacaxi" do array abaixo:

    string[] arr = { "Maça", "Banana", "Uva", "Melão", "Abacaxi", "Laranja", "Kiwi" };

    Console.WriteLine(arr[^3]);

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio01();



void Exercicio02()
{
    // Utilize o operador de índice reverso, imprima o item 9 do array abaixo:

    int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    Console.WriteLine(arr[^2]);

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio02();



void Exercicio03()
{
    // Utilize o operador de índice reverso, faça o fatiamento do array abaixo para retornar apenas os elementos: [8, 9, 10].

    int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int[] fatia = arr[^3..];

    Console.WriteLine(string.Join(", ", fatia));
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio03();



void Exercicio04()
{
    // Utilize o operador de índice reverso, faça o fatiamento do array abaixo para retornar apenas os elementos: [6, 7, 8].

    int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int[] fatia = arr[6..^2];

    Console.WriteLine(string.Join(", ", fatia));
}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio04();



void Exercicio05()
{
    // Utilize o operador de índice reverso, faça o fatiamento do array abaixo para retornar apenas os elementos: ["Maça", "Banana", "Uva", "Melão"].

    string[] arr = { "Maça", "Banana", "Uva", "Melão", "Abacaxi", "Laranja" };

    string[] fatia = arr[..^2];

    Console.WriteLine(string.Join(", ", fatia));
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio05();



void Exercicio06()
{
    // Utilize o operador de índice reverso para obter do array abaixo apenas os dias da semana:
    // Saída: "SEG, TER, QUA, QUI, SEX"

    string[] arr = { "SEG", "TER", "QUA", "QUI", "SEX", "SAB", "DOM" };

    string[] fatia = arr[..^2];

    Console.WriteLine(string.Join(", ", fatia));

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio06();



void Exercicio07()
{
    // Utilize o operador de índice reverso para obter do array abaixo apenas os dias de fim de semana:
    // Saída: "SAB, DOM"

    string[] arr = { "SEG", "TER", "QUA", "QUI", "SEX", "SAB", "DOM" };

    string[] fatia = arr[^2..];

    Console.WriteLine(string.Join(", ", fatia));

}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio07();



void Exercicio08()
{
    // Utilize o operador de índice reverso para obter do array abaixo apenas os meses do 1º Trimestre:
    // Saída: "Janeiro, Fevereiro, Março"

    string[] arr = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho" };

    string[] fatia = arr[..^3];

    Console.WriteLine(string.Join(", ", fatia));
}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio08();



void Exercicio09()
{

    // Utilize o operador de índice reverso para obter do array abaixo apenas os meses do 2º Trimestre:
    // Saída: "Abril, Maio, Junho"

    string[] arr = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho" };

    string[] fatia = arr[^3..];

    Console.WriteLine(string.Join(", ", fatia));

}
// Descomente o bloco de código abaixo para executar o exercício
 Exercicio09();



void Exercicio10()
{
    // Utilize o operador de índice reverso para obter da string abaixo apenas os elementos especificados:
    // Saída: "C#"

    string frase = "Programação em C#";
    
    var fatia = frase[^2..];

    Console.WriteLine(string.Join(", ", fatia));
}
// Descomente o bloco de código abaixo para executar o exercício
 //Exercicio10();

Console.ReadKey();
