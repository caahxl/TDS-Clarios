void Exercicio01()
{
    // Escreva um programa que solicite ao usuário um número e, em seguida, exiba o resultado da multiplicação desse número por 5.

    Console.Write("Digite um numero:");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"O resultado do número digitado x 5 é {n1 * 5}");

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio01();



void Exercicio02()
{
    // Escreva um programa que solicite dois números ao usuário, um por vez, e exiba a soma desses dois números ao final.

    Console.Write("Digite o 1º numero:");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o 2º numero:");
    int n2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"A soma dos números {n1} e {n2} é {n1 + n2}");
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio02();



void Exercicio03()
{
    // Escreva um programa que solicite dois números ao usuário, um de cada vez, e exiba o resultado da subtração.

    Console.WriteLine("Digite o 1° número:");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o 2° número:");
    int n2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"A subtração dos números {n1} - {n2} é {n1 - n2}");
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio03();



void Exercicio04()
{
    // Crie o programa abaixo:
    // 1. Solicite ao usuário que informe duas notas semestrais, armazenando cada uma em uma variável distinta.
    // 2. Calcule a soma das duas notas.
    // 3. Calcule a média aritmética das notas, dividindo a soma por 2.
    // 4. Exiba a média final ao usuário.

    Console.WriteLine("Informe a 1° nota semestral:");
    double n1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a 2° nota semestral:");
    double n2 = double.Parse(Console.ReadLine());

    Console.WriteLine($"A soma das duas notas é: {n1 + n2}");

    Console.WriteLine($"A média aritmética das notas é {(n1 + n2) / 2}");

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio04();



void Exercicio05()
{
    // Crie o programa abaixo:
    // 1. Solicite ao usuário que digite um valor em metros;
    // 2. Converta o valor informado para centímetros (multiplicando por 100);
    // 3. Exiba o resultado da conversão.

    Console.WriteLine("Digite um valor em metros;");
    double metros = double.Parse(Console.ReadLine());

    Console.WriteLine($"Convertendo para centímetros o resultado se torna {metros * 100}");

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio05();



void Exercicio06()
{
    // Crie o programa abaixo:
    // 1. Solicite ao usuário que digite um valor em centímetros;
    // 2. Converta o valor informado para metros (dividindo por 100);
    // 3. Exiba o resultado da conversão.

    Console.WriteLine("Digite um valor em centímetros:");
    double centimetros = double.Parse(Console.ReadLine());

    Console.WriteLine($"Convertendo para metros o resultado se torna {centimetros * 100}");
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio06();



void Exercicio07()
{
    // Crie um programa que:
    // 1. Solicite ao usuário o seu ano de nascimento.
    // 2. Calcule a idade atual com base no ano atual (considere que o usuário já fez aniversário este ano).
    // 3. Exiba uma mensagem informando a idade calculada.

    // Exemplo:
    // Se o ano atual for 2025 e o usuário informou o ano de nascimento 2005, o programa deve exibir:
    // Você tem 20 anos.

    Console.WriteLine("Digite o ano de seu nascimento:");
    int ano = int.Parse(Console.ReadLine());

    Console.WriteLine($"Você tem {ano - 2025} anos");

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio07();


void Exercicio08()
{
    // Crie um programa que:
    // 1. Solicite ao usuário que digite um número inteiro.
    // 2. Calcule e exiba o número anterior e o número seguinte ao valor informado.
    // 3. Exiba o resultado da operação.

    // Entrada:  
    // Número: 10

    // Saída:  
    // Número anterior: 9
    // Número seguinte: 11

    Console.WriteLine("Digite um número inteiro:");
    int numero = int.Parse(Console.ReadLine());

    Console.WriteLine($"\n Número anterior: {numero - 1}\n Número seguinte {numero + 1}");

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio08();



void Exercicio09()
{
    // Crie um programa que:
    // 1. Solicite ao usuário que informe uma quantidade de horas.
    // 2. Converta o valor informado para minutos (1 hora = 60 minutos).
    // 3. Exiba o resultado da conversão.

    Console.WriteLine("Digite uma quantidade de horas:");
    int hora = int.Parse(Console.ReadLine());

    Console.WriteLine($"Transformando para minutos {hora} hora = {hora * 60} minutos");

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio09();



void Exercicio10()
{
    // Crie um programa que:
    // 1. Solicite ao cliente quantos quilos de maçã deseja comprar.
    // 2. Calcule o valor total da compra, considerando o preço por quilo da maçã é de 11.00;
    // 3. Exiba o valor final da compra.

    Console.WriteLine("Digite quantos quilos de maçã deseja comprar:");
    double kg = double.Parse(Console.ReadLine());

    Console.WriteLine($"O valor final da compra é {kg * 11.00:c2}");

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio10();



void Exercicio11()
{
    // Crie um programa que:
    // 1. Solicite ao cliente a quantidade de litros de gasolina que deseja abastecer.
    // 2. Calcule o valor total da compra, considerando que o preço do litro de gasolina é de 5.50.
    // 3. Exiba o valor final da compra.

    Console.WriteLine("Digite quantidade de litros de gasolina que deseja abastecer");
    double litros = double.Parse(Console.ReadLine());

    Console.WriteLine($"O valor final da compra é {litros * 5.50:c2}");

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio11();