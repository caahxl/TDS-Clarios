// Estrutura de repetição While

void exemplo01()
{
    Console.WriteLine("Digite a sua senha:");
    string senha = Console.ReadLine();
    //ToLower converte para minusculo
    while (senha != "senai")
    {
        Console.WriteLine("Senha incorreta!");
        Console.WriteLine("Digite a sua senha:");
        senha = Console.ReadLine();
    }

    Console.WriteLine("Fim");

}
//exemplo01();

void exemplo02()
{
    int contador = 0;
    while (contador <= 5)
    {
        contador++;
        Console.WriteLine($"Contador: {contador}");
    }

    Console.WriteLine("Fim");
}
//exemplo02();

void exercicio03()
{
    int contador = 5;
    while (contador < 5)
    {
        contador++;
        Console.WriteLine($"Contador: {contador}");
    }

    Console.WriteLine("Fim");
}
//exemplo03();

void exercicio04()
{
    int contador = 0;
    while (contador < 5)
    {
        contador++;
        Console.WriteLine($"Contador: {contador}");
    }

    Console.WriteLine("Fim");
}
//exemplo04();

void exemplo05()
{
    int contador = 0;

    while (contador < 10)
    {
        contador++;
        Console.WriteLine($"Contador{contador}");
        if (contador == 5)
            break;
    }
}
//exemplo05();

//while com condição true +limitador
void exemplo6()
{
    int tentativas = 0;

    while (true)
    {

        Console.WriteLine($"Deseja sair do loop agora? [sim/não]");
        string resposta = Console.ReadLine();

        if (resposta == "sim")
            break;

        Console.WriteLine("O lopo deve continuar...");
    }

    Console.WriteLine("Fim");
}
exemplo6();

// While com condição true + limitador
void exercicio07()
{
    int tentativas = 0;
    while (true)
    {
        tentativas++;

        Console.WriteLine("Deseja sair do loop agora? [sim/não]");
        string respoata = Console.ReadLine();

        // se digitar "sim"
        if (respoata == "sim")
            break;

        // mais de 3 tentativas
        if (tentativas > 3)
        {
            Console.WriteLine("Você atingiu o limite de tentativas");
            break;
        }

        Console.WriteLine("O loop deve continuar...");
    }
}
exercicio07();

void exemplo08()
{
    int i = 0;

    while (i < 5)
    {
        i++;
        int resto = i % 2;

        if (resto == 0)
            Console.WriteLine($"O número é {i} é par");
        else
            Console.WriteLine($"O número é {i} é ímpar");
    }
}
exemplo08();

Console.ReadKey();