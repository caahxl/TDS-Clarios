using System;
using System.ComponentModel;

void Exercicio01()
{
    // Crie um programa que solicite ao usuário que informe sua idade e, em seguida, crie as condições abaixo.

    // - Se a idade for maior ou igual a 18 anos, exiba:
    // >>> Você é maior de idade.
    // - Senão, exiba:
    // >>> Você é menor de idade.

    Console.WriteLine("Informe a sua idade:");
    int idade = int.Parse(Console.ReadLine());

    if (idade >= 18)
    {
        Console.WriteLine("Você é maior de idade!");
    }
    else
    {
        Console.WriteLine("Você é menor de idade!");
    }
}
    // Descomente o bloco de código abaixo para executar o exercício
    // Exercicio01();



void Exercicio02()
{
    // Crie um programa que solicite ao usuário que digite um número e, em seguida, crie as condições abaixo.

    // - Se o número for maior que zero, exiba:
    // >>> O número é positivo.
    // - Se o número for menor que zero, exiba:
    // >>> O número é negativo.
    // - Se o número for igual a zero, exiba:
    // >>> O número é zero.

    Console.Write("Digite um número:");
    int numero = int.Parse(Console.ReadLine());

    if (numero > 0)
    {
        Console.WriteLine("O número é positivo!");
    }

    else if (numero < 0)
    {
        Console.WriteLine("O número é negativo");
    }

    else if (numero == 0)
    {
        Console.WriteLine("O número é zeroo!");
    }
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio02();



void Exercicio03()
{
    // Crie um programa que solicite ao usuário que digite uma letra, em seguida, crie as condições abaixo.

    // - Se a letra for igual a F, exiba:
    // >>> Feminino
    // - Se a letra for igual a M, exiba:
    // >>> Masculino
    // - Qualquer outro valor, exiba:
    // >>> Opção inválido

    Console.WriteLine("Digite uma letra:");
    string letra = Console.ReadLine();

    if (letra == "F" || letra == "f")
    {
        Console.WriteLine("Feminino");
    }

    else if (letra == "M" || letra == "m")
    {
        Console.WriteLine("Masculino");
    }

    else
    {
        Console.WriteLine("Opção invalidada!");
    }
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio03();



void Exercicio04()
{
    // Crie um programa que solicite ao usuário que digite dois números inteiros, um de cada vez, e, em seguida, crie as condições abaixo.

    // - Se a soma dos dois números for igual a 10, exiba:
    // >>> A soma dos dois números é igual a 10.
    // - Caso contrário, exiba:
    // >>> A soma dos dois números é diferente de 10.

    Console.WriteLine("Digite o 1° núemero inteiro:");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o 2° núemero inteiro:");
    int n2 = int.Parse(Console.ReadLine());

    int soma = n1 + n2;

    if (soma == 10)
    {
        Console.WriteLine("A soma dos dois números é igual a 10.");
    }

    else
    {
        Console.WriteLine("A soma dos dois números é diferente de 10.");
    }
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio04();



void Exercicio05()
{
    // Crie um programa que solicite ao usuário que digite dois números inteiros, um de cada vez, e, em seguida, crie as condições abaixo.

    // - Se o primeiro número for maior que o segundo, exiba:
    // >>> O primeiro número é maior que o segundo.
    // - Se o primeiro número for menor que o segundo, exiba:
    // >>> O primeiro número é menor que o segundo.
    // - Se os dois números forem iguais, exiba:
    // >>> O primeiro número é igual ao segundo.

    Console.WriteLine("Digite o 1° núemero inteiro:");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o 2° núemero inteiro:");
    int n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine("O primeiro número é maior que o segundo.");
    }

    else if (n1 < n2)
    {
        Console.WriteLine("O primeiro número é menor que o segundo.");
    }

    else if (n1 == n2)
    {
        Console.WriteLine("O primeiro número é igual ao segundo.");
    }
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio05();



void Exercicio06()
{
    // Crie um programa que verifique se a senha informada pelo usuário está correta. A senha válida é: 1234.  
    // Após a entrada do usuário, exiba uma das seguintes mensagens:

    // - Se a senha estiver correta, exiba:
    // >>> ACESSO PERMITIDO
    // - Se a senha estiver incorreta, exiba:
    // >>> ACESSO NEGADO

    int senha = 1234;

    Console.WriteLine("Digite a sua senha:");
    senha = int.Parse(Console.ReadLine());

    if (senha == 1234)
    {
        Console.WriteLine("ACESSO PERMITIDO");
    }

    else
    {
        Console.WriteLine("ACESSO NEGADO..");
    }
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio06();



void Exercicio07()
{
    // Crie um programa que solicite ao usuário que digite uma senha e, em seguida, solicite que confirme a senha digitada.  
    // Compare as duas entradas e exiba a mensagem correspondente:

    // - Se as senhas forem iguais, exiba:
    // >>> SENHA CORRETA
    // - Se as senhas forem diferentes, exiba:
    // >>> SENHA INCORRETA

    Console.WriteLine("Digite uma senha:");
    int senha = int.Parse(Console.ReadLine());

    Console.WriteLine("Confirme a senha digitada:");
    int senhaConfirmada = int.Parse(Console.ReadLine());

    if (senha == senhaConfirmada)
    {
        Console.WriteLine("SENHA CORRETA");
    }

    else
    {
        Console.WriteLine("SENHA INCORRETA..");
    }
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio07();



void Exercicio08()
{
    // Crie um programa que solicite ao usuário que informe a nota final do aluno e, em seguida, crie as condições abaixo.

    // - Se a nota final for maior ou igual a 5, exiba:
    // >>> Você está aprovado.
    // - Se a nota final for menor que 5, exiba:
    // >>> Você está reprovado.

    Console.WriteLine("Informe a nota final do aluno:");
    double nota = double.Parse(Console.ReadLine());

    if (nota >= 5)
    {
        Console.WriteLine("Você está aprovado.");
    }

    else if (nota < 5)
    {
        Console.WriteLine("Você está reprovado.");
    }

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio08();



void Exercicio09()
{
    // Crie um programa que solicite ao usuário que digite dois números inteiros e, em seguida, crie as condições abaixo.

    // - Se os números forem iguais, exiba:
    // >>> Os números digitados são iguais.
    // - Caso contrário, exiba:
    // >>> Os números digitados são diferentes.

    Console.WriteLine("Digite o 1° números inteiro:");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o 2° números inteiro:");
    int n2 = int.Parse(Console.ReadLine());

    if (n1 == n2)
    {
        Console.WriteLine("Você está aprovado.");
    }

    else
    {
        Console.WriteLine("Os números digitados são diferentes.");
    }
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio09();



void Exercicio10()
{
    // Crie um programa que solicite ao usuário que informe seu salário e o valor dos seus gastos e, em seguida, calcule a diferença entre o salário e os gastos para obter o saldo.Por fim, crie as condições abaixo.

    // - Se o saldo for maior ou igual a zero, exiba:
    // >>> Gastos sob controle.
    // - Senão, exiba:
    // >>> Gastos fora do controle.

    Console.WriteLine("Informe o seu salário:");
    double salario = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor dos seus gastos:");
    double gastos = double.Parse(Console.ReadLine());

    double saldo = salario - gastos;

    if ( saldo >= 0)
    {
        Console.WriteLine("Gastos sob controle.");
    }

    else
    {
        Console.WriteLine("Gastos fora do controle.");
    }
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio10();



void Exercicio11()
{
    // Crie um programa que solicite ao usuário que informe o código correspondente ao idioma em que deseja ser recebido, conforme a lista abaixo:

    // - Digite 1 para receber a mensagem em Espanhol: Bienvenido
    // - Digite 2 para receber a mensagem em Francês: Bienvenue
    // - Digite 3 para receber a mensagem em Português: Bem-vindo
    // - Digite 4 para receber a mensagem em Inglês: Welcome
    // - Para qualquer outro valor informado, exiba: Código inválido

    Console.Write("Digite seu nomee:");
    string nome = Console.ReadLine();

    Console.Write("Informe o código correspondente ao idioma em que deseja ser recebido:\n1 - Espanhol \n2 - Francês \n3 - Português \n4 - Inglês \n");
    int idioma = int.Parse(Console.ReadLine());

    if (idioma == 1)
    {
        Console.WriteLine($"Bienvenido {nome}");
    }

    else if (idioma == 2)
    {
        Console.WriteLine($"Bienvenue {nome}");
    }
    else if (idioma == 3)
    {
        Console.WriteLine($"Bem-vindo! {nome}");
    }

    else

    {
     Console.WriteLine("Código inválido");
    }
}
    // Descomente o bloco de código abaixo para executar o exercício
    //Exercicio11();



    void Exercicio12()
{
    // Crie um programa que solicite ao usuário que informe uma cor do semáforo e, em seguida, verifique a cor informada e exiba uma das mensagens abaixo:

    // - Se a cor for VERDE, exiba:
    // >>> Siga em frente
    // - Se a cor for AMARELO, exiba:
    // >>> Atenção
    // - Se a cor for VERMELHO, exiba:
    // >>> Pare o carro
    // - Para qualquer outra cor, exiba:
    // >>> Sinal inválido


    Console.Write("Informe uma cor do semáforo:");
    string cor = Console.ReadLine().ToUpper;

    if (cor == "VERDE")
    {
        Console.WriteLine("Siga em frente!");
    }

    else if (cor == "AMARELO")
    {
        Console.WriteLine("Atenção camaradaa!");
    }
    else if (cor == "VERMELHO")
    {
        Console.WriteLine("PARE o seu veículo!");
    }

    else

    {
        Console.WriteLine("Sinal inválido meu camaradaa");
    }
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio12();