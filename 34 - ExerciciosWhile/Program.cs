void Exercicio01()
{
    // Declare uma variável e atribua a ela o valor 10 e, em seguida,
    // crie um programa que incremente essa variável em 1 a cada iteração,
    // o loop deve continuar enquanto o valor da variável for menor ou igual a 20.

    int numero = 10;

    while (numero <= 20)
    {

        Console.WriteLine($"Número: {numero}");
        numero++;
    }

    Console.WriteLine("Fim");

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio01();



void Exercicio02()
{
    // Crie um programa que pergunte ao usuário se ele deseja continuar no loop e mantenha a execução enquanto a resposta for diferente de "sair".


    while (true)
    {
        Console.WriteLine($"Deseja continuar no loop? [sim/sair]");
        string resposta = Console.ReadLine();

        if (resposta.ToLower() == "sair")
            break;

        Console.WriteLine("O lopo deve continuar...");
    }

    Console.WriteLine("Fim");
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio02();



void Exercicio03()
{
    // Declare uma variável e atribua a ela o valor 10 e, em seguida,
    // crie um programa que incremente essa variável em 5 a cada iteração,
    // o loop deve continuar enquanto o valor da variável for menor ou igual a 50.

    int numero = 10;

    while (numero <= 50)
    {
        Console.WriteLine(numero);
        numero += 5;
    }
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio03();



void Exercicio04()
{
    // Crie um programa que imprima uma contagem regressiva de 10 até 0.

    int numero = 10;
    while (numero >= 0)
    {
        Console.WriteLine(numero);
        numero--;
    }
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio04();



void Exercicio05()
{
    // Crie um programa que solicite a idade do usuário. Continue pedindo enquanto o valor não for um número positivo.

    int idade = 0;

    while (idade <= 0)
    {
        Console.Write("Digite sua idade (número positivo): ");
        idade = int.Parse(Console.ReadLine());

        if (idade <= 0)
        {
            Console.WriteLine("Idade inválida. Digite um número maior que zero.");
        }
    }
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio05();



void Exercicio06()
{
    // Crie um programa que solicite ao usuário a senha de acesso ao sistema e mantenha a execução do loop enquanto a resposta for diferente de "admin".

    Console.WriteLine("Digite a sua senha:");
    string senha = Console.ReadLine();

    //ToLower converte para minusculo
    while (senha != "admin")
    {
        Console.WriteLine("Senha incorreta!");
        Console.WriteLine("Digite a sua senha:");

        senha = Console.ReadLine();
    }

    Console.WriteLine("Bem-vindo(a) ao Sistema!");
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio06();



void Exercicio07()
{
    // Crie um programa que solicite ao usuário digitar a senha de acesso e continue pedindo enquanto a palavra digitada for diferente de "segredo".

    Console.WriteLine("Digite a sua senha:");
    string senha = Console.ReadLine();

    //ToLower converte para minusculo
    while (senha != "segredo")
    {
        Console.WriteLine("Senha incorreta!");
        Console.WriteLine("Digite a sua senha:");

        senha = Console.ReadLine();
    }

    Console.WriteLine("Bem-vindo(a) ao Sistema!");
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio07();



void Exercicio08()
{
    // Crie um programa que imprima a frase "Programação em C#" cinco vezes.

    string frase = "Programação em C#";
    int contador = 0;

    while (contador < 5)
    {
        Console.WriteLine(frase);
        contador++;
    }

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio08();



void Exercicio09()
{
    // Crie um programa que solicite ao usuário inserir um número inteiro e continue pedindo enquanto o valor informado for maior ou igual a zero.

    while (true)
    {
        Console.Write("Digite um número inteiro:");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("Número inválido. Digite um número maior que zero.");
            break;
        }

    }
}
// Descomente o bloco de código abaixo para executar o exercício
Exercicio09();



void Exercicio10()
{
    // Crie um programa que peça ao usuário para digitar uma palavra e continue executando enquanto a palavra digitada tiver menos de 6 caracteres.
    // Dica: Utilize a propriedade Length para saber o número de caracteres da palavra digitada.

    Console.Write("Digite uma palavra:");
    string resposta = Console.ReadLine();

    int palavra = resposta.Length;

    while (palavra < 6)
    {
        Console.Write("Digite a palavra novamente: ");
        resposta = Console.ReadLine();
        palavra = resposta.Length;

    }

    Console.WriteLine("Palavra ok");
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio10();

Console.ReadKey();
